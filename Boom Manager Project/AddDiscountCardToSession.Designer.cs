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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddMoney
            // 
            this.bAddMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddMoney.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAddMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddMoney.ForeColor = System.Drawing.Color.White;
            this.bAddMoney.Location = new System.Drawing.Point(147, 135);
            this.bAddMoney.Name = "bAddMoney";
            this.bAddMoney.Size = new System.Drawing.Size(59, 33);
            this.bAddMoney.TabIndex = 22;
            this.bAddMoney.Text = "ADD";
            this.bAddMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddMoney.UseVisualStyleBackColor = false;
            this.bAddMoney.Click += new System.EventHandler(this.bAddMoney_Click);
            // 
            // tbClientsMoneyLeft
            // 
            this.tbClientsMoneyLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbClientsMoneyLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClientsMoneyLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientsMoneyLeft.ForeColor = System.Drawing.Color.White;
            this.tbClientsMoneyLeft.Location = new System.Drawing.Point(147, 101);
            this.tbClientsMoneyLeft.Name = "tbClientsMoneyLeft";
            this.tbClientsMoneyLeft.ReadOnly = true;
            this.tbClientsMoneyLeft.Size = new System.Drawing.Size(179, 29);
            this.tbClientsMoneyLeft.TabIndex = 20;
            this.tbClientsMoneyLeft.TextChanged += new System.EventHandler(this.tbClientsMoneyLeft_TextChanged);
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.ForeColor = System.Drawing.Color.White;
            this.tbClientName.Location = new System.Drawing.Point(147, 66);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(179, 29);
            this.tbClientName.TabIndex = 19;
            this.tbClientName.TextChanged += new System.EventHandler(this.tbClientName_TextChanged);
            // 
            // lAddMoney
            // 
            this.lAddMoney.AutoSize = true;
            this.lAddMoney.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddMoney.ForeColor = System.Drawing.Color.White;
            this.lAddMoney.Location = new System.Drawing.Point(6, 140);
            this.lAddMoney.Name = "lAddMoney";
            this.lAddMoney.Size = new System.Drawing.Size(88, 21);
            this.lAddMoney.TabIndex = 18;
            this.lAddMoney.Text = "Add money";
            this.lAddMoney.Click += new System.EventHandler(this.lAddMoney_Click);
            // 
            // lMoneyLeft
            // 
            this.lMoneyLeft.AutoSize = true;
            this.lMoneyLeft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMoneyLeft.ForeColor = System.Drawing.Color.White;
            this.lMoneyLeft.Location = new System.Drawing.Point(6, 104);
            this.lMoneyLeft.Name = "lMoneyLeft";
            this.lMoneyLeft.Size = new System.Drawing.Size(80, 21);
            this.lMoneyLeft.TabIndex = 17;
            this.lMoneyLeft.Text = "Money left";
            this.lMoneyLeft.Click += new System.EventHandler(this.lMoneyLeft_Click);
            // 
            // lClientName
            // 
            this.lClientName.AutoSize = true;
            this.lClientName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClientName.ForeColor = System.Drawing.Color.White;
            this.lClientName.Location = new System.Drawing.Point(6, 69);
            this.lClientName.Name = "lClientName";
            this.lClientName.Size = new System.Drawing.Size(90, 21);
            this.lClientName.TabIndex = 16;
            this.lClientName.Text = "Client name";
            this.lClientName.Click += new System.EventHandler(this.lClientName_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(10, 186);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 33);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Cancel";
            this.bCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.bCancel.MouseLeave += new System.EventHandler(this.bCancel_MouseLeave);
            this.bCancel.MouseHover += new System.EventHandler(this.bCancel_MouseHover);
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSubmit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSubmit.ForeColor = System.Drawing.Color.White;
            this.bSubmit.Location = new System.Drawing.Point(252, 186);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 33);
            this.bSubmit.TabIndex = 14;
            this.bSubmit.Text = "Submit";
            this.bSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // lDsicountId
            // 
            this.lDsicountId.AutoSize = true;
            this.lDsicountId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDsicountId.ForeColor = System.Drawing.Color.White;
            this.lDsicountId.Location = new System.Drawing.Point(6, 34);
            this.lDsicountId.Name = "lDsicountId";
            this.lDsicountId.Size = new System.Drawing.Size(102, 21);
            this.lDsicountId.TabIndex = 12;
            this.lDsicountId.Text = "Discount card";
            this.lDsicountId.Click += new System.EventHandler(this.lDsicountId_Click);
            // 
            // cbDiscountCard
            // 
            this.cbDiscountCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDiscountCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiscountCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbDiscountCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDiscountCard.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiscountCard.ForeColor = System.Drawing.Color.White;
            this.cbDiscountCard.FormattingEnabled = true;
            this.cbDiscountCard.Location = new System.Drawing.Point(147, 31);
            this.cbDiscountCard.Name = "cbDiscountCard";
            this.cbDiscountCard.Size = new System.Drawing.Size(121, 29);
            this.cbDiscountCard.TabIndex = 13;
            this.cbDiscountCard.SelectedIndexChanged += new System.EventHandler(this.cbDiscountCard_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lDsicountId);
            this.groupBox1.Controls.Add(this.bAddMoney);
            this.groupBox1.Controls.Add(this.cbDiscountCard);
            this.groupBox1.Controls.Add(this.tbClientsMoneyLeft);
            this.groupBox1.Controls.Add(this.bSubmit);
            this.groupBox1.Controls.Add(this.tbClientName);
            this.groupBox1.Controls.Add(this.bCancel);
            this.groupBox1.Controls.Add(this.lAddMoney);
            this.groupBox1.Controls.Add(this.lClientName);
            this.groupBox1.Controls.Add(this.lMoneyLeft);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 242);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "ADD DISCOUNT  TO SESSION";
            // 
            // AddDiscountCardToSession
            // 
            this.AcceptButton = this.bSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(377, 274);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiscountCardToSession";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountCardToSession";
            this.Load += new System.EventHandler(this.AddDiscountCardToSession_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddDiscountCardToSession_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddDiscountCardToSession_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddDiscountCardToSession_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}