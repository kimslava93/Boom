namespace Boom_Manager_Project
{
    partial class AddDiscountCardToSession
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
            this.bAddMoney = new System.Windows.Forms.Button();
            this.numUpDAddMoneyOnCard = new System.Windows.Forms.NumericUpDown();
            this.cbClientsMoneyLeft = new System.Windows.Forms.TextBox();
            this.cbClientName = new System.Windows.Forms.TextBox();
            this.lAddMoney = new System.Windows.Forms.Label();
            this.lMoneyLeft = new System.Windows.Forms.Label();
            this.lClientName = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.lDsicountId = new System.Windows.Forms.Label();
            this.cbDiscountCard = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDAddMoneyOnCard)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddMoney
            // 
            this.bAddMoney.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAddMoney.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddMoney.Location = new System.Drawing.Point(305, 121);
            this.bAddMoney.Name = "bAddMoney";
            this.bAddMoney.Size = new System.Drawing.Size(27, 29);
            this.bAddMoney.TabIndex = 22;
            this.bAddMoney.Text = ">";
            this.bAddMoney.UseVisualStyleBackColor = true;
            // 
            // numUpDAddMoneyOnCard
            // 
            this.numUpDAddMoneyOnCard.DecimalPlaces = 2;
            this.numUpDAddMoneyOnCard.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDAddMoneyOnCard.Location = new System.Drawing.Point(153, 121);
            this.numUpDAddMoneyOnCard.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numUpDAddMoneyOnCard.Name = "numUpDAddMoneyOnCard";
            this.numUpDAddMoneyOnCard.Size = new System.Drawing.Size(78, 29);
            this.numUpDAddMoneyOnCard.TabIndex = 21;
            // 
            // cbClientsMoneyLeft
            // 
            this.cbClientsMoneyLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientsMoneyLeft.Location = new System.Drawing.Point(153, 86);
            this.cbClientsMoneyLeft.Name = "cbClientsMoneyLeft";
            this.cbClientsMoneyLeft.ReadOnly = true;
            this.cbClientsMoneyLeft.Size = new System.Drawing.Size(179, 29);
            this.cbClientsMoneyLeft.TabIndex = 20;
            // 
            // cbClientName
            // 
            this.cbClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientName.Location = new System.Drawing.Point(153, 51);
            this.cbClientName.Name = "cbClientName";
            this.cbClientName.ReadOnly = true;
            this.cbClientName.Size = new System.Drawing.Size(179, 29);
            this.cbClientName.TabIndex = 19;
            // 
            // lAddMoney
            // 
            this.lAddMoney.AutoSize = true;
            this.lAddMoney.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lAddMoney.Location = new System.Drawing.Point(12, 119);
            this.lAddMoney.Name = "lAddMoney";
            this.lAddMoney.Size = new System.Drawing.Size(88, 21);
            this.lAddMoney.TabIndex = 18;
            this.lAddMoney.Text = "Add money";
            // 
            // lMoneyLeft
            // 
            this.lMoneyLeft.AutoSize = true;
            this.lMoneyLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMoneyLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lMoneyLeft.Location = new System.Drawing.Point(12, 86);
            this.lMoneyLeft.Name = "lMoneyLeft";
            this.lMoneyLeft.Size = new System.Drawing.Size(80, 21);
            this.lMoneyLeft.TabIndex = 17;
            this.lMoneyLeft.Text = "Money left";
            // 
            // lClientName
            // 
            this.lClientName.AutoSize = true;
            this.lClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lClientName.Location = new System.Drawing.Point(12, 55);
            this.lClientName.Name = "lClientName";
            this.lClientName.Size = new System.Drawing.Size(90, 21);
            this.lClientName.TabIndex = 16;
            this.lClientName.Text = "Client name";
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(16, 171);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 28);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Cancel";
            this.bCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSubmit.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(257, 171);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 28);
            this.bSubmit.TabIndex = 14;
            this.bSubmit.Text = "Submit";
            this.bSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSubmit.UseVisualStyleBackColor = true;
            // 
            // lDsicountId
            // 
            this.lDsicountId.AutoSize = true;
            this.lDsicountId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDsicountId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lDsicountId.Location = new System.Drawing.Point(12, 19);
            this.lDsicountId.Name = "lDsicountId";
            this.lDsicountId.Size = new System.Drawing.Size(102, 21);
            this.lDsicountId.TabIndex = 12;
            this.lDsicountId.Text = "Discount card";
            // 
            // cbDiscountCard
            // 
            this.cbDiscountCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDiscountCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiscountCard.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiscountCard.FormattingEnabled = true;
            this.cbDiscountCard.Location = new System.Drawing.Point(153, 16);
            this.cbDiscountCard.Name = "cbDiscountCard";
            this.cbDiscountCard.Size = new System.Drawing.Size(121, 29);
            this.cbDiscountCard.TabIndex = 13;
            // 
            // AddDiscountCardToSession
            // 
            this.AcceptButton = this.bSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(345, 216);
            this.ControlBox = false;
            this.Controls.Add(this.bAddMoney);
            this.Controls.Add(this.numUpDAddMoneyOnCard);
            this.Controls.Add(this.cbClientsMoneyLeft);
            this.Controls.Add(this.cbClientName);
            this.Controls.Add(this.lAddMoney);
            this.Controls.Add(this.lMoneyLeft);
            this.Controls.Add(this.lClientName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.lDsicountId);
            this.Controls.Add(this.cbDiscountCard);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiscountCardToSession";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountCardToSession";
            this.Load += new System.EventHandler(this.AddDiscountCardToSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDAddMoneyOnCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddMoney;
        private System.Windows.Forms.NumericUpDown numUpDAddMoneyOnCard;
        private System.Windows.Forms.TextBox cbClientsMoneyLeft;
        private System.Windows.Forms.TextBox cbClientName;
        private System.Windows.Forms.Label lAddMoney;
        private System.Windows.Forms.Label lMoneyLeft;
        private System.Windows.Forms.Label lClientName;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label lDsicountId;
        private System.Windows.Forms.ComboBox cbDiscountCard;
    }
}