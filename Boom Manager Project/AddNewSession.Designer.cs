namespace Boom_Manager_Project
{
    partial class FAddNewSession
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
            this.numUpDMinutesLeft = new System.Windows.Forms.NumericUpDown();
            this.bCancel = new System.Windows.Forms.Button();
            this.numUpDHoursLeft = new System.Windows.Forms.NumericUpDown();
            this.lOR = new System.Windows.Forms.Label();
            this.lMoneyToPay = new System.Windows.Forms.Label();
            this.tbDiscountCards = new System.Windows.Forms.TextBox();
            this.lTimeToPlay = new System.Windows.Forms.Label();
            this.bAddDiscountCard = new System.Windows.Forms.Button();
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.numUpDMinutesRemainedOnCard = new System.Windows.Forms.NumericUpDown();
            this.numUpDHoursRemainedOnCard = new System.Windows.Forms.NumericUpDown();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.numUpDClientMoneyLeft = new System.Windows.Forms.NumericUpDown();
            this.lClientName = new System.Windows.Forms.Label();
            this.lMoneyOnCardLeft = new System.Windows.Forms.Label();
            this.lTimeOnCardLeft = new System.Windows.Forms.Label();
            this.current_time_timer = new System.Windows.Forms.Timer(this.components);
            this.cbPlaystationId = new System.Windows.Forms.ComboBox();
            this.lPlaystationId = new System.Windows.Forms.Label();
            this.lClientDiscountId = new System.Windows.Forms.Label();
            this.bAddSession = new System.Windows.Forms.Button();
            this.numUpDPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.gbDepositPayment = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursLeft)).BeginInit();
            this.gbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesRemainedOnCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursRemainedOnCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDClientMoneyLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPaidPrice)).BeginInit();
            this.gbDepositPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUpDMinutesLeft
            // 
            this.numUpDMinutesLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDMinutesLeft.Location = new System.Drawing.Point(222, 25);
            this.numUpDMinutesLeft.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDMinutesLeft.Name = "numUpDMinutesLeft";
            this.numUpDMinutesLeft.Size = new System.Drawing.Size(54, 29);
            this.numUpDMinutesLeft.TabIndex = 6;
            this.numUpDMinutesLeft.ValueChanged += new System.EventHandler(this.numUpDMinutesLeft_ValueChanged);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(206, 334);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 38);
            this.bCancel.TabIndex = 30;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // numUpDHoursLeft
            // 
            this.numUpDHoursLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDHoursLeft.Location = new System.Drawing.Point(163, 25);
            this.numUpDHoursLeft.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDHoursLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDHoursLeft.Name = "numUpDHoursLeft";
            this.numUpDHoursLeft.Size = new System.Drawing.Size(54, 29);
            this.numUpDHoursLeft.TabIndex = 5;
            this.numUpDHoursLeft.ThousandsSeparator = true;
            this.numUpDHoursLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDHoursLeft.ValueChanged += new System.EventHandler(this.numUpDHoursLeft_ValueChanged);
            // 
            // lOR
            // 
            this.lOR.AutoSize = true;
            this.lOR.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOR.Location = new System.Drawing.Point(79, 62);
            this.lOR.Name = "lOR";
            this.lOR.Size = new System.Drawing.Size(31, 21);
            this.lOR.TabIndex = 2;
            this.lOR.Text = "OR";
            // 
            // lMoneyToPay
            // 
            this.lMoneyToPay.AutoSize = true;
            this.lMoneyToPay.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMoneyToPay.Location = new System.Drawing.Point(14, 93);
            this.lMoneyToPay.Name = "lMoneyToPay";
            this.lMoneyToPay.Size = new System.Drawing.Size(102, 21);
            this.lMoneyToPay.TabIndex = 8;
            this.lMoneyToPay.Text = "Money to pay";
            // 
            // tbDiscountCards
            // 
            this.tbDiscountCards.BackColor = System.Drawing.Color.White;
            this.tbDiscountCards.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDiscountCards.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscountCards.HideSelection = false;
            this.tbDiscountCards.Location = new System.Drawing.Point(146, 49);
            this.tbDiscountCards.Name = "tbDiscountCards";
            this.tbDiscountCards.ReadOnly = true;
            this.tbDiscountCards.ShortcutsEnabled = false;
            this.tbDiscountCards.Size = new System.Drawing.Size(116, 29);
            this.tbDiscountCards.TabIndex = 28;
            this.tbDiscountCards.Text = "0";
            this.tbDiscountCards.TextChanged += new System.EventHandler(this.tbDiscountCards_TextChanged);
            // 
            // lTimeToPlay
            // 
            this.lTimeToPlay.AutoSize = true;
            this.lTimeToPlay.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimeToPlay.Location = new System.Drawing.Point(14, 27);
            this.lTimeToPlay.Name = "lTimeToPlay";
            this.lTimeToPlay.Size = new System.Drawing.Size(91, 21);
            this.lTimeToPlay.TabIndex = 8;
            this.lTimeToPlay.Text = "Time to play";
            // 
            // bAddDiscountCard
            // 
            this.bAddDiscountCard.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddDiscountCard.Location = new System.Drawing.Point(268, 49);
            this.bAddDiscountCard.Name = "bAddDiscountCard";
            this.bAddDiscountCard.Size = new System.Drawing.Size(49, 29);
            this.bAddDiscountCard.TabIndex = 29;
            this.bAddDiscountCard.Text = "Add card";
            this.bAddDiscountCard.UseVisualStyleBackColor = true;
            this.bAddDiscountCard.Click += new System.EventHandler(this.bAddDiscountCard_Click);
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Controls.Add(this.numUpDMinutesRemainedOnCard);
            this.gbClientInfo.Controls.Add(this.numUpDHoursRemainedOnCard);
            this.gbClientInfo.Controls.Add(this.tbClientName);
            this.gbClientInfo.Controls.Add(this.numUpDClientMoneyLeft);
            this.gbClientInfo.Controls.Add(this.lClientName);
            this.gbClientInfo.Controls.Add(this.lMoneyOnCardLeft);
            this.gbClientInfo.Controls.Add(this.lTimeOnCardLeft);
            this.gbClientInfo.Enabled = false;
            this.gbClientInfo.Location = new System.Drawing.Point(388, 150);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(304, 178);
            this.gbClientInfo.TabIndex = 27;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Client name info";
            // 
            // numUpDMinutesRemainedOnCard
            // 
            this.numUpDMinutesRemainedOnCard.Enabled = false;
            this.numUpDMinutesRemainedOnCard.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDMinutesRemainedOnCard.Location = new System.Drawing.Point(228, 73);
            this.numUpDMinutesRemainedOnCard.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDMinutesRemainedOnCard.Name = "numUpDMinutesRemainedOnCard";
            this.numUpDMinutesRemainedOnCard.ReadOnly = true;
            this.numUpDMinutesRemainedOnCard.Size = new System.Drawing.Size(60, 29);
            this.numUpDMinutesRemainedOnCard.TabIndex = 8;
            // 
            // numUpDHoursRemainedOnCard
            // 
            this.numUpDHoursRemainedOnCard.Enabled = false;
            this.numUpDHoursRemainedOnCard.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDHoursRemainedOnCard.Location = new System.Drawing.Point(162, 73);
            this.numUpDHoursRemainedOnCard.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDHoursRemainedOnCard.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDHoursRemainedOnCard.Name = "numUpDHoursRemainedOnCard";
            this.numUpDHoursRemainedOnCard.ReadOnly = true;
            this.numUpDHoursRemainedOnCard.Size = new System.Drawing.Size(60, 29);
            this.numUpDHoursRemainedOnCard.TabIndex = 7;
            this.numUpDHoursRemainedOnCard.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(116, 24);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(172, 29);
            this.tbClientName.TabIndex = 3;
            // 
            // numUpDClientMoneyLeft
            // 
            this.numUpDClientMoneyLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDClientMoneyLeft.DecimalPlaces = 2;
            this.numUpDClientMoneyLeft.Enabled = false;
            this.numUpDClientMoneyLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDClientMoneyLeft.Location = new System.Drawing.Point(162, 114);
            this.numUpDClientMoneyLeft.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numUpDClientMoneyLeft.Name = "numUpDClientMoneyLeft";
            this.numUpDClientMoneyLeft.ReadOnly = true;
            this.numUpDClientMoneyLeft.Size = new System.Drawing.Size(126, 29);
            this.numUpDClientMoneyLeft.TabIndex = 5;
            this.numUpDClientMoneyLeft.ValueChanged += new System.EventHandler(this.numUpDClientMoneyLeft_ValueChanged);
            // 
            // lClientName
            // 
            this.lClientName.AutoSize = true;
            this.lClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClientName.Location = new System.Drawing.Point(6, 27);
            this.lClientName.Name = "lClientName";
            this.lClientName.Size = new System.Drawing.Size(90, 21);
            this.lClientName.TabIndex = 0;
            this.lClientName.Text = "Client name";
            // 
            // lMoneyOnCardLeft
            // 
            this.lMoneyOnCardLeft.AutoSize = true;
            this.lMoneyOnCardLeft.Enabled = false;
            this.lMoneyOnCardLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMoneyOnCardLeft.Location = new System.Drawing.Point(12, 116);
            this.lMoneyOnCardLeft.Name = "lMoneyOnCardLeft";
            this.lMoneyOnCardLeft.Size = new System.Drawing.Size(80, 21);
            this.lMoneyOnCardLeft.TabIndex = 8;
            this.lMoneyOnCardLeft.Text = "Money left";
            // 
            // lTimeOnCardLeft
            // 
            this.lTimeOnCardLeft.AutoSize = true;
            this.lTimeOnCardLeft.Enabled = false;
            this.lTimeOnCardLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeOnCardLeft.Location = new System.Drawing.Point(6, 75);
            this.lTimeOnCardLeft.Name = "lTimeOnCardLeft";
            this.lTimeOnCardLeft.Size = new System.Drawing.Size(115, 21);
            this.lTimeOnCardLeft.TabIndex = 8;
            this.lTimeOnCardLeft.Text = "Time to play left";
            // 
            // current_time_timer
            // 
            this.current_time_timer.Enabled = true;
            this.current_time_timer.Interval = 1000;
            // 
            // cbPlaystationId
            // 
            this.cbPlaystationId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlaystationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlaystationId.Location = new System.Drawing.Point(146, 97);
            this.cbPlaystationId.Name = "cbPlaystationId";
            this.cbPlaystationId.Size = new System.Drawing.Size(61, 29);
            this.cbPlaystationId.TabIndex = 21;
            this.cbPlaystationId.SelectedIndexChanged += new System.EventHandler(this.cbPlaystationId_SelectedIndexChanged);
            // 
            // lPlaystationId
            // 
            this.lPlaystationId.AutoSize = true;
            this.lPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlaystationId.Location = new System.Drawing.Point(12, 100);
            this.lPlaystationId.Name = "lPlaystationId";
            this.lPlaystationId.Size = new System.Drawing.Size(96, 21);
            this.lPlaystationId.TabIndex = 20;
            this.lPlaystationId.Text = "Playstation #";
            // 
            // lClientDiscountId
            // 
            this.lClientDiscountId.AutoSize = true;
            this.lClientDiscountId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClientDiscountId.Location = new System.Drawing.Point(12, 52);
            this.lClientDiscountId.Name = "lClientDiscountId";
            this.lClientDiscountId.Size = new System.Drawing.Size(128, 21);
            this.lClientDiscountId.TabIndex = 26;
            this.lClientDiscountId.Text = "Client discount ID";
            // 
            // bAddSession
            // 
            this.bAddSession.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddSession.Location = new System.Drawing.Point(12, 334);
            this.bAddSession.Name = "bAddSession";
            this.bAddSession.Size = new System.Drawing.Size(111, 38);
            this.bAddSession.TabIndex = 25;
            this.bAddSession.Text = "Add new client";
            this.bAddSession.UseVisualStyleBackColor = true;
            this.bAddSession.Click += new System.EventHandler(this.bAddSession_Click);
            // 
            // numUpDPaidPrice
            // 
            this.numUpDPaidPrice.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDPaidPrice.Location = new System.Drawing.Point(163, 91);
            this.numUpDPaidPrice.Maximum = new decimal(new int[] {
            18900,
            0,
            0,
            0});
            this.numUpDPaidPrice.Name = "numUpDPaidPrice";
            this.numUpDPaidPrice.Size = new System.Drawing.Size(113, 29);
            this.numUpDPaidPrice.TabIndex = 4;
            this.numUpDPaidPrice.ValueChanged += new System.EventHandler(this.numUpDPaidPrice_ValueChanged);
            // 
            // gbDepositPayment
            // 
            this.gbDepositPayment.Controls.Add(this.numUpDMinutesLeft);
            this.gbDepositPayment.Controls.Add(this.numUpDHoursLeft);
            this.gbDepositPayment.Controls.Add(this.numUpDPaidPrice);
            this.gbDepositPayment.Controls.Add(this.lOR);
            this.gbDepositPayment.Controls.Add(this.lMoneyToPay);
            this.gbDepositPayment.Controls.Add(this.lTimeToPlay);
            this.gbDepositPayment.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDepositPayment.Location = new System.Drawing.Point(12, 150);
            this.gbDepositPayment.Name = "gbDepositPayment";
            this.gbDepositPayment.Size = new System.Drawing.Size(305, 178);
            this.gbDepositPayment.TabIndex = 22;
            this.gbDepositPayment.TabStop = false;
            this.gbDepositPayment.Text = "Deposit payment";
            // 
            // FAddNewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(327, 383);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbDiscountCards);
            this.Controls.Add(this.bAddDiscountCard);
            this.Controls.Add(this.gbClientInfo);
            this.Controls.Add(this.cbPlaystationId);
            this.Controls.Add(this.lPlaystationId);
            this.Controls.Add(this.lClientDiscountId);
            this.Controls.Add(this.bAddSession);
            this.Controls.Add(this.gbDepositPayment);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAddNewSession";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewDaySession";
            this.Load += new System.EventHandler(this.AddNewSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursLeft)).EndInit();
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesRemainedOnCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursRemainedOnCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDClientMoneyLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPaidPrice)).EndInit();
            this.gbDepositPayment.ResumeLayout(false);
            this.gbDepositPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDMinutesLeft;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.NumericUpDown numUpDHoursLeft;
        private System.Windows.Forms.Label lOR;
        private System.Windows.Forms.Label lMoneyToPay;
        private System.Windows.Forms.TextBox tbDiscountCards;
        private System.Windows.Forms.Label lTimeToPlay;
        private System.Windows.Forms.Button bAddDiscountCard;
        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.NumericUpDown numUpDMinutesRemainedOnCard;
        private System.Windows.Forms.NumericUpDown numUpDHoursRemainedOnCard;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.NumericUpDown numUpDClientMoneyLeft;
        private System.Windows.Forms.Label lClientName;
        private System.Windows.Forms.Label lMoneyOnCardLeft;
        private System.Windows.Forms.Label lTimeOnCardLeft;
        private System.Windows.Forms.Timer current_time_timer;
        private System.Windows.Forms.ComboBox cbPlaystationId;
        private System.Windows.Forms.Label lPlaystationId;
        private System.Windows.Forms.Label lClientDiscountId;
        private System.Windows.Forms.Button bAddSession;
        private System.Windows.Forms.NumericUpDown numUpDPaidPrice;
        private System.Windows.Forms.GroupBox gbDepositPayment;
    }
}