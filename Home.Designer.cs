namespace MiMFa_MockMeeting
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.p_Main = new System.Windows.Forms.Panel();
            this.rtb_Main = new System.Windows.Forms.RichTextBox();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.tlp_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.l_Message = new System.Windows.Forms.Label();
            this.cd_ColorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmb_EditMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_TopM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmb__MenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.titleBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Panel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmb_WrapMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cb_Transparent = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_BackLight = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.l_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.l_ForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p_List = new System.Windows.Forms.Panel();
            this.dgv_Titles = new System.Windows.Forms.DataGridView();
            this.dgv_Titles_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Titles_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Titles_SK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.p_Main.SuspendLayout();
            this.CMS.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.p_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Titles)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Main
            // 
            this.p_Main.Controls.Add(this.rtb_Main);
            this.p_Main.Controls.Add(this.tb_Title);
            this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Main.Location = new System.Drawing.Point(205, 3);
            this.p_Main.Name = "p_Main";
            this.p_Main.Size = new System.Drawing.Size(385, 320);
            this.p_Main.TabIndex = 1;
            this.p_Main.LostFocus += new System.EventHandler(this.p_Main_FocusedChanged);
            // 
            // rtb_Main
            // 
            this.rtb_Main.AcceptsTab = true;
            this.rtb_Main.BackColor = System.Drawing.Color.DimGray;
            this.rtb_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Main.EnableAutoDragDrop = true;
            this.rtb_Main.ForeColor = System.Drawing.Color.White;
            this.rtb_Main.Location = new System.Drawing.Point(0, 16);
            this.rtb_Main.Name = "rtb_Main";
            this.rtb_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_Main.Size = new System.Drawing.Size(385, 304);
            this.rtb_Main.TabIndex = 1;
            this.rtb_Main.Text = "";
            this.rtb_Main.TextChanged += new System.EventHandler(this.rtb_Main_TextChanged);
            this.rtb_Main.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            // 
            // tb_Title
            // 
            this.tb_Title.BackColor = System.Drawing.Color.DimGray;
            this.tb_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_Title.ForeColor = System.Drawing.Color.White;
            this.tb_Title.Location = new System.Drawing.Point(0, 0);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(385, 16);
            this.tb_Title.TabIndex = 5;
            this.tb_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Title.TextChanged += new System.EventHandler(this.rtb_Main_TextChanged);
            this.tb_Title.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            // 
            // tlp_Menu
            // 
            this.tlp_Menu.AutoSize = true;
            this.tlp_Menu.ColumnCount = 7;
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Menu.Location = new System.Drawing.Point(0, 28);
            this.tlp_Menu.Name = "tlp_Menu";
            this.tlp_Menu.RowCount = 1;
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Menu.Size = new System.Drawing.Size(593, 0);
            this.tlp_Menu.TabIndex = 6;
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.ShowImageMargin = false;
            this.CMS.Size = new System.Drawing.Size(166, 76);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Visible = false;
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "Mock Metting XML File (*.xml)| *.xml";
            this.OFD.RestoreDirectory = true;
            this.OFD.Title = "Load a File";
            // 
            // SFD
            // 
            this.SFD.Filter = "Mock Metting XML File (*.xml)| *.xml";
            this.SFD.RestoreDirectory = true;
            this.SFD.Title = "Save to a File";
            // 
            // l_Message
            // 
            this.l_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.l_Message.Location = new System.Drawing.Point(0, 354);
            this.l_Message.Name = "l_Message";
            this.l_Message.Padding = new System.Windows.Forms.Padding(5);
            this.l_Message.Size = new System.Drawing.Size(593, 32);
            this.l_Message.TabIndex = 2;
            this.l_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.BackgroundImage = global::MiMFa_MockMeeting.Properties.Resources.Dark3;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton2,
            this.toolStripButton5,
            this.toolStripButton1,
            this.btn_Reset,
            this.toolStripSeparator3,
            this.tsm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 5);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(593, 28);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::MiMFa_MockMeeting.Properties.Resources.grid_white;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(27, 20);
            this.toolStripDropDownButton1.Text = "Mock Meeting";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.NewMock);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.LoadMock);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveMock);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.saveAsToolStripMenuItem1.Text = "SaveAs";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.SaveAsMock);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MiMFa_MockMeeting.Properties.Resources.plus_white;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "New";
            this.toolStripButton2.Click += new System.EventHandler(this.NewMock);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::MiMFa_MockMeeting.Properties.Resources.arrow_d_white;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton5.Text = "Open";
            this.toolStripButton5.Click += new System.EventHandler(this.LoadMock);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MiMFa_MockMeeting.Properties.Resources.arrow_u_white;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "Save As";
            this.toolStripButton1.Click += new System.EventHandler(this.SaveAsMock);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Reset.Image = global::MiMFa_MockMeeting.Properties.Resources.refresh_white;
            this.btn_Reset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(23, 20);
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            this.btn_Reset.VisibleChanged += new System.EventHandler(this.btn_Reset_VisibleChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsm
            // 
            this.tsm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmb_EditMode,
            this.tsmi_TopM,
            this.tsmb__MenuBar,
            this.titleBarToolStripMenuItem,
            this.tsmi_Panel,
            this.tsmb_WrapMode,
            this.toolStripSeparator4,
            this.cb_Transparent,
            this.cb_BackLight,
            this.themeToolStripMenuItem,
            this.toolStripSeparator5,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.tsm.Image = global::MiMFa_MockMeeting.Properties.Resources.gear_white;
            this.tsm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsm.Name = "tsm";
            this.tsm.Size = new System.Drawing.Size(27, 20);
            this.tsm.Text = "Setting";
            // 
            // tsmb_EditMode
            // 
            this.tsmb_EditMode.Checked = true;
            this.tsmb_EditMode.CheckOnClick = true;
            this.tsmb_EditMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmb_EditMode.Name = "tsmb_EditMode";
            this.tsmb_EditMode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmb_EditMode.Size = new System.Drawing.Size(222, 22);
            this.tsmb_EditMode.Text = "Edit Mode";
            this.tsmb_EditMode.CheckedChanged += new System.EventHandler(this.toolStripMenuItem2_CheckedChanged_1);
            // 
            // tsmi_TopM
            // 
            this.tsmi_TopM.Checked = true;
            this.tsmi_TopM.CheckOnClick = true;
            this.tsmi_TopM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_TopM.Name = "tsmi_TopM";
            this.tsmi_TopM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmi_TopM.Size = new System.Drawing.Size(222, 22);
            this.tsmi_TopM.Text = "Top Window";
            this.tsmi_TopM.CheckedChanged += new System.EventHandler(this.toolStripMenuItem2_CheckedChanged);
            // 
            // tsmb__MenuBar
            // 
            this.tsmb__MenuBar.Checked = true;
            this.tsmb__MenuBar.CheckOnClick = true;
            this.tsmb__MenuBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmb__MenuBar.Name = "tsmb__MenuBar";
            this.tsmb__MenuBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tsmb__MenuBar.Size = new System.Drawing.Size(222, 22);
            this.tsmb__MenuBar.Text = "Menu Bar";
            this.tsmb__MenuBar.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged_1);
            // 
            // titleBarToolStripMenuItem
            // 
            this.titleBarToolStripMenuItem.Checked = true;
            this.titleBarToolStripMenuItem.CheckOnClick = true;
            this.titleBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.titleBarToolStripMenuItem.Name = "titleBarToolStripMenuItem";
            this.titleBarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.titleBarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.titleBarToolStripMenuItem.Text = "Title Bar";
            this.titleBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.titleBarToolStripMenuItem_CheckedChanged);
            // 
            // tsmi_Panel
            // 
            this.tsmi_Panel.Checked = true;
            this.tsmi_Panel.CheckOnClick = true;
            this.tsmi_Panel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_Panel.Name = "tsmi_Panel";
            this.tsmi_Panel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmi_Panel.Size = new System.Drawing.Size(222, 22);
            this.tsmi_Panel.Text = "Detail Panel";
            this.tsmi_Panel.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            // 
            // tsmb_WrapMode
            // 
            this.tsmb_WrapMode.CheckOnClick = true;
            this.tsmb_WrapMode.Name = "tsmb_WrapMode";
            this.tsmb_WrapMode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmb_WrapMode.Size = new System.Drawing.Size(222, 22);
            this.tsmb_WrapMode.Text = "Wrap Mode";
            this.tsmb_WrapMode.CheckedChanged += new System.EventHandler(this.tsmb_WrapMode_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // cb_Transparent
            // 
            this.cb_Transparent.Checked = true;
            this.cb_Transparent.CheckOnClick = true;
            this.cb_Transparent.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cb_Transparent.Name = "cb_Transparent";
            this.cb_Transparent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.cb_Transparent.Size = new System.Drawing.Size(222, 22);
            this.cb_Transparent.Text = "Transparent";
            this.cb_Transparent.CheckedChanged += new System.EventHandler(this.cb_Transparent_CheckedChanged);
            // 
            // cb_BackLight
            // 
            this.cb_BackLight.Checked = true;
            this.cb_BackLight.CheckOnClick = true;
            this.cb_BackLight.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cb_BackLight.Name = "cb_BackLight";
            this.cb_BackLight.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.cb_BackLight.Size = new System.Drawing.Size(222, 22);
            this.cb_BackLight.Text = "Back Light";
            this.cb_BackLight.CheckedChanged += new System.EventHandler(this.cb_BackLight_CheckedChanged);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.classicToolStripMenuItem,
            this.toolStripSeparator6,
            this.l_BackColor,
            this.l_ForeColor});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // classicToolStripMenuItem
            // 
            this.classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            this.classicToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.classicToolStripMenuItem.Text = "Classic";
            this.classicToolStripMenuItem.Click += new System.EventHandler(this.classicToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(201, 6);
            // 
            // l_BackColor
            // 
            this.l_BackColor.Name = "l_BackColor";
            this.l_BackColor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.l_BackColor.Size = new System.Drawing.Size(204, 22);
            this.l_BackColor.Text = "Back Color";
            this.l_BackColor.BackColorChanged += new System.EventHandler(this.toolStripMenuItem3_BackColorChanged);
            this.l_BackColor.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // l_ForeColor
            // 
            this.l_ForeColor.Name = "l_ForeColor";
            this.l_ForeColor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.l_ForeColor.Size = new System.Drawing.Size(204, 22);
            this.l_ForeColor.Text = "Fore Color";
            this.l_ForeColor.Click += new System.EventHandler(this.l_ForeColor_Click);
            this.l_ForeColor.ForeColorChanged += new System.EventHandler(this.l_ForeColor_ForeColorChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.p_List, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p_Main, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 326);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // p_List
            // 
            this.p_List.BackgroundImage = global::MiMFa_MockMeeting.Properties.Resources.Dark1;
            this.p_List.Controls.Add(this.dgv_Titles);
            this.p_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_List.Location = new System.Drawing.Point(3, 3);
            this.p_List.Name = "p_List";
            this.p_List.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.p_List.Size = new System.Drawing.Size(196, 320);
            this.p_List.TabIndex = 0;
            // 
            // dgv_Titles
            // 
            this.dgv_Titles.AllowUserToDeleteRows = false;
            this.dgv_Titles.AllowUserToResizeColumns = false;
            this.dgv_Titles.AllowUserToResizeRows = false;
            this.dgv_Titles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Titles.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Titles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Titles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Titles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Titles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Titles.ColumnHeadersVisible = false;
            this.dgv_Titles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Titles_ID,
            this.dgv_Titles_Title,
            this.dgv_Titles_SK});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Titles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Titles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Titles.Location = new System.Drawing.Point(0, 0);
            this.dgv_Titles.MultiSelect = false;
            this.dgv_Titles.Name = "dgv_Titles";
            this.dgv_Titles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Titles.RowHeadersVisible = false;
            this.dgv_Titles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Titles.Size = new System.Drawing.Size(191, 320);
            this.dgv_Titles.TabIndex = 0;
            this.dgv_Titles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Titles_CellValueChanged);
            this.dgv_Titles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_Titles_RowsAdded);
            this.dgv_Titles.SelectionChanged += new System.EventHandler(this.dgv_Titles_SelectionChanged);
            this.dgv_Titles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            // 
            // dgv_Titles_ID
            // 
            this.dgv_Titles_ID.HeaderText = "ID";
            this.dgv_Titles_ID.Name = "dgv_Titles_ID";
            this.dgv_Titles_ID.Visible = false;
            // 
            // dgv_Titles_Title
            // 
            this.dgv_Titles_Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Titles_Title.HeaderText = "TITLE";
            this.dgv_Titles_Title.Name = "dgv_Titles_Title";
            // 
            // dgv_Titles_SK
            // 
            this.dgv_Titles_SK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_Titles_SK.DisplayStyleForCurrentCellOnly = true;
            this.dgv_Titles_SK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgv_Titles_SK.HeaderText = "KEY";
            this.dgv_Titles_SK.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-",
            "+",
            "/",
            "*",
            "\\",
            "[",
            "]",
            ";",
            "\'",
            ",",
            "/",
            "`"});
            this.dgv_Titles_SK.MaxDropDownItems = 10;
            this.dgv_Titles_SK.Name = "dgv_Titles_SK";
            this.dgv_Titles_SK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Titles_SK.Width = 38;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 386);
            this.ContextMenuStrip = this.CMS;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.l_Message);
            this.Controls.Add(this.tlp_Menu);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "MiMFa Mock Meeting";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            this.p_Main.ResumeLayout(false);
            this.p_Main.PerformLayout();
            this.CMS.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.p_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Titles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Main;
        private System.Windows.Forms.RichTextBox rtb_Main;
        private System.Windows.Forms.Panel p_List;
        private System.Windows.Forms.DataGridView dgv_Titles;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Label l_Message;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp_Menu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cd_ColorDialog;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsm;
        private System.Windows.Forms.ToolStripMenuItem cb_Transparent;
        private System.Windows.Forms.ToolStripMenuItem cb_BackLight;
        private System.Windows.Forms.ToolStripMenuItem titleBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Panel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_TopM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Titles_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Titles_Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_Titles_SK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmb__MenuBar;
        private System.Windows.Forms.ToolStripMenuItem tsmb_EditMode;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem l_BackColor;
        private System.Windows.Forms.ToolStripMenuItem l_ForeColor;
        private System.Windows.Forms.ToolStripMenuItem classicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmb_WrapMode;
    }
}

