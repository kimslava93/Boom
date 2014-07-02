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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lSessionID = new System.Windows.Forms.Label();
            this.tbSessionID = new System.Windows.Forms.TextBox();
            this.gbExtendUsualClient = new System.Windows.Forms.GroupBox();
            this.lPercentage = new System.Windows.Forms.Label();
            this.tbDiscountSize = new System.Windows.Forms.TextBox();
            this.lDiscount = new System.Windows.Forms.Label();
            this.tbDiscountCards = new System.Windows.Forms.TextBox();
            this.lClientDiscountId = new System.Windows.Forms.Label();
            this.lPlusMoney = new System.Windows.Forms.Label();
            this.lPlusTime = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.bAddMoney = new System.Windows.Forms.Button();
            this.dgvClientsPerTable = new System.Windows.Forms.DataGridView();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
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
            this.lSessionID.ForeColor = System.Drawing.Color.White;
            this.lSessionID.Location = new System.Drawing.Point(31, 24);
            this.lSessionID.Name = "lSessionID";
            this.lSessionID.Size = new System.Drawing.Size(76, 21);
            this.lSessionID.TabIndex = 0;
            this.lSessionID.Text = "ID сессии";
            // 
            // tbSessionID
            // 
            this.tbSessionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbSessionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSessionID.ForeColor = System.Drawing.Color.White;
            this.tbSessionID.Location = new System.Drawing.Point(201, 21);
            this.tbSessionID.Name = "tbSessionID";
            this.tbSessionID.ReadOnly = true;
            this.tbSessionID.Size = new System.Drawing.Size(100, 29);
            this.tbSessionID.TabIndex = 1;
            // 
            // gbExtendUsualClient
            // 
            this.gbExtendUsualClient.Controls.Add(this.lPercentage);
            this.gbExtendUsualClient.Controls.Add(this.tbDiscountSize);
            this.gbExtendUsualClient.Controls.Add(this.lDiscount);
            this.gbExtendUsualClient.Controls.Add(this.tbDiscountCards);
            this.gbExtendUsualClient.Controls.Add(this.lClientDiscountId);
            this.gbExtendUsualClient.Controls.Add(this.lPlusMoney);
            this.gbExtendUsualClient.Controls.Add(this.lPlusTime);
            this.gbExtendUsualClient.Controls.Add(this.tbEndTimeWill);
            this.gbExtendUsualClient.Controls.Add(this.tbEndTimeWas);
            this.gbExtendUsualClient.Controls.Add(this.numUpDMinutesExtend);
            this.gbExtendUsualClient.Controls.Add(this.numUpDHoursExtend);
            this.gbExtendUsualClient.Controls.Add(this.numUpDMoneyExtend);
            this.gbExtendUsualClient.Controls.Add(this.EndTimeWill);
            this.gbExtendUsualClient.Controls.Add(this.lEndTimeWas);
            this.gbExtendUsualClient.Controls.Add(this.lExtend);
            this.gbExtendUsualClient.Controls.Add(this.lMoneyToExtend);
            this.gbExtendUsualClient.ForeColor = System.Drawing.Color.White;
            this.gbExtendUsualClient.Location = new System.Drawing.Point(12, 56);
            this.gbExtendUsualClient.Name = "gbExtendUsualClient";
            this.gbExtendUsualClient.Size = new System.Drawing.Size(400, 256);
            this.gbExtendUsualClient.TabIndex = 2;
            this.gbExtendUsualClient.TabStop = false;
            this.gbExtendUsualClient.Text = "Продлить время обычного клиента";
            this.gbExtendUsualClient.Enter += new System.EventHandler(this.gbExtendUsualClient_Enter);
            // 
            // lPercentage
            // 
            this.lPercentage.AutoSize = true;
            this.lPercentage.Location = new System.Drawing.Point(260, 67);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(23, 21);
            this.lPercentage.TabIndex = 102;
            this.lPercentage.Text = "%";
            // 
            // tbDiscountSize
            // 
            this.tbDiscountSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbDiscountSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscountSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDiscountSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiscountSize.Enabled = false;
            this.tbDiscountSize.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscountSize.ForeColor = System.Drawing.Color.White;
            this.tbDiscountSize.Location = new System.Drawing.Point(203, 63);
            this.tbDiscountSize.MaxLength = 50;
            this.tbDiscountSize.Name = "tbDiscountSize";
            this.tbDiscountSize.ReadOnly = true;
            this.tbDiscountSize.ShortcutsEnabled = false;
            this.tbDiscountSize.Size = new System.Drawing.Size(57, 29);
            this.tbDiscountSize.TabIndex = 103;
            this.tbDiscountSize.Text = "0";
            // 
            // lDiscount
            // 
            this.lDiscount.AutoSize = true;
            this.lDiscount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDiscount.ForeColor = System.Drawing.Color.White;
            this.lDiscount.Location = new System.Drawing.Point(19, 65);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(59, 21);
            this.lDiscount.TabIndex = 101;
            this.lDiscount.Text = "Скидка";
            // 
            // tbDiscountCards
            // 
            this.tbDiscountCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbDiscountCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscountCards.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiscountCards.Enabled = false;
            this.tbDiscountCards.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscountCards.ForeColor = System.Drawing.Color.White;
            this.tbDiscountCards.Location = new System.Drawing.Point(203, 28);
            this.tbDiscountCards.MaxLength = 50;
            this.tbDiscountCards.Name = "tbDiscountCards";
            this.tbDiscountCards.ReadOnly = true;
            this.tbDiscountCards.ShortcutsEnabled = false;
            this.tbDiscountCards.Size = new System.Drawing.Size(148, 29);
            this.tbDiscountCards.TabIndex = 5;
            this.tbDiscountCards.Text = "0";
            // 
            // lClientDiscountId
            // 
            this.lClientDiscountId.AutoSize = true;
            this.lClientDiscountId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClientDiscountId.ForeColor = System.Drawing.Color.White;
            this.lClientDiscountId.Location = new System.Drawing.Point(19, 30);
            this.lClientDiscountId.Name = "lClientDiscountId";
            this.lClientDiscountId.Size = new System.Drawing.Size(125, 21);
            this.lClientDiscountId.TabIndex = 28;
            this.lClientDiscountId.Text = "Карточки сессии";
            // 
            // lPlusMoney
            // 
            this.lPlusMoney.AutoSize = true;
            this.lPlusMoney.Location = new System.Drawing.Point(331, 134);
            this.lPlusMoney.Name = "lPlusMoney";
            this.lPlusMoney.Size = new System.Drawing.Size(0, 21);
            this.lPlusMoney.TabIndex = 6;
            // 
            // lPlusTime
            // 
            this.lPlusTime.AutoSize = true;
            this.lPlusTime.Location = new System.Drawing.Point(331, 99);
            this.lPlusTime.Name = "lPlusTime";
            this.lPlusTime.Size = new System.Drawing.Size(0, 21);
            this.lPlusTime.TabIndex = 6;
            // 
            // tbEndTimeWill
            // 
            this.tbEndTimeWill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbEndTimeWill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndTimeWill.ForeColor = System.Drawing.Color.White;
            this.tbEndTimeWill.Location = new System.Drawing.Point(203, 222);
            this.tbEndTimeWill.Name = "tbEndTimeWill";
            this.tbEndTimeWill.ReadOnly = true;
            this.tbEndTimeWill.Size = new System.Drawing.Size(148, 29);
            this.tbEndTimeWill.TabIndex = 5;
            // 
            // tbEndTimeWas
            // 
            this.tbEndTimeWas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbEndTimeWas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndTimeWas.ForeColor = System.Drawing.Color.White;
            this.tbEndTimeWas.Location = new System.Drawing.Point(203, 187);
            this.tbEndTimeWas.Name = "tbEndTimeWas";
            this.tbEndTimeWas.ReadOnly = true;
            this.tbEndTimeWas.Size = new System.Drawing.Size(148, 29);
            this.tbEndTimeWas.TabIndex = 4;
            // 
            // numUpDMinutesExtend
            // 
            this.numUpDMinutesExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDMinutesExtend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDMinutesExtend.ForeColor = System.Drawing.Color.White;
            this.numUpDMinutesExtend.Location = new System.Drawing.Point(267, 97);
            this.numUpDMinutesExtend.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDMinutesExtend.Name = "numUpDMinutesExtend";
            this.numUpDMinutesExtend.Size = new System.Drawing.Size(58, 29);
            this.numUpDMinutesExtend.TabIndex = 1;
            this.numUpDMinutesExtend.ValueChanged += new System.EventHandler(this.numUpDMinutesExtend_ValueChanged);
            // 
            // numUpDHoursExtend
            // 
            this.numUpDHoursExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDHoursExtend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDHoursExtend.ForeColor = System.Drawing.Color.White;
            this.numUpDHoursExtend.Location = new System.Drawing.Point(203, 97);
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
            this.numUpDMoneyExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDMoneyExtend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDMoneyExtend.ForeColor = System.Drawing.Color.White;
            this.numUpDMoneyExtend.Location = new System.Drawing.Point(203, 132);
            this.numUpDMoneyExtend.Maximum = new decimal(new int[] {
            19400,
            0,
            0,
            0});
            this.numUpDMoneyExtend.Name = "numUpDMoneyExtend";
            this.numUpDMoneyExtend.Size = new System.Drawing.Size(122, 29);
            this.numUpDMoneyExtend.TabIndex = 3;
            this.numUpDMoneyExtend.ValueChanged += new System.EventHandler(this.numUpDMoneyExtend_ValueChanged);
            // 
            // EndTimeWill
            // 
            this.EndTimeWill.AutoSize = true;
            this.EndTimeWill.ForeColor = System.Drawing.Color.White;
            this.EndTimeWill.Location = new System.Drawing.Point(19, 224);
            this.EndTimeWill.Name = "EndTimeWill";
            this.EndTimeWill.Size = new System.Drawing.Size(110, 21);
            this.EndTimeWill.TabIndex = 0;
            this.EndTimeWill.Text = "Продление до";
            // 
            // lEndTimeWas
            // 
            this.lEndTimeWas.AutoSize = true;
            this.lEndTimeWas.ForeColor = System.Drawing.Color.White;
            this.lEndTimeWas.Location = new System.Drawing.Point(19, 189);
            this.lEndTimeWas.Name = "lEndTimeWas";
            this.lEndTimeWas.Size = new System.Drawing.Size(85, 21);
            this.lEndTimeWas.TabIndex = 0;
            this.lEndTimeWas.Text = "Конец был";
            // 
            // lExtend
            // 
            this.lExtend.AutoSize = true;
            this.lExtend.ForeColor = System.Drawing.Color.White;
            this.lExtend.Location = new System.Drawing.Point(19, 99);
            this.lExtend.Name = "lExtend";
            this.lExtend.Size = new System.Drawing.Size(163, 21);
            this.lExtend.TabIndex = 0;
            this.lExtend.Text = "Время для продления";
            // 
            // lMoneyToExtend
            // 
            this.lMoneyToExtend.AutoSize = true;
            this.lMoneyToExtend.ForeColor = System.Drawing.Color.White;
            this.lMoneyToExtend.Location = new System.Drawing.Point(19, 134);
            this.lMoneyToExtend.Name = "lMoneyToExtend";
            this.lMoneyToExtend.Size = new System.Drawing.Size(153, 21);
            this.lMoneyToExtend.TabIndex = 0;
            this.lMoneyToExtend.Text = "Денег на продление";
            // 
            // gbExtendWithCard
            // 
            this.gbExtendWithCard.Controls.Add(this.label1);
            this.gbExtendWithCard.Controls.Add(this.bAddMoney);
            this.gbExtendWithCard.Controls.Add(this.dgvClientsPerTable);
            this.gbExtendWithCard.ForeColor = System.Drawing.Color.White;
            this.gbExtendWithCard.Location = new System.Drawing.Point(513, 56);
            this.gbExtendWithCard.Name = "gbExtendWithCard";
            this.gbExtendWithCard.Size = new System.Drawing.Size(298, 216);
            this.gbExtendWithCard.TabIndex = 3;
            this.gbExtendWithCard.TabStop = false;
            this.gbExtendWithCard.Text = "Продлить время клиента с карточкой";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите клиента и начислите деньги";
            // 
            // bAddMoney
            // 
            this.bAddMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddMoney.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddMoney.Location = new System.Drawing.Point(150, 113);
            this.bAddMoney.Name = "bAddMoney";
            this.bAddMoney.Size = new System.Drawing.Size(48, 42);
            this.bAddMoney.TabIndex = 1;
            this.bAddMoney.Text = "+";
            this.bAddMoney.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientsPerTable.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(311, 318);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(98, 37);
            this.bApply.TabIndex = 0;
            this.bApply.Text = "Продлить";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(12, 318);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(95, 37);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // ExtendSessionTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(421, 367);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendSessionTime";
            this.Load += new System.EventHandler(this.ExtendSessionTime_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExtendSessionTime_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExtendSessionTime_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExtendSessionTime_MouseUp);
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
        private System.Windows.Forms.Label lPlusMoney;
        private System.Windows.Forms.Label lPlusTime;
        private System.Windows.Forms.TextBox tbDiscountCards;
        private System.Windows.Forms.Label lClientDiscountId;
        private System.Windows.Forms.Label lPercentage;
        private System.Windows.Forms.TextBox tbDiscountSize;
        private System.Windows.Forms.Label lDiscount;
    }
}