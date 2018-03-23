namespace explorer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSep = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.目录MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDir = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelDir = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miList = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbLargeIcon = new System.Windows.Forms.ToolStripButton();
            this.tsbSmallIcon = new System.Windows.Forms.ToolStripButton();
            this.tsbList = new System.Windows.Forms.ToolStripButton();
            this.tsbDetail = new System.Windows.Forms.ToolStripButton();
            this.tvDir = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FToolStripMenuItem,
            this.目录MToolStripMenuItem,
            this.视图VToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FToolStripMenuItem
            // 
            this.FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewFile,
            this.miOpenFile,
            this.miDelFile,
            this.miSep,
            this.miExit});
            this.FToolStripMenuItem.Name = "FToolStripMenuItem";
            this.FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.FToolStripMenuItem.Text = "文件(&F)";
            // 
            // miNewFile
            // 
            this.miNewFile.Name = "miNewFile";
            this.miNewFile.Size = new System.Drawing.Size(152, 22);
            this.miNewFile.Text = "新建(&N)";
            this.miNewFile.Click += new System.EventHandler(this.miNewFile_Click);
            // 
            // miOpenFile
            // 
            this.miOpenFile.Name = "miOpenFile";
            this.miOpenFile.Size = new System.Drawing.Size(152, 22);
            this.miOpenFile.Text = "打开(&O)";
            this.miOpenFile.Click += new System.EventHandler(this.miOpenFile_Click);
            // 
            // miDelFile
            // 
            this.miDelFile.Name = "miDelFile";
            this.miDelFile.Size = new System.Drawing.Size(152, 22);
            this.miDelFile.Text = "删除(&D)";
            this.miDelFile.Click += new System.EventHandler(this.miDelFile_Click);
            // 
            // miSep
            // 
            this.miSep.Name = "miSep";
            this.miSep.Size = new System.Drawing.Size(149, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "退出(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // 目录MToolStripMenuItem
            // 
            this.目录MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewDir,
            this.miDelDir});
            this.目录MToolStripMenuItem.Name = "目录MToolStripMenuItem";
            this.目录MToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.目录MToolStripMenuItem.Text = "目录(&M)";
            // 
            // miNewDir
            // 
            this.miNewDir.Name = "miNewDir";
            this.miNewDir.Size = new System.Drawing.Size(118, 22);
            this.miNewDir.Text = "新建(&N)";
            this.miNewDir.Click += new System.EventHandler(this.miNewDir_Click);
            // 
            // miDelDir
            // 
            this.miDelDir.Name = "miDelDir";
            this.miDelDir.Size = new System.Drawing.Size(118, 22);
            this.miDelDir.Text = "删除(&D)";
            this.miDelDir.Click += new System.EventHandler(this.miDelDir_Click);
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLargeIcon,
            this.miSmallIcon,
            this.miList,
            this.miDetail});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // miLargeIcon
            // 
            this.miLargeIcon.Name = "miLargeIcon";
            this.miLargeIcon.Size = new System.Drawing.Size(141, 22);
            this.miLargeIcon.Text = "大图标(&L)";
            this.miLargeIcon.Click += new System.EventHandler(this.miLargeIcon_Click);
            // 
            // miSmallIcon
            // 
            this.miSmallIcon.Name = "miSmallIcon";
            this.miSmallIcon.Size = new System.Drawing.Size(152, 22);
            this.miSmallIcon.Text = "小图标(&S)";
            this.miSmallIcon.Click += new System.EventHandler(this.miSmallIcon_Click);
            // 
            // miList
            // 
            this.miList.Name = "miList";
            this.miList.Size = new System.Drawing.Size(152, 22);
            this.miList.Text = "列表(&L)";
            this.miList.Click += new System.EventHandler(this.miList_Click);
            // 
            // miDetail
            // 
            this.miDetail.Name = "miDetail";
            this.miDetail.Size = new System.Drawing.Size(152, 22);
            this.miDetail.Text = "详细资料(&D)";
            this.miDetail.Click += new System.EventHandler(this.miDetail_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPath,
            this.tsbNew,
            this.tsbOpen,
            this.tsbLargeIcon,
            this.tsbSmallIcon,
            this.tsbList,
            this.tsbDetail});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.toolStrip1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 37);
            this.toolStripLabel1.Text = "路径";
            // 
            // txtPath
            // 
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 40);
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(36, 37);
            this.tsbNew.Text = "新建";
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(36, 37);
            this.tsbOpen.Text = "打开";
            this.tsbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbLargeIcon
            // 
            this.tsbLargeIcon.Image = ((System.Drawing.Image)(resources.GetObject("tsbLargeIcon.Image")));
            this.tsbLargeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLargeIcon.Name = "tsbLargeIcon";
            this.tsbLargeIcon.Size = new System.Drawing.Size(48, 37);
            this.tsbLargeIcon.Text = "大图标";
            this.tsbLargeIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLargeIcon.Click += new System.EventHandler(this.tsbLargeIcon_Click);
            // 
            // tsbSmallIcon
            // 
            this.tsbSmallIcon.Image = ((System.Drawing.Image)(resources.GetObject("tsbSmallIcon.Image")));
            this.tsbSmallIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSmallIcon.Name = "tsbSmallIcon";
            this.tsbSmallIcon.Size = new System.Drawing.Size(48, 37);
            this.tsbSmallIcon.Text = "小图标";
            this.tsbSmallIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSmallIcon.Click += new System.EventHandler(this.tsbSmallIcon_Click);
            // 
            // tsbList
            // 
            this.tsbList.Image = ((System.Drawing.Image)(resources.GetObject("tsbList.Image")));
            this.tsbList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbList.Name = "tsbList";
            this.tsbList.Size = new System.Drawing.Size(36, 37);
            this.tsbList.Text = "列表";
            this.tsbList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbList.Click += new System.EventHandler(this.tsbList_Click);
            // 
            // tsbDetail
            // 
            this.tsbDetail.Image = ((System.Drawing.Image)(resources.GetObject("tsbDetail.Image")));
            this.tsbDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetail.Name = "tsbDetail";
            this.tsbDetail.Size = new System.Drawing.Size(60, 37);
            this.tsbDetail.Text = "详细资料";
            this.tsbDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDetail.Click += new System.EventHandler(this.tsbDetail_Click);
            // 
            // tvDir
            // 
            this.tvDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDir.Location = new System.Drawing.Point(12, 91);
            this.tvDir.Name = "tvDir";
            this.tvDir.Size = new System.Drawing.Size(121, 224);
            this.tvDir.TabIndex = 2;
            this.tvDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDir_AfterSelect);
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize,
            this.chType,
            this.chTime});
            this.lvFiles.LargeImageList = this.imageListLarge;
            this.lvFiles.Location = new System.Drawing.Point(219, 91);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(455, 224);
            this.lvFiles.SmallImageList = this.imageListSmall;
            this.lvFiles.TabIndex = 3;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.lvFiles_SelectedIndexChanged);
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "名称";
            // 
            // chSize
            // 
            this.chSize.Text = "大小";
            // 
            // chType
            // 
            this.chType.Text = "类型";
            // 
            // chTime
            // 
            this.chTime.Text = "创建时间";
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "txt_large");
            this.imageListLarge.Images.SetKeyName(1, "bmp_large.png");
            this.imageListLarge.Images.SetKeyName(2, "exe_large.png");
            this.imageListLarge.Images.SetKeyName(3, "hlp_large.png");
            this.imageListLarge.Images.SetKeyName(4, "html_large.png");
            this.imageListLarge.Images.SetKeyName(5, "panda_large.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "txt_small");
            this.imageListSmall.Images.SetKeyName(1, "bmp_small.png");
            this.imageListSmall.Images.SetKeyName(2, "hlp_small.png");
            this.imageListSmall.Images.SetKeyName(3, "exe_small.png");
            this.imageListSmall.Images.SetKeyName(4, "html_small.png");
            this.imageListSmall.Images.SetKeyName(5, "panda_small.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 327);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tvDir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "资源管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbLargeIcon;
        private System.Windows.Forms.ToolStripButton tsbSmallIcon;
        private System.Windows.Forms.ToolStripButton tsbList;
        private System.Windows.Forms.ToolStripButton tsbDetail;
        private System.Windows.Forms.TreeView tvDir;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ToolStripMenuItem FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewFile;
        private System.Windows.Forms.ToolStripMenuItem miOpenFile;
        private System.Windows.Forms.ToolStripMenuItem miDelFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem 目录MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewDir;
        private System.Windows.Forms.ToolStripMenuItem miDelDir;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem miSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem miList;
        private System.Windows.Forms.ToolStripMenuItem miDetail;
        private System.Windows.Forms.ToolStripSeparator miSep;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

