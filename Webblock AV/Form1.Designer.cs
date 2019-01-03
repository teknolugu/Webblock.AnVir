using System.Drawing;
namespace Webblock_AV
{

    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("This PC");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTabFullScan = new MyComponents.HButton();
            this.BtnTabQuickScan = new MyComponents.HButton();
            this.BtnTabSelective = new MyComponents.HButton();
            this.BtnDashBoard = new MyComponents.HButton();
            this.BtnUpdates = new MyComponents.HButton();
            this.BtnAbout = new MyComponents.HButton();
            this.PanelSelector = new System.Windows.Forms.Panel();
            this.BtnSettings = new MyComponents.HButton();
            this.BtnScanner = new MyComponents.HButton();
            this.BtnProtection = new MyComponents.HButton();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.treePath = new System.Windows.Forms.TreeView();
            this.ShellImageList = new System.Windows.Forms.ImageList(this.components);
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabDashboard = new System.Windows.Forms.TabPage();
            this.TabProtection = new System.Windows.Forms.TabPage();
            this.TabSelective = new System.Windows.Forms.TabPage();
            this.BtnScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TabUpdates = new System.Windows.Forms.TabPage();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.TabScanner = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TabQuickScan = new System.Windows.Forms.TabPage();
            this.TabFullScan = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTotalFiles = new System.Windows.Forms.Label();
            this.LblDetected = new System.Windows.Forms.Label();
            this.LblCurrentScan = new System.Windows.Forms.Label();
            this.PanelSide.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabSelective.SuspendLayout();
            this.TabScanner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(707, 368);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PanelSide.Controls.Add(this.label4);
            this.PanelSide.Controls.Add(this.BtnTabFullScan);
            this.PanelSide.Controls.Add(this.BtnTabQuickScan);
            this.PanelSide.Controls.Add(this.BtnTabSelective);
            this.PanelSide.Controls.Add(this.BtnDashBoard);
            this.PanelSide.Controls.Add(this.BtnUpdates);
            this.PanelSide.Controls.Add(this.BtnAbout);
            this.PanelSide.Controls.Add(this.PanelSelector);
            this.PanelSide.Controls.Add(this.BtnSettings);
            this.PanelSide.Controls.Add(this.BtnScanner);
            this.PanelSide.Controls.Add(this.BtnProtection);
            this.PanelSide.Controls.Add(this.shapeContainer2);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSide.Location = new System.Drawing.Point(0, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(262, 609);
            this.PanelSide.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Webblock AnVir";
            // 
            // BtnTabFullScan
            // 
            this.BtnTabFullScan.BackColor = System.Drawing.Color.Transparent;
            this.BtnTabFullScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTabFullScan.FlatAppearance.BorderSize = 0;
            this.BtnTabFullScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabFullScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabFullScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabFullScan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabFullScan.ForeColor = System.Drawing.Color.White;
            this.BtnTabFullScan.Image = global::Webblock_AV.Properties.Resources.baseline_search_white_24dp;
            this.BtnTabFullScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabFullScan.Location = new System.Drawing.Point(3, 240);
            this.BtnTabFullScan.Name = "BtnTabFullScan";
            this.BtnTabFullScan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnTabFullScan.Size = new System.Drawing.Size(259, 44);
            this.BtnTabFullScan.TabIndex = 16;
            this.BtnTabFullScan.Text = "                    Full Scan";
            this.BtnTabFullScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabFullScan.UseVisualStyleBackColor = false;
            this.BtnTabFullScan.Click += new System.EventHandler(this.BtnFullScan_Click);
            // 
            // BtnTabQuickScan
            // 
            this.BtnTabQuickScan.BackColor = System.Drawing.Color.Transparent;
            this.BtnTabQuickScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTabQuickScan.FlatAppearance.BorderSize = 0;
            this.BtnTabQuickScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabQuickScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabQuickScan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabQuickScan.ForeColor = System.Drawing.Color.White;
            this.BtnTabQuickScan.Image = ((System.Drawing.Image)(resources.GetObject("BtnTabQuickScan.Image")));
            this.BtnTabQuickScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabQuickScan.Location = new System.Drawing.Point(3, 290);
            this.BtnTabQuickScan.Name = "BtnTabQuickScan";
            this.BtnTabQuickScan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnTabQuickScan.Size = new System.Drawing.Size(259, 44);
            this.BtnTabQuickScan.TabIndex = 15;
            this.BtnTabQuickScan.Text = "                    Quick Scan";
            this.BtnTabQuickScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabQuickScan.UseVisualStyleBackColor = false;
            this.BtnTabQuickScan.Click += new System.EventHandler(this.BtnTabQuickScan_Click);
            // 
            // BtnTabSelective
            // 
            this.BtnTabSelective.BackColor = System.Drawing.Color.Transparent;
            this.BtnTabSelective.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTabSelective.FlatAppearance.BorderSize = 0;
            this.BtnTabSelective.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabSelective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabSelective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabSelective.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabSelective.ForeColor = System.Drawing.Color.White;
            this.BtnTabSelective.Image = global::Webblock_AV.Properties.Resources.Cursor_hand_white_24px;
            this.BtnTabSelective.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabSelective.Location = new System.Drawing.Point(3, 340);
            this.BtnTabSelective.Name = "BtnTabSelective";
            this.BtnTabSelective.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnTabSelective.Size = new System.Drawing.Size(259, 44);
            this.BtnTabSelective.TabIndex = 13;
            this.BtnTabSelective.Text = "                    Selective Scan";
            this.BtnTabSelective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabSelective.UseVisualStyleBackColor = false;
            this.BtnTabSelective.Click += new System.EventHandler(this.BtnTabSelective_Click);
            // 
            // BtnDashBoard
            // 
            this.BtnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDashBoard.FlatAppearance.BorderSize = 0;
            this.BtnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashBoard.ForeColor = System.Drawing.Color.White;
            this.BtnDashBoard.Image = global::Webblock_AV.Properties.Resources.baseline_home_white_24dp;
            this.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashBoard.Location = new System.Drawing.Point(3, 74);
            this.BtnDashBoard.Name = "BtnDashBoard";
            this.BtnDashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDashBoard.Size = new System.Drawing.Size(259, 50);
            this.BtnDashBoard.TabIndex = 12;
            this.BtnDashBoard.Text = "                    Dashboard";
            this.BtnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashBoard.UseVisualStyleBackColor = false;
            this.BtnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // BtnUpdates
            // 
            this.BtnUpdates.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdates.FlatAppearance.BorderSize = 0;
            this.BtnUpdates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnUpdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdates.ForeColor = System.Drawing.Color.White;
            this.BtnUpdates.Image = global::Webblock_AV.Properties.Resources.baseline_refresh_white_24dp;
            this.BtnUpdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdates.Location = new System.Drawing.Point(3, 391);
            this.BtnUpdates.Name = "BtnUpdates";
            this.BtnUpdates.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnUpdates.Size = new System.Drawing.Size(259, 50);
            this.BtnUpdates.TabIndex = 11;
            this.BtnUpdates.Text = "                    Updates";
            this.BtnUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdates.UseVisualStyleBackColor = false;
            this.BtnUpdates.Click += new System.EventHandler(this.BtnUpdates_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbout.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Image = global::Webblock_AV.Properties.Resources.baseline_help_white_24dp;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Location = new System.Drawing.Point(3, 538);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAbout.Size = new System.Drawing.Size(259, 50);
            this.BtnAbout.TabIndex = 9;
            this.BtnAbout.Text = "                    About";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.UseMnemonic = false;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // PanelSelector
            // 
            this.PanelSelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelSelector.Location = new System.Drawing.Point(0, 74);
            this.PanelSelector.Name = "PanelSelector";
            this.PanelSelector.Size = new System.Drawing.Size(3, 50);
            this.PanelSelector.TabIndex = 7;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Image = global::Webblock_AV.Properties.Resources.baseline_settings_white_24dp;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.Location = new System.Drawing.Point(3, 482);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSettings.Size = new System.Drawing.Size(259, 50);
            this.BtnSettings.TabIndex = 8;
            this.BtnSettings.Text = "                    Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.UseMnemonic = false;
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnScanner
            // 
            this.BtnScanner.BackColor = System.Drawing.Color.Transparent;
            this.BtnScanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnScanner.FlatAppearance.BorderSize = 0;
            this.BtnScanner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnScanner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScanner.ForeColor = System.Drawing.Color.White;
            this.BtnScanner.Image = global::Webblock_AV.Properties.Resources.baseline_search_white_24dp;
            this.BtnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScanner.Location = new System.Drawing.Point(3, 186);
            this.BtnScanner.Name = "BtnScanner";
            this.BtnScanner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnScanner.Size = new System.Drawing.Size(259, 50);
            this.BtnScanner.TabIndex = 7;
            this.BtnScanner.Text = "                    Scanner";
            this.BtnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScanner.UseVisualStyleBackColor = false;
            this.BtnScanner.Click += new System.EventHandler(this.BtnScanner_Click);
            // 
            // BtnProtection
            // 
            this.BtnProtection.BackColor = System.Drawing.Color.Transparent;
            this.BtnProtection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProtection.FlatAppearance.BorderSize = 0;
            this.BtnProtection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnProtection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnProtection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProtection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProtection.ForeColor = System.Drawing.Color.White;
            this.BtnProtection.Image = global::Webblock_AV.Properties.Resources.shield_outline_24px;
            this.BtnProtection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProtection.Location = new System.Drawing.Point(3, 130);
            this.BtnProtection.Name = "BtnProtection";
            this.BtnProtection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnProtection.Size = new System.Drawing.Size(259, 50);
            this.BtnProtection.TabIndex = 5;
            this.BtnProtection.Text = "                    Protection";
            this.BtnProtection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProtection.UseVisualStyleBackColor = false;
            this.BtnProtection.Click += new System.EventHandler(this.BtnProtection_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(262, 609);
            this.shapeContainer2.TabIndex = 10;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 9;
            this.lineShape1.X2 = 244;
            this.lineShape1.Y1 = 465;
            this.lineShape1.Y2 = 465;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treePath
            // 
            this.treePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePath.CheckBoxes = true;
            this.treePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePath.HideSelection = false;
            this.treePath.ImageIndex = 0;
            this.treePath.ImageList = this.ShellImageList;
            this.treePath.Location = new System.Drawing.Point(27, 128);
            this.treePath.Name = "treePath";
            treeNode2.Name = "Node0";
            treeNode2.Text = "This PC";
            this.treePath.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treePath.SelectedImageIndex = 0;
            this.treePath.Size = new System.Drawing.Size(707, 413);
            this.treePath.TabIndex = 0;
            this.treePath.Visible = false;
            this.treePath.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // ShellImageList
            // 
            this.ShellImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ShellImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ShellImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TabMain
            // 
            this.TabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabMain.Controls.Add(this.TabDashboard);
            this.TabMain.Controls.Add(this.TabProtection);
            this.TabMain.Controls.Add(this.TabSelective);
            this.TabMain.Controls.Add(this.TabUpdates);
            this.TabMain.Controls.Add(this.TabSettings);
            this.TabMain.Controls.Add(this.TabAbout);
            this.TabMain.Controls.Add(this.TabScanner);
            this.TabMain.Controls.Add(this.TabQuickScan);
            this.TabMain.Controls.Add(this.TabFullScan);
            this.TabMain.Location = new System.Drawing.Point(229, -13);
            this.TabMain.Multiline = true;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(793, 630);
            this.TabMain.TabIndex = 6;
            // 
            // TabDashboard
            // 
            this.TabDashboard.BackColor = System.Drawing.Color.DimGray;
            this.TabDashboard.Location = new System.Drawing.Point(23, 4);
            this.TabDashboard.Name = "TabDashboard";
            this.TabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TabDashboard.Size = new System.Drawing.Size(766, 622);
            this.TabDashboard.TabIndex = 0;
            this.TabDashboard.Text = "tabPage1";
            // 
            // TabProtection
            // 
            this.TabProtection.Location = new System.Drawing.Point(23, 4);
            this.TabProtection.Name = "TabProtection";
            this.TabProtection.Padding = new System.Windows.Forms.Padding(3);
            this.TabProtection.Size = new System.Drawing.Size(766, 622);
            this.TabProtection.TabIndex = 1;
            this.TabProtection.Text = "tabPage2";
            this.TabProtection.UseVisualStyleBackColor = true;
            // 
            // TabSelective
            // 
            this.TabSelective.BackColor = System.Drawing.Color.DimGray;
            this.TabSelective.Controls.Add(this.button1);
            this.TabSelective.Controls.Add(this.label1);
            this.TabSelective.Controls.Add(this.textBox1);
            this.TabSelective.Controls.Add(this.listBox1);
            this.TabSelective.Controls.Add(this.BtnScan);
            this.TabSelective.Controls.Add(this.label2);
            this.TabSelective.Controls.Add(this.label3);
            this.TabSelective.Controls.Add(this.shapeContainer1);
            this.TabSelective.Controls.Add(this.treePath);
            this.TabSelective.Location = new System.Drawing.Point(23, 4);
            this.TabSelective.Name = "TabSelective";
            this.TabSelective.Size = new System.Drawing.Size(766, 622);
            this.TabSelective.TabIndex = 2;
            this.TabSelective.Text = "TabSelective";
            // 
            // BtnScan
            // 
            this.BtnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnScan.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnScan.FlatAppearance.BorderSize = 0;
            this.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnScan.Image = global::Webblock_AV.Properties.Resources.baseline_play_circle_outline_white_24dp;
            this.BtnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScan.Location = new System.Drawing.Point(29, 571);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(114, 36);
            this.BtnScan.TabIndex = 3;
            this.BtnScan.Text = "  Scan Now!";
            this.BtnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selective Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose what you want to scan";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(766, 622);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 27;
            this.lineShape3.X2 = 732;
            this.lineShape3.Y1 = 90;
            this.lineShape3.Y2 = 90;
            // 
            // TabUpdates
            // 
            this.TabUpdates.Location = new System.Drawing.Point(23, 4);
            this.TabUpdates.Name = "TabUpdates";
            this.TabUpdates.Size = new System.Drawing.Size(766, 622);
            this.TabUpdates.TabIndex = 3;
            this.TabUpdates.Text = "TabUpdates";
            this.TabUpdates.UseVisualStyleBackColor = true;
            // 
            // TabSettings
            // 
            this.TabSettings.Location = new System.Drawing.Point(23, 4);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Size = new System.Drawing.Size(766, 622);
            this.TabSettings.TabIndex = 4;
            this.TabSettings.Text = "tabPage3";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // TabAbout
            // 
            this.TabAbout.Location = new System.Drawing.Point(23, 4);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Size = new System.Drawing.Size(766, 622);
            this.TabAbout.TabIndex = 5;
            this.TabAbout.Text = "tabPage1";
            this.TabAbout.UseVisualStyleBackColor = true;
            // 
            // TabScanner
            // 
            this.TabScanner.BackColor = System.Drawing.Color.DimGray;
            this.TabScanner.Controls.Add(this.LblCurrentScan);
            this.TabScanner.Controls.Add(this.groupBox1);
            this.TabScanner.Controls.Add(this.label5);
            this.TabScanner.Controls.Add(this.progressBar1);
            this.TabScanner.Location = new System.Drawing.Point(23, 4);
            this.TabScanner.Name = "TabScanner";
            this.TabScanner.Size = new System.Drawing.Size(766, 622);
            this.TabScanner.TabIndex = 6;
            this.TabScanner.Text = "tabPage1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(594, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // TabQuickScan
            // 
            this.TabQuickScan.Location = new System.Drawing.Point(23, 4);
            this.TabQuickScan.Name = "TabQuickScan";
            this.TabQuickScan.Size = new System.Drawing.Size(766, 622);
            this.TabQuickScan.TabIndex = 7;
            this.TabQuickScan.Text = "tabPage1";
            this.TabQuickScan.UseVisualStyleBackColor = true;
            // 
            // TabFullScan
            // 
            this.TabFullScan.Location = new System.Drawing.Point(23, 4);
            this.TabFullScan.Name = "TabFullScan";
            this.TabFullScan.Size = new System.Drawing.Size(766, 622);
            this.TabFullScan.TabIndex = 8;
            this.TabFullScan.Text = "tabPage1";
            this.TabFullScan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(81, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Scanning :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDetected);
            this.groupBox1.Controls.Add(this.LblTotalFiles);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(84, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detected :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Files :";
            // 
            // LblTotalFiles
            // 
            this.LblTotalFiles.AutoSize = true;
            this.LblTotalFiles.Location = new System.Drawing.Point(85, 49);
            this.LblTotalFiles.Name = "LblTotalFiles";
            this.LblTotalFiles.Size = new System.Drawing.Size(13, 13);
            this.LblTotalFiles.TabIndex = 2;
            this.LblTotalFiles.Text = "0";
            // 
            // LblDetected
            // 
            this.LblDetected.AutoSize = true;
            this.LblDetected.Location = new System.Drawing.Point(85, 84);
            this.LblDetected.Name = "LblDetected";
            this.LblDetected.Size = new System.Drawing.Size(13, 13);
            this.LblDetected.TabIndex = 3;
            this.LblDetected.Text = "0";
            // 
            // LblCurrentScan
            // 
            this.LblCurrentScan.AutoSize = true;
            this.LblCurrentScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCurrentScan.Location = new System.Drawing.Point(145, 120);
            this.LblCurrentScan.Name = "LblCurrentScan";
            this.LblCurrentScan.Size = new System.Drawing.Size(58, 13);
            this.LblCurrentScan.TabIndex = 3;
            this.LblCurrentScan.Text = "Scanning :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1014, 609);
            this.Controls.Add(this.PanelSide);
            this.Controls.Add(this.TabMain);
            this.MinimumSize = new System.Drawing.Size(1030, 648);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webblock AnVir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.PanelSide.ResumeLayout(false);
            this.PanelSide.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabSelective.ResumeLayout(false);
            this.TabSelective.PerformLayout();
            this.TabScanner.ResumeLayout(false);
            this.TabScanner.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelSide;
        private MyComponents.HButton BtnProtection;
        private MyComponents.HButton BtnScanner;
        private MyComponents.HButton BtnSettings;
        private System.Windows.Forms.Panel PanelSelector;
        private MyComponents.HButton BtnAbout;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MyComponents.HButton BtnDashBoard;
        private MyComponents.HButton BtnUpdates;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabProtection;
        private System.Windows.Forms.TabPage TabDashboard;
        private System.Windows.Forms.TabPage TabSelective;
        private System.Windows.Forms.TabPage TabUpdates;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.TabPage TabAbout;
        private System.Windows.Forms.TreeView treePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ShellImageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button BtnScan;
        private MyComponents.HButton BtnTabSelective;
        private MyComponents.HButton BtnTabFullScan;
        private MyComponents.HButton BtnTabQuickScan;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TabPage TabScanner;
        private System.Windows.Forms.TabPage TabQuickScan;
        private System.Windows.Forms.TabPage TabFullScan;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDetected;
        private System.Windows.Forms.Label LblTotalFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblCurrentScan;
    }
}

