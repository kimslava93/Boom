namespace Boom_Manager_Project
{
    partial class ExtendSessionTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lSessionID = new System.Windows.Forms.Label();
            this.tbSessionID = new System.Windows.Forms.TextBox();
            this.gbExtendUsualClient = new System.Windows.Forms.GroupBox();
            this.tbEndTimeWill = new System.Windows.Forms.TextBox();
            this.tbEndTimeWas = new System.Windows.Forms.TextBox();
            this.numUpDMinutesExtend = new System.Windows.Forms.NumericUpDown();
            this.numUpDHoursExtend = new System.Windows.Forms.NumericUpDown();
            this.numUpDMoneyExtend = new System.Windows.Forms.NumericUpDown();
            this.EndTimeWill = new System.Windows.Forms.Label();
            this.lEndTimeWas = new System.Windows.Forms.Label();
            this.lExtend = new System.Windows.Forms.Label();
            this.lMoneyToExtend = new System.Windows.Forms.Label();
            this.gbExtendWithCard = new System.Windows.Forms.GroupBox();
            this.bAddMoney = new System.Windows.Forms.Button();
            this.dgvClientsPerTable = new System.Windows.Forms.DataGridView();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbExtendUsualClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesExtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursExtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMoneyExtend)).BeginInit();
            this.gbExtendWithCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsPerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lSessionID
            // 
            this.lSessionID.AutoSize = true;
            this.lSessionID.Location = new System.Drawing.Point(31, 24);
            this.lSessionID.Name = "lSessionID";
            this.lSessionID.Size = new System.Drawing.Size(78, 21);
            this.lSessionID.TabIndex = 0;
            this.lSessionID.Text = "Session ID";
            // 
            // tbSessionID
            // 
            this.tbSessionID.Location = new System.Drawing.Point(201, 21);
            this.tbSessionID.Name = "tbSessionID";
            this.tbSessionID.ReadOnly = true;
            this.tbSessionID.Size = new System.Drawing.Size(100, 29);
            this.tbSessionID.TabIndex = 1;
            // 
            // gbExtendUsualClient
            // 
            this.gbExtendUsualClient.Controls.Add(this.tbEndTimeWill);
            this.gbExtendUsualClient.Controls.Add(this.tbEndTimeWas);
            this.gbExtendUsualClient.Controls.Add(this.numUpDMinutesExtend);
            this.gbExtendUsualClient.Controls.Add(this.numUpDHoursExtend);
            this.gbExtendUsualClient.Controls.Add(this.numUpDMoneyExtend);
            this.gbExtendUsualClient.Controls.Add(this.EndTimeWill);
            this.gbExtendUsualClient.Controls.Add(this.lEndTimeWas);
            this.gbExtendUsualClient.Controls.Add(this.lExtend);
            this.gbExtendUsualClient.Controls.Add(this.lMoneyToExtend);
            this.gbExtendUsualClient.Location = new System.Drawing.Point(12, 56);
            this.gbExtendUsualClient.Name = "gbExtendUsualClient";
            this.gbExtendUsualClient.Size = new System.Drawing.Size(339, 216);
            this.gbExtendUsualClient.TabIndex = 2;
            this.gbExtendUsualClient.TabStop = false;
            this.gbExtendUsualClient.Text = "Extend usual client time";
            // 
            // tbEndTimeWill
            // 
            this.tbEndTimeWill.Location = new System.Drawing.Point(177, 166);
            this.tbEndTimeWill.Name = "tbEndTimeWill";
            this.tbEndTimeWill.ReadOnly = true;
            this.tbEndTimeWill.Size = new System.Drawing.Size(148, 29);
            this.tbEndTimeWill.TabIndex = 5;
            // 
            // tbEndTimeWas
            // 
            this.tbEndTimeWas.Location = new System.Drawing.Point(177, 131);
            this.tbEndTimeWas.Name = "tbEndTimeWas";
            this.tbEndTimeWas.ReadOnly = true;
            this.tbEndTimeWas.Size = new System.Drawing.Size(148, 29);
            this.tbEndTimeWas.TabIndex = 4;
            // 
            // numUpDMinutesExtend
            // 
            this.numUpDMinutesExtend.Location = new System.Drawing.Point(241, 47);
            this.numUpDMinutesExtend.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDMinutesExtend.Name = "numUpDMinutesExtend";
            this.numUpDMinutesExtend.Size = new System.Drawing.Size(58, 29);
            this.numUpDMinutesExtend.TabIndex = 3;
            this.numUpDMinutesExtend.ValueChanged += new System.EventHandler(this.numUpDMinutesExtend_ValueChanged);
            // 
            // numUpDHoursExtend
            // 
            this.numUpDHoursExtend.Location = new System.Drawing.Point(177, 47);
            this.numUpDHoursExtend.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDHoursExtend.Name = "numUpDHoursExtend";
            this.numUpDHoursExtend.Size = new System.Drawing.Size(58, 29);
            this.numUpDHoursExtend.TabIndex = 2;
            this.numUpDHoursExtend.ValueChanged += new System.EventHandler(this.numUpDHoursExtend_ValueChanged);
            // 
            // numUpDMoneyExtend
            // 
            this.numUpDMoneyExtend.Location = new System.Drawing.Point(177, 82);
            this.numUpDMoneyExtend.Maximum = new decimal(new int[] {
            19400,
            0,
            0,
            0});
            this.numUpDMoneyExtend.Name = "numUpDMoneyExtend";
            this.numUpDMoneyExtend.Size = new System.Drawing.Size(122, 29);
            this.numUpDMoneyExtend.TabIndex = 1;
            this.numUpDMoneyExtend.ValueChanged += new System.EventHandler(this.numUpDMoneyExtend_ValueChanged);
            // 
            // EndTimeWill
            // 
            this.EndTimeWill.AutoSize = true;
            this.EndTimeWill.Location = new System.Drawing.Point(19, 169);
            this.EndTimeWill.Name = "EndTimeWill";
            this.EndTimeWill.Size = new System.Drawing.Size(93, 21);
            this.EndTimeWill.TabIndex = 0;
            this.EndTimeWill.Text = "End time will";
            // 
            // lEndTimeWas
            // 
            this.lEndTimeWas.AutoSize = true;
            this.lEndTimeWas.Location = new System.Drawing.Point(19, 134);
            this.lEndTimeWas.Name = "lEndTimeWas";
            this.lEndTimeWas.Size = new System.Drawing.Size(98, 21);
            this.lEndTimeWas.TabIndex = 0;
            this.lEndTimeWas.Text = "End time was";
            // 
            // lExtend
            // 
            this.lExtend.AutoSize = true;
            this.lExtend.Location = new System.Drawing.Point(19, 49);
            this.lExtend.Name = "lExtend";
            this.lExtend.Size = new System.Drawing.Size(110, 21);
            this.lExtend.TabIndex = 0;
            this.lExtend.Text = "Time to extend";
            // 
            // lMoneyToExtend
            // 
            this.lMoneyToExtend.AutoSize = true;
            this.lMoneyToExtend.Location = new System.Drawing.Point(19, 84);
            this.lMoneyToExtend.Name = "lMoneyToExtend";
            this.lMoneyToExtend.Size = new System.Drawing.Size(124, 21);
            this.lMoneyToExtend.TabIndex = 0;
            this.lMoneyToExtend.Text = "Money to extend";
            // 
            // gbExtendWithCard
            // 
            this.gbExtendWithCard.Controls.Add(this.label1);
            this.gbExtendWithCard.Controls.Add(this.bAddMoney);
            this.gbExtendWithCard.Controls.Add(this.dgvClientsPerTable);
            this.gbExtendWithCard.Location = new System.Drawing.Point(405, 61);
            this.gbExtendWithCard.Name = "gbExtendWithCard";
            this.gbExtendWithCard.Size = new System.Drawing.Size(247, 216);
            this.gbExtendWithCard.TabIndex = 3;
            this.gbExtendWithCard.TabStop = false;
            this.gbExtendWithCard.Text = "Extend client with discount time";
            // 
            // bAddMoney
            // 
            this.bAddMoney.Location = new System.Drawing.Point(119, 166);
            this.bAddMoney.Name = "bAddMoney";
            this.bAddMoney.Size = new System.Drawing.Size(48, 42);
            this.bAddMoney.TabIndex = 1;
            this.bAddMoney.Text = "+";
            this.bAddMoney.UseVisualStyleBackColor = true;
            this.bAddMoney.Click += new System.EventHandler(this.bAddMoney_Click);
            // 
            // dgvClientsPerTable
            // 
            this.dgvClientsPerTable.AllowUserToAddRows = false;
            this.dgvClientsPerTable.AllowUserToDeleteRows = false;
            this.dgvClientsPerTable.AllowUserToOrderColumns = true;
            this.dgvClientsPerTable.AllowUserToResizeColumns = false;
            this.dgvClientsPerTable.AllowUserToResizeRows = false;
            this.dgvClientsPerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsPerTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientsPerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientsPerTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvClientsPerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientsPerTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientsPerTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientsPerTable.Location = new System.Drawing.Point(6, 66);
            this.dgvClientsPerTable.MultiSelect = false;
            this.dgvClientsPerTable.Name = "dgvClientsPerTable";
            this.dgvClientsPerTable.ReadOnly = true;
            this.dgvClientsPerTable.RowHeadersVisible = false;
            this.dgvClientsPerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvClientsPerTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientsPerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientsPerTable.ShowCellErrors = false;
            this.dgvClientsPerTable.ShowCellToolTips = false;
            this.dgvClientsPerTable.ShowEditingIcon = false;
            this.dgvClientsPerTable.ShowRowErrors = false;
            this.dgvClientsPerTable.Size = new System.Drawing.Size(107, 144);
            this.dgvClientsPerTable.TabIndex = 0;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(276, 278);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 37);
            this.bApply.TabIndex = 4;
            this.bApply.Text = "Extend";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(12, 278);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 37);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose client and add money";
            // 
            // ExtendSessionTime
            // 
            this.AcceptButton = this.bApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(366, 323);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.gbExtendWithCard);
            this.Controls.Add(this.gbExtendUsualClient);
            this.Controls.Add(this.tbSessionID);
            this.Controls.Add(this.lSessionID);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendSessionTime";
            this.ShowIcon = false;
            this.Text = "ExtendSessionTime";
            this.Load += new System.EventHandler(this.ExtendSessionTime_Load);
            this.gbExtendUsualClient.ResumeLayout(false);
            this.gbExtendUsualClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesExtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursExtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMoneyExtend)).EndInit();
            this.gbExtendWithCard.ResumeLayout(false);
            this.gbExtendWithCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsPerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSessionID;
        private System.Windows.Forms.TextBox tbSessionID;
        private System.Windows.Forms.GroupBox gbExtendUsualClient;
        private System.Windows.Forms.TextBox tbEndTimeWill;
        private System.Windows.Forms.TextBox tbEndTimeWas;
        private System.Windows.Forms.NumericUpDown numUpDMinutesExtend;
        private System.Windows.Forms.NumericUpDown numUpDHoursExtend;
        private System.Windows.Forms.NumericUpDown numUpDMoneyExtend;
        private System.Windows.Forms.Label EndTimeWill;
        private System.Windows.Forms.Label lEndTimeWas;
        private System.Windows.Forms.Label lExtend;
        private System.Windows.Forms.Label lMoneyToExtend;
        private System.Windows.Forms.GroupBox gbExtendWithCard;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddMoney;
        private System.Windows.Forms.DataGridView dgvClientsPerTable;
        private System.Windows.Forms.Label label1;
    }
}