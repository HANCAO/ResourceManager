using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;
using System.Runtime.InteropServices;

namespace explorer
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        static extern uint GetDriveType(string name);
        // 该函数用来获取磁盘的大小和可用空间
        [DllImport("kernel32")]
        static extern bool GetDiskFreeSpaceEx
        (
            string lpDirectoryName,
            ref long lpFreeBytesAvailable,
            ref long lpTotalNumberOfBytes,
            ref long lpTotalNumberOffFreeBytes
        );

        public Form1()
        {
            InitializeComponent();
        }

        int nDirLevel = 0;
        // 获取所有逻辑盘并列出硬盘中的所有目录
        public void ListDrives()
        {
            TreeNode tn;
            // 获取系统中的所有逻辑盘
            string[] drives = Directory.GetLogicalDrives();
            // 向树视图中添加节点
            tvDir.BeginUpdate();
            for (int i = 0; i < drives.Length; i++)
            {
                // 根据驱动器的不同类型来确定所进行的操作
                switch (GetDriveType(drives[i]))
                {
                    case 2:      				// 软驱
                        // 仅向树视图中添加节点而不列举它的目录
                        // 它的图像索引以及处于选择状态下的图像索引分别为 0和 0 
                        tn = new TreeNode(drives[i], 0, 0);
                        break;
                    case 3:                    		// 硬盘
                        // 除了向树视图中添加节点外还要列举它的目录
                        tn = new TreeNode(drives[i], 1, 1);
                        ListDirs(tn, drives[i]);      	// 列举硬盘中的目录
                        break;
                    case 5:                     	// 光驱
                        // 仅向树视图中添加节点
                        tn = new TreeNode(drives[i], 2, 2);
                        break;
                    default:
                        tn = new TreeNode(drives[i], 0, 0);
                        break;
                }
                tvDir.Nodes.Add(tn);    			// 把创建的节点添加到树视图中
            }
            tvDir.EndUpdate();
            // 把C盘设为当前选择节点
            tvDir.SelectedNode = tvDir.Nodes[1];
        }

        //列出指定目录
        private void ListDirs(TreeNode tn, string strDir)
        {
            if (nDirLevel > 4)
            {
                nDirLevel = 0;
                return;
            }
            nDirLevel++;
            string[] arrDirs;
            TreeNode tmpNode;
            try
            {	// 获取指定目录下的所有目录
                arrDirs = Directory.GetDirectories(strDir);
                if (arrDirs.Length == 0) return;
                // 把每一个子目录添加到参数传递进来的树视图节点中
                for (int i = 0; i < arrDirs.Length; i++)
                {
                    tmpNode = new TreeNode(Path.GetFileName(arrDirs[i]), 3, 4);
                    // 对于每一个子目录，都进行递归列举
                    ListDirs(tmpNode, arrDirs[i]);
                    tn.Nodes.Add(tmpNode);
                }
            }
            catch
            {
                return;
            }
        }

        // 列出指定目录下的所有子目录和文件
        private void ListDirsAndFiles(string strDir)
        {
            ListViewItem lvi;
            int nImgIndex;
            string[] items = new string[4];
            string[] dirs;
            string[] files;
            try
            {
                // 获取指定目录下的所有子目录
                dirs = Directory.GetDirectories(strDir);
                // 获取指定目录下的所有文件
                files = Directory.GetFiles(strDir);
            }
            catch
            {
                return;
            }
            // 把子目录和文件添加到文件列表视图中
            lvFiles.BeginUpdate();
            lvFiles.Clear();					// 清除列表视图中的所有内容

            // 添加4个列表头
            lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName, chSize, chType, chTime });
            // 把子目录添加到列表视图中
            for (int i = 0; i < dirs.Length; i++)
            {
                items[0] = Path.GetFileName(dirs[i]);
                items[1] = "";
                items[2] = "文件夹";
                items[3] = Directory.GetLastWriteTime(dirs[i]).ToLongDateString()
                        + "" + Directory.GetLastWriteTime(dirs[i]).ToLongTimeString();
                lvi = new ListViewItem(items, 3);
                lvFiles.Items.Add(lvi);
            }
            // 把文件添加到列表视图中
            for (int i = 0; i < files.Length; i++)
            {
                string ext = (Path.GetExtension(files[i])).ToLower();
                // 根据不同的扩展名，来设定列表项的图标
                if (ext == ".txt")
                {
                    nImgIndex = 0;
                }
                else if (ext == ".bmp")
                {
                    nImgIndex = 1;
                }
                else if (ext == ".hlp")
                {
                    nImgIndex = 2;
                }
                else if (ext == ".exe")
                {
                    nImgIndex = 3;
                }
                else if(ext==".html"||ext==".htm")
                {
                    nImgIndex = 4;
                }
                else
                {
                    nImgIndex = 5;
                }
                items[0] = Path.GetFileName(files[i]);
                FileInfo fi = new FileInfo(files[i]);
                items[1] = fi.Length.ToString();
                items[2] = ext + "文件";
                items[3] = fi.LastWriteTime.ToLongDateString() + " " + fi.LastWriteTime.ToLongTimeString();
                lvi = new ListViewItem(items, nImgIndex);
                lvFiles.Items.Add(lvi);
            }
            lvFiles.EndUpdate();
        }

        // 打开列表视图中当前选择的文件
        private void OpenFile()
        {
            if (lvFiles.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "请先选择要打开的文件!", "打开文件", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ListViewItem lvi = lvFiles.SelectedItems[0];
            if (Path.GetExtension(lvi.Text).ToLower() != ".txt")
            {
                MessageBox.Show(this, "只能打开的文本文件!", "打开文件错误", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            ContentForm fileForm = new ContentForm();
            fileForm.Text = "查看文件内容" + lvi.Text;
            string filename = tvDir.SelectedNode.FullPath + "\\" + lvFiles.SelectedItems[0].Text;
            StreamReader sr = new StreamReader(filename);
            ArrayList lines = new ArrayList();
            //从文件中读取内容并把它们赋给显示文件内容对话框中txtContent的文本框
            while (sr.Peek() != -1)
            {
                lines.Add(sr.ReadLine());			//一次读取一行数据
            }
            fileForm.txtContent.Lines = (string[])lines.ToArray(Type.GetType("System.String"));
            sr.Close();
            fileForm.txtContent.Select(0, 0);
            fileForm.ShowDialog(this);//显示对话框
        }

        // 在当前选择的目录中创建一个新的文本文件
        private void NewFile()
        {
            string filename = "";
            InputFileName formFileName = new InputFileName();
            if (formFileName.ShowDialog(this) == DialogResult.OK)
            {
                if (formFileName.txtFileName.Text == "")
                {
                    MessageBox.Show("请输入文件名");
                    return;
                }
                filename = tvDir.SelectedNode.FullPath + "\\" + formFileName.txtFileName.Text + ".txt";
            }
            else
                return;
            StreamWriter sw = new StreamWriter(filename);
            if (sw != null)
            {
                // 创建新文件后，向其中写入测试内容
                sw.Write("新创建的文本文件\n演示基本的文件输入/输出操作");
                sw.Close();
                ListDirsAndFiles(tvDir.SelectedNode.FullPath);
            }
        }

        // 删除当前选择的文件
        private void DeleteFile()
        {
            if (lvFiles.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "请先选择要删除的文件!", "删除文件", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
                return;
            }
            string filename = tvDir.SelectedNode.FullPath + "\\" + lvFiles.SelectedItems[0].Text;
            if (lvFiles.SelectedItems[0].ImageIndex == 3)
            {
                MessageBox.Show(this, "当前所选的是目录,不是文件,不能进行删除!", "删除文件", MessageBoxButtons.
                             OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                File.Delete(filename);
            ListDirsAndFiles(tvDir.SelectedNode.FullPath);
        }

        // 在当前选择的目录中创建一个新的子目录
        private void NewDirectory()
        {
            string directoryname = "";
            InputFileName formDir = new InputFileName();
            formDir.Text = "输入目录名称";
            formDir.label1.Text = "请输入新目录名称";
            if (formDir.ShowDialog(this) == DialogResult.OK)
            {
                tvDir.SelectedNode.Nodes.Add(new TreeNode(formDir.txtFileName.Text, 3, 4));
                directoryname = tvDir.SelectedNode.FullPath + "\\" + formDir.txtFileName.Text;
                Directory.CreateDirectory(directoryname);
            }
            else
                return;
        }

        // 删除当前选择的目录及其所有的子目录
        private void DeleteDirectory()
        {
            if (MessageBox.Show(this, "确定删除所有的目录" + tvDir.SelectedNode.FullPath + "吗?", "删除目录",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Directory.Delete(tvDir.SelectedNode.FullPath, true);
                tvDir.SelectedNode.Remove();
            }
        }

        // 改变列表视图的显示模式,同时更新菜单项和工具栏按钮的状态
        private void ChangeListViewMode(View newview)
        {
            miLargeIcon.Checked = false;
            miSmallIcon.Checked = false;
            miList.Checked = false;
            miDetail.Checked = false;
            tsbLargeIcon.Checked = false;
            tsbSmallIcon.Checked = false;
            tsbList.Checked = false;
            tsbDetail.Checked = false;
            switch (newview)
            {
                case View.LargeIcon:
                    lvFiles.View = View.LargeIcon;
                    tsbLargeIcon.Checked = true;
                    miLargeIcon.Checked = true;
                    break;
                case View.SmallIcon:
                    lvFiles.View = View.SmallIcon;
                    tsbSmallIcon.Checked = true;
                    miSmallIcon.Checked = true;
                    break;
                case View.List:
                    lvFiles.View = View.List;
                    miList.Checked = true;
                    tsbList.Checked = true;
                    miList.Checked = true;
                    break;
                default:
                    lvFiles.View = View.Details;
                    tsbDetail.Checked = true;
                    miDetail.Checked = true;
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListDrives();
            new InputFileName();
            new ContentForm();
        }

        private void miNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void miOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void miDelFile_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            if (tsb == tsbNew)
                NewFile(); 
            else if (tsb == tsbOpen)
                OpenFile();
            else if (tsb == tsbLargeIcon)
                ChangeListViewMode(View.LargeIcon);
            else if (tsb == tsbSmallIcon)
                ChangeListViewMode(View.SmallIcon);
            else if (tsb == tsbList)
                ChangeListViewMode(View.List);
            else if (tsb == tsbDetail)
                ChangeListViewMode(View.Details);
        }

        private void tvDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            long callerfree = 0, disksize = 0, freespace = 0;
            txtPath.Text = tvDir.SelectedNode.FullPath;
            ListDirsAndFiles(tvDir.SelectedNode.FullPath);
            GetDiskFreeSpaceEx(Path.GetPathRoot(tvDir.SelectedNode.FullPath), ref callerfree, ref disksize, ref freespace);
            freespace /= 1000000;
            //sb.Text = lvFiles.Items.Count.ToString() + "个对象" + "(可用磁盘空间" + freespace.ToString() + "MB)";
        }

        private void lvFiles_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvFiles.SelectedItems[0];
            if (lvi.ImageIndex == 3)
            {
                TreeNode tn = tvDir.SelectedNode;
                for (int i = 0; i < tn.Nodes.Count; i++)
                {
                    if (string.Compare(tn.Nodes[i].Text, lvi.Text) == 0)
                        tvDir.SelectedNode = tn.Nodes[i];
                }
                return;
            }
            OpenFile();
        }

        private void miNewDir_Click(object sender, EventArgs e)
        {
            NewDirectory();
        }

        private void miDelDir_Click(object sender, EventArgs e)
        {
            DeleteDirectory();
        }

        private void miLargeIcon_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.LargeIcon);
        }

        private void lvFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            NewFile(); 
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsbLargeIcon_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.LargeIcon);
        }

        private void tsbSmallIcon_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.SmallIcon);
        }

        private void tsbList_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.List);
        }

        private void tsbDetail_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.Details);
        }

        private void miSmallIcon_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.SmallIcon);
        }

        private void miList_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.List);
        }

        private void miDetail_Click(object sender, EventArgs e)
        {
            ChangeListViewMode(View.Details);
        }
    }
}
