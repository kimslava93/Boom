namespace Boom_Manager_Project
{
    partial class TimeZoneManager
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
            this.sContainer = new System.Windows.Forms.SplitContainer();
            this.bDeleteTimezone = new System.Windows.Forms.Button();
            this.dgvAllTimezones = new System.Windows.Forms.DataGridView();
            this.bExit = new System.Windows.Forms.Button();
            this.gbPriceList = new System.Windows.Forms.GroupBox();
            this.dgvTimeZonePrices = new System.Windows.Forms.DataGridView();
            this.bChangePrices = new System.Windows.Forms.Button();
            this.cbAllTimeZones = new System.Windows.Forms.ComboBox();
            this.lTimeZoneNames = new System.Windows.Forms.Label();
            this.gbTimezoneCreator = new System.Windows.Forms.GroupBox();
            this.bAddTimezone = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.tbTimezoneName = new System.Windows.Forms.TextBox();
            this.lEndTime = new System.Windows.Forms.Label();
            this.lStartTime = new System.Windows.Forms.Label();
            this.lTimezoneName = new System.Windows.Forms.Label();
            this.bCreateNewTimeZone = new System.Windows.Forms.Button();
            this.bExitCreatingMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).BeginInit();
            this.sContainer.Panel1.SuspendLayout();
            this.sContainer.Panel2.SuspendLayout();
            this.sContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTimezones)).BeginInit();
            this.gbPriceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeZonePrices)).BeginInit();
            this.gbTimezoneCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sContainer
            // 
            this.sContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainer.Location = new System.Drawing.Point(0, 0);
            this.sContainer.Name = "sContainer";
            this.sContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sContainer.Panel1
            // 
            this.sContainer.Panel1.Controls.Add(this.bExit);
            this.sContainer.Panel1.Controls.Add(this.bCreateNewTimeZone);
            this.sContainer.Panel1.Controls.Add(this.bDeleteTimezone);
            this.sContainer.Panel1.Controls.Add(this.dgvAllTimezones);
            this.sContainer.Panel1MinSize = 244;
            // 
            // sContainer.Panel2
            // 
            this.sContainer.Panel2.Controls.Add(this.bExitCreatingMode);
            this.sContainer.Panel2.Controls.Add(this.gbPriceList);
            this.sContainer.Panel2.Controls.Add(this.gbTimezoneCreator);
            this.sContainer.Panel2MinSize = 0;
            this.sContainer.Size = new System.Drawing.Size(688, 246);
            this.sContainer.SplitterDistance = 244;
            this.sContainer.TabIndex = 0;
            // 
            // bDeleteTimezone
            // 
            this.bDeleteTimezone.Location = new System.Drawing.Point(111, 206);
            this.bDeleteTimezone.Name = "bDeleteTimezone";
            this.bDeleteTimezone.Size = new System.Drawing.Size(75, 34);
            this.bDeleteTimezone.TabIndex = 1;
            this.bDeleteTimezone.Text = "Delete";
            this.bDeleteTimezone.UseVisualStyleBackColor = true;
            this.bDeleteTimezone.Click += new System.EventHandler(this.bDeleteTimezone_Click);
            // 
            // dgvAllTimezones
            // 
            this.dgvAllTimezones.AllowUserToAddRows = false;
            this.dgvAllTimezones.AllowUserToDeleteRows = false;
            this.dgvAllTimezones.AllowUserToResizeColumns = false;
            this.dgvAllTimezones.AllowUserToResizeRows = false;
            this.dgvAllTimezones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTimezones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAllTimezones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTimezones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllTimezones.EnableHeadersVisualStyles = false;
            this.dgvAllTimezones.Location = new System.Drawing.Point(0, 0);
            this.dgvAllTimezones.MultiSelect = false;
            this.dgvAllTimezones.Name = "dgvAllTimezones";
            this.dgvAllTimezones.ReadOnly = true;
            this.dgvAllTimezones.RowHeadersVisible = false;
            this.dgvAllTimezones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllTimezones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTimezones.ShowCellErrors = false;
            this.dgvAllTimezones.ShowCellToolTips = false;
            this.dgvAllTimezones.ShowEditingIcon = false;
            this.dgvAllTimezones.ShowRowErrors = false;
            this.dgvAllTimezones.Size = new System.Drawing.Size(686, 191);
            this.dgvAllTimezones.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(608, 202);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 38);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // gbPriceList
            // 
            this.gbPriceList.Controls.Add(this.dgvTimeZonePrices);
            this.gbPriceList.Controls.Add(this.bChangePrices);
            this.gbPriceList.Controls.Add(this.cbAllTimeZones);
            this.gbPriceList.Controls.Add(this.lTimeZoneNames);
            this.gbPriceList.Location = new System.Drawing.Point(310, 3);
            this.gbPriceList.Name = "gbPriceList";
            this.gbPriceList.Size = new System.Drawing.Size(365, 222);
            this.gbPriceList.TabIndex = 1;
            this.gbPriceList.TabStop = false;
            this.gbPriceList.Text = "Playstation price list";
            // 
            // dgvTimeZonePrices
            // 
            this.dgvTimeZonePrices.AllowUserToAddRows = false;
            this.dgvTimeZonePrices.AllowUserToDeleteRows = false;
            this.dgvTimeZonePrices.AllowUserToResizeColumns = false;
            this.dgvTimeZonePrices.AllowUserToResizeRows = false;
            this.dgvTimeZonePrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeZonePrices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTimeZonePrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeZonePrices.ColumnHeadersVisible = false;
            this.dgvTimeZonePrices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimeZonePrices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTimeZonePrices.EnableHeadersVisualStyles = false;
            this.dgvTimeZonePrices.Location = new System.Drawing.Point(3, 73);
            this.dgvTimeZonePrices.Name = "dgvTimeZonePrices";
            this.dgvTimeZonePrices.ReadOnly = true;
            this.dgvTimeZonePrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeZonePrices.ShowCellErrors = false;
            this.dgvTimeZonePrices.ShowCellToolTips = false;
            this.dgvTimeZonePrices.ShowEditingIcon = false;
            this.dgvTimeZonePrices.ShowRowErrors = false;
            this.dgvTimeZonePrices.Size = new System.Drawing.Size(359, 146);
            this.dgvTimeZonePrices.TabIndex = 3;
            // 
            // bChangePrices
            // 
            this.bChangePrices.Location = new System.Drawing.Point(282, 20);
            this.bChangePrices.Name = "bChangePrices";
            this.bChangePrices.Size = new System.Drawing.Size(77, 51);
            this.bChangePrices.TabIndex = 2;
            this.bChangePrices.Text = "Change prices";
            this.bChangePrices.UseVisualStyleBackColor = true;
            this.bChangePrices.Click += new System.EventHandler(this.bChangePrices_Click);
            // 
            // cbAllTimeZones
            // 
            this.cbAllTimeZones.FormattingEnabled = true;
            this.cbAllTimeZones.Location = new System.Drawing.Point(133, 33);
            this.cbAllTimeZones.Name = "cbAllTimeZones";
            this.cbAllTimeZones.Size = new System.Drawing.Size(121, 29);
            this.cbAllTimeZones.TabIndex = 1;
            this.cbAllTimeZones.SelectedIndexChanged += new System.EventHandler(this.cbAllTimeZones_SelectedIndexChanged);
            this.cbAllTimeZones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbAllTimeZones_MouseClick);
            // 
            // lTimeZoneNames
            // 
            this.lTimeZoneNames.AutoSize = true;
            this.lTimeZoneNames.Location = new System.Drawing.Point(6, 36);
            this.lTimeZoneNames.Name = "lTimeZoneNames";
            this.lTimeZoneNames.Size = new System.Drawing.Size(121, 21);
            this.lTimeZoneNames.TabIndex = 0;
            this.lTimeZoneNames.Text = "Time zone name";
            // 
            // gbTimezoneCreator
            // 
            this.gbTimezoneCreator.Controls.Add(this.bAddTimezone);
            this.gbTimezoneCreator.Controls.Add(this.dtpEndTime);
            this.gbTimezoneCreator.Controls.Add(this.dtpStartTime);
            this.gbTimezoneCreator.Controls.Add(this.tbTimezoneName);
            this.gbTimezoneCreator.Controls.Add(this.lEndTime);
            this.gbTimezoneCreator.Controls.Add(this.lStartTime);
            this.gbTimezoneCreator.Controls.Add(this.lTimezoneName);
            this.gbTimezoneCreator.Location = new System.Drawing.Point(11, 3);
            this.gbTimezoneCreator.Name = "gbTimezoneCreator";
            this.gbTimezoneCreator.Size = new System.Drawing.Size(293, 222);
            this.gbTimezoneCreator.TabIndex = 0;
            this.gbTimezoneCreator.TabStop = false;
            this.gbTimezoneCreator.Text = "Time zone creator";
            // 
            // bAddTimezone
            // 
            this.bAddTimezone.Location = new System.Drawing.Point(114, 186);
            this.bAddTimezone.Name = "bAddTimezone";
            this.bAddTimezone.Size = new System.Drawing.Size(75, 30);
            this.bAddTimezone.TabIndex = 4;
            this.bAddTimezone.Text = "Add";
            this.bAddTimezone.UseVisualStyleBackColor = true;
            this.bAddTimezone.Click += new System.EventHandler(this.bAddTimezone_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:00";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(114, 102);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(106, 29);
            this.dtpEndTime.TabIndex = 3;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:00";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(114, 67);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(106, 29);
            this.dtpStartTime.TabIndex = 3;
            // 
            // tbTimezoneName
            // 
            this.tbTimezoneName.Location = new System.Drawing.Point(114, 32);
            this.tbTimezoneName.Name = "tbTimezoneName";
            this.tbTimezoneName.Size = new System.Drawing.Size(173, 29);
            this.tbTimezoneName.TabIndex = 2;
            // 
            // lEndTime
            // 
            this.lEndTime.AutoSize = true;
            this.lEndTime.Location = new System.Drawing.Point(12, 108);
            this.lEndTime.Name = "lEndTime";
            this.lEndTime.Size = new System.Drawing.Size(69, 21);
            this.lEndTime.TabIndex = 1;
            this.lEndTime.Text = "End time";
            // 
            // lStartTime
            // 
            this.lStartTime.AutoSize = true;
            this.lStartTime.Location = new System.Drawing.Point(12, 73);
            this.lStartTime.Name = "lStartTime";
            this.lStartTime.Size = new System.Drawing.Size(74, 21);
            this.lStartTime.TabIndex = 1;
            this.lStartTime.Text = "Start time";
            // 
            // lTimezoneName
            // 
            this.lTimezoneName.AutoSize = true;
            this.lTimezoneName.Location = new System.Drawing.Point(12, 35);
            this.lTimezoneName.Name = "lTimezoneName";
            this.lTimezoneName.Size = new System.Drawing.Size(50, 21);
            this.lTimezoneName.TabIndex = 0;
            this.lTimezoneName.Text = "Name";
            // 
            // bCreateNewTimeZone
            // 
            this.bCreateNewTimeZone.Location = new System.Drawing.Point(11, 206);
            this.bCreateNewTimeZone.Name = "bCreateNewTimeZone";
            this.bCreateNewTimeZone.Size = new System.Drawing.Size(75, 34);
            this.bCreateNewTimeZone.TabIndex = 2;
            this.bCreateNewTimeZone.Text = "Create";
            this.bCreateNewTimeZone.UseVisualStyleBackColor = true;
            this.bCreateNewTimeZone.Click += new System.EventHandler(this.bCreateNewTimeZone_Click);
            // 
            // bExitCreatingMode
            // 
            this.bExitCreatingMode.Location = new System.Drawing.Point(310, 231);
            this.bExitCreatingMode.Name = "bExitCreatingMode";
            this.bExitCreatingMode.Size = new System.Drawing.Size(75, 38);
            this.bExitCreatingMode.TabIndex = 3;
            this.bExitCreatingMode.Text = "Apply";
            this.bExitCreatingMode.UseVisualStyleBackColor = true;
            this.bExitCreatingMode.Click += new System.EventHandler(this.bExitCreatingMode_Click);
            // 
            // TimeZoneManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(688, 246);
            this.ControlBox = false;
            this.Controls.Add(this.sContainer);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeZoneManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeZoneManager";
            this.Load += new System.EventHandler(this.TimeZoneManager_Load);
            this.sContainer.Panel1.ResumeLayout(false);
            this.sContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).EndInit();
            this.sContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTimezones)).EndInit();
            this.gbPriceList.ResumeLayout(false);
            this.gbPriceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeZonePrices)).EndInit();
            this.gbTimezoneCreator.ResumeLayout(false);
            this.gbTimezoneCreator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sContainer;
        private System.Windows.Forms.Button bDeleteTimezone;
        private System.Windows.Forms.DataGridView dgvAllTimezones;
        private System.Windows.Forms.GroupBox gbPriceList;
        private System.Windows.Forms.GroupBox gbTimezoneCreator;
        private System.Windows.Forms.TextBox tbTimezoneName;
        private System.Windows.Forms.Label lEndTime;
        private System.Windows.Forms.Label lStartTime;
        private System.Windows.Forms.Label lTimezoneName;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Button bAddTimezone;
        private System.Windows.Forms.DataGridView dgvTimeZonePrices;
        private System.Windows.Forms.Button bChangePrices;
        private System.Windows.Forms.ComboBox cbAllTimeZones;
        private System.Windows.Forms.Label lTimeZoneNames;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bCreateNewTimeZone;
        private System.Windows.Forms.Button bExitCreatingMode;
    }
}