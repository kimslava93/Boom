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
            this.tbClientsMoneyLeft = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lAddMoney = new System.Windows.Forms.Label();
            this.lMoneyLeft = new System.Windows.Forms.Label();
            this.lClientName = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.lDsicountId = new System.Windows.Forms.Label();
            this.cbDiscountCard = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bAddMoney
            // 
            this.bAddMoney.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAddMoney.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddMoney.Location = new System.Drawing.Point(153, 121);
            this.bAddMoney.Name = "bAddMoney";
            this.bAddMoney.Size = new System.Drawing.Size(27, 29);
            this.bAddMoney.TabIndex = 22;
            this.bAddMoney.Text = "+";
            this.bAddMoney.UseVisualStyleBackColor = true;
            this.bAddMoney.Click += new System.EventHandler(this.bAddMoney_Click);
            // 
            // tbClientsMoneyLeft
            // 
            this.tbClientsMoneyLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientsMoneyLeft.Location = new System.Drawing.Point(153, 86);
            this.tbClientsMoneyLeft.Name = "tbClientsMoneyLeft";
            this.tbClientsMoneyLeft.ReadOnly = true;
            this.tbClientsMoneyLeft.Size = new System.Drawing.Size(179, 29);
            this.tbClientsMoneyLeft.TabIndex = 20;
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(153, 51);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(179, 29);
            this.tbClientName.TabIndex = 19;
            // 
            // lAddMoney
            // 
            this.lAddMoney.AutoSize = true;
            this.lAddMoney.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lAddMoney.Location = new System.Drawing.Point(12, 125);
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
            this.lMoneyLeft.Location = new System.Drawing.Point(12, 89);
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
            this.lClientName.Location = new System.Drawing.Point(12, 54);
            this.lClientName.Name = "lClientName";
            this.lClientName.Size = new System.Drawing.Size(90, 21);
            this.lClientName.TabIndex = 16;
            this.lClientName.Text = "Client name";
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(12, 171);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 33);
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
            this.bSubmit.Location = new System.Drawing.Point(258, 171);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 33);
            this.bSubmit.TabIndex = 14;
            this.bSubmit.Text = "Submit";
            this.bSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
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
            this.cbDiscountCard.SelectedIndexChanged += new System.EventHandler(this.cbDiscountCard_SelectedIndexChanged);
            // 
            // AddDiscountCardToSession
            // 
            this.AcceptButton = this.bSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(345, 216);
            this.ControlBox = false;
            this.Controls.Add(this.bAddMoney);
            this.Controls.Add(this.tbClientsMoneyLeft);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.lAddMoney);
            this.Controls.Add(this.lMoneyLeft);
            this.Controls.Add(this.lClientName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.lDsicountId);
            this.Controls.Add(this.cbDiscountCard);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiscountCardToSession";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountCardToSession";
            this.Load += new System.EventHandler(this.AddDiscountCardToSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddMoney;
        private System.Windows.Forms.TextBox tbClientsMoneyLeft;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lAddMoney;
        private System.Windows.Forms.Label lMoneyLeft;
        private System.Windows.Forms.Label lClientName;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label lDsicountId;
        private System.Windows.Forms.ComboBox cbDiscountCard;
    }
}