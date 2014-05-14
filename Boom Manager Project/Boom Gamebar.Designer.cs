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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.bExtendTime = new System.Windows.Forms.Button();
            this.bCloseSession = new System.Windows.Forms.Button();
            this.bAddNewClient = new System.Windows.Forms.Button();
            this.bSlideMenu = new System.Windows.Forms.Button();
            this.lCurrentDate = new System.Windows.Forms.Label();
            this.lCurrentTime = new System.Windows.Forms.Label();
            this.dgvOpenedSessions = new System.Windows.Forms.DataGridView();
            this.bTimezoneManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenedSessions)).BeginInit();
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
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
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
            this.splitContainer.Panel2.Controls.Add(this.bTimezoneManager);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(1366, 768);
            this.splitContainer.SplitterDistance = 1250;
            this.splitContainer.TabIndex = 3;
            // 
            // bExtendTime
            // 
            this.bExtendTime.Location = new System.Drawing.Point(228, 40);
            this.bExtendTime.Name = "bExtendTime";
            this.bExtendTime.Size = new System.Drawing.Size(75, 50);
            this.bExtendTime.TabIndex = 1000;
            this.bExtendTime.Text = "Extend time";
            this.bExtendTime.UseVisualStyleBackColor = true;
            this.bExtendTime.Click += new System.EventHandler(this.bExtendTime_Click);
            // 
            // bCloseSession
            // 
            this.bCloseSession.Location = new System.Drawing.Point(128, 40);
            this.bCloseSession.Name = "bCloseSession";
            this.bCloseSession.Size = new System.Drawing.Size(75, 50);
            this.bCloseSession.TabIndex = 8;
            this.bCloseSession.Text = "Close Session";
            this.bCloseSession.UseVisualStyleBackColor = true;
            this.bCloseSession.Click += new System.EventHandler(this.bCloseSession_Click);
            // 
            // bAddNewClient
            // 
            this.bAddNewClient.Location = new System.Drawing.Point(32, 39);
            this.bAddNewClient.Name = "bAddNewClient";
            this.bAddNewClient.Size = new System.Drawing.Size(75, 50);
            this.bAddNewClient.TabIndex = 7;
            this.bAddNewClient.Text = "Open Session";
            this.bAddNewClient.UseVisualStyleBackColor = true;
            this.bAddNewClient.Click += new System.EventHandler(this.bAddNewSession_Click);
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
            this.dgvOpenedSessions.BackgroundColor = System.Drawing.Color.White;
            this.dgvOpenedSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOpenedSessions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOpenedSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenedSessions.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOpenedSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOpenedSessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOpenedSessions.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOpenedSessions.Location = new System.Drawing.Point(0, 115);
            this.dgvOpenedSessions.MultiSelect = false;
            this.dgvOpenedSessions.Name = "dgvOpenedSessions";
            this.dgvOpenedSessions.ReadOnly = true;
            this.dgvOpenedSessions.RowHeadersVisible = false;
            this.dgvOpenedSessions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOpenedSessions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOpenedSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpenedSessions.Size = new System.Drawing.Size(1248, 651);
            this.dgvOpenedSessions.TabIndex = 3;
            this.dgvOpenedSessions.TabStop = false;
            this.dgvOpenedSessions.VirtualMode = true;
            this.dgvOpenedSessions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOpenedSessions_CellFormatting);
            // 
            // bTimezoneManager
            // 
            this.bTimezoneManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTimezoneManager.Location = new System.Drawing.Point(0, 0);
            this.bTimezoneManager.Name = "bTimezoneManager";
            this.bTimezoneManager.Size = new System.Drawing.Size(110, 56);
            this.bTimezoneManager.TabIndex = 0;
            this.bTimezoneManager.Text = "Timezone manager";
            this.bTimezoneManager.UseVisualStyleBackColor = true;
            this.bTimezoneManager.Click += new System.EventHandler(this.bTimezoneManager_Click);
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
        private System.Windows.Forms.Button bTimezoneManager;
    }
}

