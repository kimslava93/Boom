namespace Boom_Manager_Project
{
    partial class BoomMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoomMainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.bChangeShift = new System.Windows.Forms.Button();
            this.bExtendTime = new System.Windows.Forms.Button();
            this.bCloseSession = new System.Windows.Forms.Button();
            this.bAddNewClient = new System.Windows.Forms.Button();
            this.bSlideMenu = new System.Windows.Forms.Button();
            this.lCurrentDate = new System.Windows.Forms.Label();
            this.lCurrentTime = new System.Windows.Forms.Label();
            this.dgvOpenedSessions = new System.Windows.Forms.DataGridView();
            this.gbManageGroup = new System.Windows.Forms.GroupBox();
            this.bDevicesManager = new System.Windows.Forms.Button();
            this.bAllGlobalSessions = new System.Windows.Forms.Button();
            this.bConsoleManager = new System.Windows.Forms.Button();
            this.bTimezoneManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenedSessions)).BeginInit();
            this.gbManageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.splitContainer.Panel1.Controls.Add(this.bChangeShift);
            this.splitContainer.Panel1.Controls.Add(this.bExtendTime);
            this.splitContainer.Panel1.Controls.Add(this.bCloseSession);
            this.splitContainer.Panel1.Controls.Add(this.bAddNewClient);
            this.splitContainer.Panel1.Controls.Add(this.bSlideMenu);
            this.splitContainer.Panel1.Controls.Add(this.lCurrentDate);
            this.splitContainer.Panel1.Controls.Add(this.lCurrentTime);
            this.splitContainer.Panel1.Controls.Add(this.dgvOpenedSessions);
            this.splitContainer.Panel1MinSize = 1250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.splitContainer.Panel2.Controls.Add(this.gbManageGroup);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(1366, 768);
            this.splitContainer.SplitterDistance = 1250;
            this.splitContainer.TabIndex = 3;
            // 
            // bChangeShift
            // 
            this.bChangeShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bChangeShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bChangeShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bChangeShift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bChangeShift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bChangeShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bChangeShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangeShift.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChangeShift.ForeColor = System.Drawing.Color.White;
            this.bChangeShift.Location = new System.Drawing.Point(714, 25);
            this.bChangeShift.Margin = new System.Windows.Forms.Padding(5);
            this.bChangeShift.Name = "bChangeShift";
            this.bChangeShift.Size = new System.Drawing.Size(124, 38);
            this.bChangeShift.TabIndex = 1001;
            this.bChangeShift.Text = "CHANGE SHIFT";
            this.bChangeShift.UseVisualStyleBackColor = false;
            this.bChangeShift.Click += new System.EventHandler(this.bChangeShift_Click);
            this.bChangeShift.MouseLeave += new System.EventHandler(this.bChangeShift_MouseLeave);
            this.bChangeShift.MouseHover += new System.EventHandler(this.bChangeShift_MouseHover);
            // 
            // bExtendTime
            // 
            this.bExtendTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExtendTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExtendTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExtendTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bExtendTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExtendTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExtendTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExtendTime.ForeColor = System.Drawing.Color.White;
            this.bExtendTime.Location = new System.Drawing.Point(147, 25);
            this.bExtendTime.Margin = new System.Windows.Forms.Padding(5);
            this.bExtendTime.Name = "bExtendTime";
            this.bExtendTime.Size = new System.Drawing.Size(124, 38);
            this.bExtendTime.TabIndex = 1000;
            this.bExtendTime.Text = "EXTEND TIME";
            this.bExtendTime.UseVisualStyleBackColor = false;
            this.bExtendTime.Click += new System.EventHandler(this.bExtendTime_Click);
            this.bExtendTime.MouseLeave += new System.EventHandler(this.bExtendTime_MouseLeave);
            this.bExtendTime.MouseHover += new System.EventHandler(this.bExtendTime_MouseHover);
            // 
            // bCloseSession
            // 
            this.bCloseSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCloseSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCloseSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCloseSession.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCloseSession.ForeColor = System.Drawing.Color.White;
            this.bCloseSession.Location = new System.Drawing.Point(284, 25);
            this.bCloseSession.Margin = new System.Windows.Forms.Padding(5);
            this.bCloseSession.Name = "bCloseSession";
            this.bCloseSession.Size = new System.Drawing.Size(123, 38);
            this.bCloseSession.TabIndex = 8;
            this.bCloseSession.Text = "CLOSE SESSION";
            this.bCloseSession.UseVisualStyleBackColor = false;
            this.bCloseSession.Click += new System.EventHandler(this.bCloseSession_Click);
            this.bCloseSession.MouseLeave += new System.EventHandler(this.bCloseSession_MouseLeave);
            this.bCloseSession.MouseHover += new System.EventHandler(this.bCloseSession_MouseHover);
            // 
            // bAddNewClient
            // 
            this.bAddNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddNewClient.ForeColor = System.Drawing.Color.White;
            this.bAddNewClient.Location = new System.Drawing.Point(13, 25);
            this.bAddNewClient.Margin = new System.Windows.Forms.Padding(5);
            this.bAddNewClient.Name = "bAddNewClient";
            this.bAddNewClient.Size = new System.Drawing.Size(124, 38);
            this.bAddNewClient.TabIndex = 7;
            this.bAddNewClient.Text = "OPEN SESSION";
            this.bAddNewClient.UseVisualStyleBackColor = false;
            this.bAddNewClient.Click += new System.EventHandler(this.bAddNewSession_Click);
            this.bAddNewClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bAddNewClient_MouseDown);
            this.bAddNewClient.MouseLeave += new System.EventHandler(this.bAddNewClient_MouseLeave);
            this.bAddNewClient.MouseHover += new System.EventHandler(this.bAddNewClient_MouseHover);
            // 
            // bSlideMenu
            // 
            this.bSlideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSlideMenu.FlatAppearance.BorderSize = 0;
            this.bSlideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSlideMenu.Location = new System.Drawing.Point(1238, 0);
            this.bSlideMenu.Name = "bSlideMenu";
            this.bSlideMenu.Size = new System.Drawing.Size(10, 36);
            this.bSlideMenu.TabIndex = 999;
            this.bSlideMenu.TabStop = false;
            this.bSlideMenu.Text = "<";
            this.bSlideMenu.UseVisualStyleBackColor = true;
            this.bSlideMenu.Click += new System.EventHandler(this.bSlideMenu_Click);
            // 
            // lCurrentDate
            // 
            this.lCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentDate.AutoSize = true;
            this.lCurrentDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lCurrentDate.Location = new System.Drawing.Point(480, 78);
            this.lCurrentDate.Name = "lCurrentDate";
            this.lCurrentDate.Size = new System.Drawing.Size(92, 30);
            this.lCurrentDate.TabIndex = 5;
            this.lCurrentDate.Text = "CurDate";
            this.lCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lCurrentTime
            // 
            this.lCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentTime.AutoSize = true;
            this.lCurrentTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lCurrentTime.Location = new System.Drawing.Point(415, 3);
            this.lCurrentTime.Name = "lCurrentTime";
            this.lCurrentTime.Size = new System.Drawing.Size(291, 86);
            this.lCurrentTime.TabIndex = 4;
            this.lCurrentTime.Text = "CurTime";
            this.lCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvOpenedSessions
            // 
            this.dgvOpenedSessions.AllowUserToAddRows = false;
            this.dgvOpenedSessions.AllowUserToDeleteRows = false;
            this.dgvOpenedSessions.AllowUserToResizeColumns = false;
            this.dgvOpenedSessions.AllowUserToResizeRows = false;
            this.dgvOpenedSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenedSessions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvOpenedSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOpenedSessions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOpenedSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpenedSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpenedSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenedSessions.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOpenedSessions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOpenedSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOpenedSessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOpenedSessions.EnableHeadersVisualStyles = false;
            this.dgvOpenedSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvOpenedSessions.Location = new System.Drawing.Point(0, 111);
            this.dgvOpenedSessions.MultiSelect = false;
            this.dgvOpenedSessions.Name = "dgvOpenedSessions";
            this.dgvOpenedSessions.ReadOnly = true;
            this.dgvOpenedSessions.RowHeadersVisible = false;
            this.dgvOpenedSessions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOpenedSessions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOpenedSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpenedSessions.Size = new System.Drawing.Size(1248, 655);
            this.dgvOpenedSessions.TabIndex = 3;
            this.dgvOpenedSessions.TabStop = false;
            this.dgvOpenedSessions.VirtualMode = true;
            this.dgvOpenedSessions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOpenedSessions_CellFormatting);
            // 
            // gbManageGroup
            // 
            this.gbManageGroup.Controls.Add(this.bDevicesManager);
            this.gbManageGroup.Controls.Add(this.bAllGlobalSessions);
            this.gbManageGroup.Controls.Add(this.bConsoleManager);
            this.gbManageGroup.Controls.Add(this.bTimezoneManager);
            this.gbManageGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbManageGroup.Location = new System.Drawing.Point(0, 0);
            this.gbManageGroup.Name = "gbManageGroup";
            this.gbManageGroup.Size = new System.Drawing.Size(110, 766);
            this.gbManageGroup.TabIndex = 4;
            this.gbManageGroup.TabStop = false;
            this.gbManageGroup.Text = "Manage";
            // 
            // bDevicesManager
            // 
            this.bDevicesManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDevicesManager.BackgroundImage")));
            this.bDevicesManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDevicesManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bDevicesManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDevicesManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDevicesManager.ForeColor = System.Drawing.Color.White;
            this.bDevicesManager.Location = new System.Drawing.Point(3, 133);
            this.bDevicesManager.Name = "bDevicesManager";
            this.bDevicesManager.Size = new System.Drawing.Size(104, 33);
            this.bDevicesManager.TabIndex = 7;
            this.bDevicesManager.Text = "Devices";
            this.bDevicesManager.UseVisualStyleBackColor = true;
            this.bDevicesManager.Click += new System.EventHandler(this.bDevicesManager_Click_1);
            // 
            // bAllGlobalSessions
            // 
            this.bAllGlobalSessions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAllGlobalSessions.BackgroundImage")));
            this.bAllGlobalSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAllGlobalSessions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAllGlobalSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAllGlobalSessions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAllGlobalSessions.ForeColor = System.Drawing.Color.White;
            this.bAllGlobalSessions.Location = new System.Drawing.Point(3, 97);
            this.bAllGlobalSessions.Name = "bAllGlobalSessions";
            this.bAllGlobalSessions.Size = new System.Drawing.Size(104, 36);
            this.bAllGlobalSessions.TabIndex = 6;
            this.bAllGlobalSessions.Text = "Shifts";
            this.bAllGlobalSessions.UseVisualStyleBackColor = true;
            this.bAllGlobalSessions.Click += new System.EventHandler(this.bAllGlobalSessions_Click_1);
            // 
            // bConsoleManager
            // 
            this.bConsoleManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bConsoleManager.BackgroundImage")));
            this.bConsoleManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsoleManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bConsoleManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsoleManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bConsoleManager.ForeColor = System.Drawing.Color.White;
            this.bConsoleManager.Location = new System.Drawing.Point(3, 61);
            this.bConsoleManager.Name = "bConsoleManager";
            this.bConsoleManager.Size = new System.Drawing.Size(104, 36);
            this.bConsoleManager.TabIndex = 5;
            this.bConsoleManager.Text = "Console";
            this.bConsoleManager.UseVisualStyleBackColor = true;
            this.bConsoleManager.Click += new System.EventHandler(this.bConsoleManager_Click_1);
            // 
            // bTimezoneManager
            // 
            this.bTimezoneManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTimezoneManager.BackgroundImage")));
            this.bTimezoneManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTimezoneManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bTimezoneManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTimezoneManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTimezoneManager.ForeColor = System.Drawing.Color.White;
            this.bTimezoneManager.Location = new System.Drawing.Point(3, 25);
            this.bTimezoneManager.Name = "bTimezoneManager";
            this.bTimezoneManager.Size = new System.Drawing.Size(104, 36);
            this.bTimezoneManager.TabIndex = 4;
            this.bTimezoneManager.Text = "Timezone";
            this.bTimezoneManager.UseVisualStyleBackColor = true;
            this.bTimezoneManager.Click += new System.EventHandler(this.bTimezoneManager_Click_1);
            // 
            // BoomMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoomMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boom Gamebar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoomMainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoomMainForm_FormClosed);
            this.Load += new System.EventHandler(this.BoomMainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoomMainForm_KeyPress);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenedSessions)).EndInit();
            this.gbManageGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lCurrentDate;
        private System.Windows.Forms.Label lCurrentTime;
        private System.Windows.Forms.DataGridView dgvOpenedSessions;
        private System.Windows.Forms.Button bSlideMenu;
        private System.Windows.Forms.Button bAddNewClient;
        private System.Windows.Forms.Button bCloseSession;
        private System.Windows.Forms.Button bExtendTime;
        private System.Windows.Forms.Button bChangeShift;
        private System.Windows.Forms.GroupBox gbManageGroup;
        private System.Windows.Forms.Button bDevicesManager;
        private System.Windows.Forms.Button bAllGlobalSessions;
        private System.Windows.Forms.Button bConsoleManager;
        private System.Windows.Forms.Button bTimezoneManager;
    }
}

