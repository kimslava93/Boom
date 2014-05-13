namespace Boom_Manager_Project
{
    partial class AddMoneyOnDiscountCard
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
            this.lID = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lMoneyOnCard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMoneyOnCard = new System.Windows.Forms.TextBox();
            this.numUpDMoneyToAdd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMoneyToAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lID.Location = new System.Drawing.Point(12, 24);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(25, 21);
            this.lID.TabIndex = 0;
            this.lID.Text = "ID";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lName.Location = new System.Drawing.Point(12, 59);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(50, 21);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name";
            // 
            // lMoneyOnCard
            // 
            this.lMoneyOnCard.AutoSize = true;
            this.lMoneyOnCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMoneyOnCard.Location = new System.Drawing.Point(12, 94);
            this.lMoneyOnCard.Name = "lMoneyOnCard";
            this.lMoneyOnCard.Size = new System.Drawing.Size(111, 21);
            this.lMoneyOnCard.TabIndex = 1;
            this.lMoneyOnCard.Text = "Money on card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Money to add";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbID.Location = new System.Drawing.Point(142, 21);
            this.tbID.MaxLength = 5;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 29);
            this.tbID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbName.Location = new System.Drawing.Point(142, 56);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(224, 29);
            this.tbName.TabIndex = 3;
            // 
            // tbMoneyOnCard
            // 
            this.tbMoneyOnCard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMoneyOnCard.Location = new System.Drawing.Point(142, 91);
            this.tbMoneyOnCard.Name = "tbMoneyOnCard";
            this.tbMoneyOnCard.ReadOnly = true;
            this.tbMoneyOnCard.Size = new System.Drawing.Size(224, 29);
            this.tbMoneyOnCard.TabIndex = 4;
            // 
            // numUpDMoneyToAdd
            // 
            this.numUpDMoneyToAdd.Location = new System.Drawing.Point(142, 182);
            this.numUpDMoneyToAdd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDMoneyToAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDMoneyToAdd.Name = "numUpDMoneyToAdd";
            this.numUpDMoneyToAdd.Size = new System.Drawing.Size(100, 29);
            this.numUpDMoneyToAdd.TabIndex = 5;
            this.numUpDMoneyToAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set amount of money for transaction";
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(291, 239);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 40);
            this.bAccept.TabIndex = 7;
            this.bAccept.Text = "Submit";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(12, 239);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 40);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(248, 182);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(29, 29);
            this.bAdd.TabIndex = 9;
            this.bAdd.Text = "+";
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // AddMoneyOnDiscountCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 291);
            this.ControlBox = false;
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDMoneyToAdd);
            this.Controls.Add(this.tbMoneyOnCard);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lMoneyOnCard);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lID);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMoneyOnDiscountCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add money on discount card";
            this.Load += new System.EventHandler(this.AddMoneyOnDiscountCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMoneyToAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lMoneyOnCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMoneyOnCard;
        private System.Windows.Forms.NumericUpDown numUpDMoneyToAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
    }
}