namespace Boom_Manager_Project
{
    partial class TimeTester
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
            this.lPlusTime = new System.Windows.Forms.Label();
            this.numUpDMinutesLeft = new System.Windows.Forms.NumericUpDown();
            this.numUpDHoursLeft = new System.Windows.Forms.NumericUpDown();
            this.lTimeToPlay = new System.Windows.Forms.Label();
            this.lPlusMoney = new System.Windows.Forms.Label();
            this.numUpDPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.lMoneyToPay = new System.Windows.Forms.Label();
            this.numUpDCurMinute = new System.Windows.Forms.NumericUpDown();
            this.numUpDCurHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNighTime = new System.Windows.Forms.CheckBox();
            this.cbPlaystationId = new System.Windows.Forms.ComboBox();
            this.lPlaystationId = new System.Windows.Forms.Label();
            this.lPercentage = new System.Windows.Forms.Label();
            this.tbDiscountSize = new System.Windows.Forms.TextBox();
            this.lDiscount = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddSession = new System.Windows.Forms.Button();
            this.tbDiscountCards = new System.Windows.Forms.TextBox();
            this.lClientDiscountId = new System.Windows.Forms.Label();
            this.numUpDCurTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.bSetCurTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPaidPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCurMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCurHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCurTimeSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // lPlusTime
            // 
            this.lPlusTime.AutoSize = true;
            this.lPlusTime.ForeColor = System.Drawing.Color.LightGreen;
            this.lPlusTime.Location = new System.Drawing.Point(444, 204);
            this.lPlusTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlusTime.Name = "lPlusTime";
            this.lPlusTime.Size = new System.Drawing.Size(0, 21);
            this.lPlusTime.TabIndex = 34;
            // 
            // numUpDMinutesLeft
            // 
            this.numUpDMinutesLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDMinutesLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDMinutesLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDMinutesLeft.ForeColor = System.Drawing.Color.White;
            this.numUpDMinutesLeft.Location = new System.Drawing.Point(308, 199);
            this.numUpDMinutesLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDMinutesLeft.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDMinutesLeft.Name = "numUpDMinutesLeft";
            this.numUpDMinutesLeft.Size = new System.Drawing.Size(72, 29);
            this.numUpDMinutesLeft.TabIndex = 32;
            this.numUpDMinutesLeft.ValueChanged += new System.EventHandler(this.numUpDMinutesLeft_ValueChanged);
            // 
            // numUpDHoursLeft
            // 
            this.numUpDHoursLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDHoursLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDHoursLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDHoursLeft.ForeColor = System.Drawing.Color.White;
            this.numUpDHoursLeft.Location = new System.Drawing.Point(229, 199);
            this.numUpDHoursLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDHoursLeft.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUpDHoursLeft.Name = "numUpDHoursLeft";
            this.numUpDHoursLeft.Size = new System.Drawing.Size(72, 29);
            this.numUpDHoursLeft.TabIndex = 31;
            this.numUpDHoursLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDHoursLeft.ValueChanged += new System.EventHandler(this.numUpDHoursLeft_ValueChanged);
            // 
            // lTimeToPlay
            // 
            this.lTimeToPlay.AutoSize = true;
            this.lTimeToPlay.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimeToPlay.ForeColor = System.Drawing.Color.White;
            this.lTimeToPlay.Location = new System.Drawing.Point(29, 201);
            this.lTimeToPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTimeToPlay.Name = "lTimeToPlay";
            this.lTimeToPlay.Size = new System.Drawing.Size(145, 21);
            this.lTimeToPlay.TabIndex = 33;
            this.lTimeToPlay.Text = "Оплаченное время";
            // 
            // lPlusMoney
            // 
            this.lPlusMoney.AutoSize = true;
            this.lPlusMoney.ForeColor = System.Drawing.Color.LightGreen;
            this.lPlusMoney.Location = new System.Drawing.Point(410, 176);
            this.lPlusMoney.Name = "lPlusMoney";
            this.lPlusMoney.Size = new System.Drawing.Size(0, 21);
            this.lPlusMoney.TabIndex = 37;
            // 
            // numUpDPaidPrice
            // 
            this.numUpDPaidPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDPaidPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDPaidPrice.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDPaidPrice.ForeColor = System.Drawing.Color.White;
            this.numUpDPaidPrice.Location = new System.Drawing.Point(229, 236);
            this.numUpDPaidPrice.Maximum = new decimal(new int[] {
            18900,
            0,
            0,
            0});
            this.numUpDPaidPrice.Name = "numUpDPaidPrice";
            this.numUpDPaidPrice.Size = new System.Drawing.Size(113, 29);
            this.numUpDPaidPrice.TabIndex = 35;
            this.numUpDPaidPrice.ValueChanged += new System.EventHandler(this.numUpDPaidPrice_ValueChanged);
            // 
            // lMoneyToPay
            // 
            this.lMoneyToPay.AutoSize = true;
            this.lMoneyToPay.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMoneyToPay.ForeColor = System.Drawing.Color.White;
            this.lMoneyToPay.Location = new System.Drawing.Point(29, 238);
            this.lMoneyToPay.Name = "lMoneyToPay";
            this.lMoneyToPay.Size = new System.Drawing.Size(123, 21);
            this.lMoneyToPay.TabIndex = 36;
            this.lMoneyToPay.Text = "Денег оплачено";
            // 
            // numUpDCurMinute
            // 
            this.numUpDCurMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDCurMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDCurMinute.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDCurMinute.ForeColor = System.Drawing.Color.White;
            this.numUpDCurMinute.Location = new System.Drawing.Point(306, 49);
            this.numUpDCurMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDCurMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDCurMinute.Name = "numUpDCurMinute";
            this.numUpDCurMinute.Size = new System.Drawing.Size(72, 29);
            this.numUpDCurMinute.TabIndex = 39;
            this.numUpDCurMinute.ValueChanged += new System.EventHandler(this.numUpDCurMinute_ValueChanged);
            // 
            // numUpDCurHour
            // 
            this.numUpDCurHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDCurHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDCurHour.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDCurHour.ForeColor = System.Drawing.Color.White;
            this.numUpDCurHour.Location = new System.Drawing.Point(227, 49);
            this.numUpDCurHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDCurHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUpDCurHour.Name = "numUpDCurHour";
            this.numUpDCurHour.Size = new System.Drawing.Size(72, 29);
            this.numUpDCurHour.TabIndex = 38;
            this.numUpDCurHour.ValueChanged += new System.EventHandler(this.numUpDCurHour_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Текущее время";
            // 
            // cbNighTime
            // 
            this.cbNighTime.AutoSize = true;
            this.cbNighTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNighTime.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNighTime.ForeColor = System.Drawing.Color.White;
            this.cbNighTime.Location = new System.Drawing.Point(229, 131);
            this.cbNighTime.Name = "cbNighTime";
            this.cbNighTime.Size = new System.Drawing.Size(123, 25);
            this.cbNighTime.TabIndex = 104;
            this.cbNighTime.Text = "Ночной пакет";
            this.cbNighTime.UseVisualStyleBackColor = true;
            this.cbNighTime.CheckedChanged += new System.EventHandler(this.cbNighTime_CheckedChanged);
            // 
            // cbPlaystationId
            // 
            this.cbPlaystationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlaystationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbPlaystationId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlaystationId.ForeColor = System.Drawing.Color.White;
            this.cbPlaystationId.Location = new System.Drawing.Point(229, 162);
            this.cbPlaystationId.Name = "cbPlaystationId";
            this.cbPlaystationId.Size = new System.Drawing.Size(95, 29);
            this.cbPlaystationId.TabIndex = 102;
            this.cbPlaystationId.SelectedIndexChanged += new System.EventHandler(this.cbPlaystationId_SelectedIndexChanged);
            // 
            // lPlaystationId
            // 
            this.lPlaystationId.AutoSize = true;
            this.lPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlaystationId.ForeColor = System.Drawing.Color.White;
            this.lPlaystationId.Location = new System.Drawing.Point(29, 165);
            this.lPlaystationId.Name = "lPlaystationId";
            this.lPlaystationId.Size = new System.Drawing.Size(104, 21);
            this.lPlaystationId.TabIndex = 103;
            this.lPlaystationId.Text = "№ приставки";
            // 
            // lPercentage
            // 
            this.lPercentage.AutoSize = true;
            this.lPercentage.Location = new System.Drawing.Point(284, 275);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(23, 21);
            this.lPercentage.TabIndex = 106;
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
            this.tbDiscountSize.Location = new System.Drawing.Point(227, 271);
            this.tbDiscountSize.MaxLength = 50;
            this.tbDiscountSize.Name = "tbDiscountSize";
            this.tbDiscountSize.ShortcutsEnabled = false;
            this.tbDiscountSize.Size = new System.Drawing.Size(57, 29);
            this.tbDiscountSize.TabIndex = 107;
            this.tbDiscountSize.Text = "0";
            this.tbDiscountSize.TextChanged += new System.EventHandler(this.tbDiscountSize_TextChanged);
            // 
            // lDiscount
            // 
            this.lDiscount.AutoSize = true;
            this.lDiscount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDiscount.ForeColor = System.Drawing.Color.White;
            this.lDiscount.Location = new System.Drawing.Point(29, 273);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(59, 21);
            this.lDiscount.TabIndex = 105;
            this.lDiscount.Text = "Скидка";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(12, 314);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(105, 38);
            this.bCancel.TabIndex = 109;
            this.bCancel.Text = "Закрыть";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddSession
            // 
            this.bAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddSession.ForeColor = System.Drawing.Color.White;
            this.bAddSession.Location = new System.Drawing.Point(354, 314);
            this.bAddSession.Name = "bAddSession";
            this.bAddSession.Size = new System.Drawing.Size(104, 38);
            this.bAddSession.TabIndex = 108;
            this.bAddSession.Text = "Посчитать";
            this.bAddSession.UseVisualStyleBackColor = false;
            this.bAddSession.Click += new System.EventHandler(this.bAddSession_Click);
            // 
            // tbDiscountCards
            // 
            this.tbDiscountCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbDiscountCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscountCards.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiscountCards.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscountCards.ForeColor = System.Drawing.Color.White;
            this.tbDiscountCards.Location = new System.Drawing.Point(227, 88);
            this.tbDiscountCards.MaxLength = 50;
            this.tbDiscountCards.Name = "tbDiscountCards";
            this.tbDiscountCards.ShortcutsEnabled = false;
            this.tbDiscountCards.Size = new System.Drawing.Size(148, 29);
            this.tbDiscountCards.TabIndex = 110;
            this.tbDiscountCards.Text = "0";
            this.tbDiscountCards.TextChanged += new System.EventHandler(this.tbDiscountCards_TextChanged);
            this.tbDiscountCards.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiscountCards_KeyPress);
            // 
            // lClientDiscountId
            // 
            this.lClientDiscountId.AutoSize = true;
            this.lClientDiscountId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClientDiscountId.ForeColor = System.Drawing.Color.White;
            this.lClientDiscountId.Location = new System.Drawing.Point(29, 90);
            this.lClientDiscountId.Name = "lClientDiscountId";
            this.lClientDiscountId.Size = new System.Drawing.Size(125, 21);
            this.lClientDiscountId.TabIndex = 111;
            this.lClientDiscountId.Text = "Карточки сессии";
            // 
            // numUpDCurTimeSeconds
            // 
            this.numUpDCurTimeSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDCurTimeSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDCurTimeSeconds.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDCurTimeSeconds.ForeColor = System.Drawing.Color.White;
            this.numUpDCurTimeSeconds.Location = new System.Drawing.Point(386, 49);
            this.numUpDCurTimeSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDCurTimeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDCurTimeSeconds.Name = "numUpDCurTimeSeconds";
            this.numUpDCurTimeSeconds.Size = new System.Drawing.Size(72, 29);
            this.numUpDCurTimeSeconds.TabIndex = 39;
            this.numUpDCurTimeSeconds.ValueChanged += new System.EventHandler(this.numUpDCurTimeSeconds_ValueChanged);
            // 
            // bSetCurTime
            // 
            this.bSetCurTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bSetCurTime.FlatAppearance.BorderSize = 0;
            this.bSetCurTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSetCurTime.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSetCurTime.Location = new System.Drawing.Point(354, 18);
            this.bSetCurTime.Name = "bSetCurTime";
            this.bSetCurTime.Size = new System.Drawing.Size(107, 23);
            this.bSetCurTime.TabIndex = 112;
            this.bSetCurTime.Text = "текущее время";
            this.bSetCurTime.UseVisualStyleBackColor = false;
            this.bSetCurTime.Click += new System.EventHandler(this.bSetCurTime_Click);
            // 
            // TimeTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(473, 364);
            this.Controls.Add(this.bSetCurTime);
            this.Controls.Add(this.tbDiscountCards);
            this.Controls.Add(this.lClientDiscountId);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAddSession);
            this.Controls.Add(this.lPercentage);
            this.Controls.Add(this.tbDiscountSize);
            this.Controls.Add(this.lDiscount);
            this.Controls.Add(this.cbNighTime);
            this.Controls.Add(this.cbPlaystationId);
            this.Controls.Add(this.lPlaystationId);
            this.Controls.Add(this.numUpDCurTimeSeconds);
            this.Controls.Add(this.numUpDCurMinute);
            this.Controls.Add(this.numUpDCurHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPlusMoney);
            this.Controls.Add(this.numUpDPaidPrice);
            this.Controls.Add(this.lMoneyToPay);
            this.Controls.Add(this.lPlusTime);
            this.Controls.Add(this.numUpDMinutesLeft);
            this.Controls.Add(this.numUpDHoursLeft);
            this.Controls.Add(this.lTimeToPlay);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TimeTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeTester";
            this.Load += new System.EventHandler(this.TimeTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPaidPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCurMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCurHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCurTimeSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPlusTime;
        private System.Windows.Forms.NumericUpDown numUpDMinutesLeft;
        private System.Windows.Forms.NumericUpDown numUpDHoursLeft;
        private System.Windows.Forms.Label lTimeToPlay;
        private System.Windows.Forms.Label lPlusMoney;
        private System.Windows.Forms.NumericUpDown numUpDPaidPrice;
        private System.Windows.Forms.Label lMoneyToPay;
        private System.Windows.Forms.NumericUpDown numUpDCurMinute;
        private System.Windows.Forms.NumericUpDown numUpDCurHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNighTime;
        private System.Windows.Forms.ComboBox cbPlaystationId;
        private System.Windows.Forms.Label lPlaystationId;
        private System.Windows.Forms.Label lPercentage;
        private System.Windows.Forms.TextBox tbDiscountSize;
        private System.Windows.Forms.Label lDiscount;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddSession;
        private System.Windows.Forms.TextBox tbDiscountCards;
        private System.Windows.Forms.Label lClientDiscountId;
        private System.Windows.Forms.NumericUpDown numUpDCurTimeSeconds;
        private System.Windows.Forms.Button bSetCurTime;
    }
}