namespace Boom_Manager_Project.Controllers
{
    partial class ClientManager
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
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.numUpdBYear = new System.Windows.Forms.NumericUpDown();
            this.numUpdBMonth = new System.Windows.Forms.NumericUpDown();
            this.numUpdBDay = new System.Windows.Forms.NumericUpDown();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.numUpDSavings = new System.Windows.Forms.NumericUpDown();
            this.numUpDDiscount = new System.Windows.Forms.NumericUpDown();
            this.tbPlayedSum = new System.Windows.Forms.TextBox();
            this.tbActivationDate = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.lClientId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lPlayedSum = new System.Windows.Forms.Label();
            this.lPersonalDiscount = new System.Windows.Forms.Label();
            this.lActivationDate = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.gbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdBYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdBMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdBDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSavings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(12, 376);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(110, 37);
            this.bApply.TabIndex = 7;
            this.bApply.Text = "Применить";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(336, 376);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(88, 37);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Controls.Add(this.numUpdBYear);
            this.gbClientInfo.Controls.Add(this.numUpdBMonth);
            this.gbClientInfo.Controls.Add(this.numUpdBDay);
            this.gbClientInfo.Controls.Add(this.tbClientId);
            this.gbClientInfo.Controls.Add(this.numUpDSavings);
            this.gbClientInfo.Controls.Add(this.numUpDDiscount);
            this.gbClientInfo.Controls.Add(this.tbPlayedSum);
            this.gbClientInfo.Controls.Add(this.tbActivationDate);
            this.gbClientInfo.Controls.Add(this.tbEmail);
            this.gbClientInfo.Controls.Add(this.tbPhone);
            this.gbClientInfo.Controls.Add(this.tbName);
            this.gbClientInfo.Controls.Add(this.cbClients);
            this.gbClientInfo.Controls.Add(this.lClientId);
            this.gbClientInfo.Controls.Add(this.label1);
            this.gbClientInfo.Controls.Add(this.lPlayedSum);
            this.gbClientInfo.Controls.Add(this.lPersonalDiscount);
            this.gbClientInfo.Controls.Add(this.lActivationDate);
            this.gbClientInfo.Controls.Add(this.lPhone);
            this.gbClientInfo.Controls.Add(this.lEmail);
            this.gbClientInfo.Controls.Add(this.lBirthday);
            this.gbClientInfo.Controls.Add(this.lName);
            this.gbClientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbClientInfo.ForeColor = System.Drawing.Color.White;
            this.gbClientInfo.Location = new System.Drawing.Point(0, 0);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(435, 362);
            this.gbClientInfo.TabIndex = 28;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Информация о клиенте";
            // 
            // numUpdBYear
            // 
            this.numUpdBYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdBYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdBYear.ForeColor = System.Drawing.Color.White;
            this.numUpdBYear.Location = new System.Drawing.Point(301, 143);
            this.numUpdBYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numUpdBYear.Minimum = new decimal(new int[] {
            1850,
            0,
            0,
            0});
            this.numUpdBYear.Name = "numUpdBYear";
            this.numUpdBYear.Size = new System.Drawing.Size(82, 29);
            this.numUpdBYear.TabIndex = 5;
            this.numUpdBYear.Value = new decimal(new int[] {
            1850,
            0,
            0,
            0});
            // 
            // numUpdBMonth
            // 
            this.numUpdBMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdBMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdBMonth.ForeColor = System.Drawing.Color.White;
            this.numUpdBMonth.Location = new System.Drawing.Point(235, 143);
            this.numUpdBMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpdBMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdBMonth.Name = "numUpdBMonth";
            this.numUpdBMonth.Size = new System.Drawing.Size(60, 29);
            this.numUpdBMonth.TabIndex = 4;
            this.numUpdBMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpdBDay
            // 
            this.numUpdBDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdBDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdBDay.ForeColor = System.Drawing.Color.White;
            this.numUpdBDay.Location = new System.Drawing.Point(169, 143);
            this.numUpdBDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numUpdBDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdBDay.Name = "numUpdBDay";
            this.numUpdBDay.Size = new System.Drawing.Size(60, 29);
            this.numUpdBDay.TabIndex = 3;
            this.numUpdBDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbClientId
            // 
            this.tbClientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClientId.ForeColor = System.Drawing.Color.White;
            this.tbClientId.Location = new System.Drawing.Point(510, 39);
            this.tbClientId.MaxLength = 15;
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(160, 29);
            this.tbClientId.TabIndex = 0;
            // 
            // numUpDSavings
            // 
            this.numUpDSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDSavings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDSavings.Enabled = false;
            this.numUpDSavings.ForeColor = System.Drawing.Color.White;
            this.numUpDSavings.Location = new System.Drawing.Point(169, 318);
            this.numUpDSavings.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDSavings.Name = "numUpDSavings";
            this.numUpDSavings.ReadOnly = true;
            this.numUpDSavings.Size = new System.Drawing.Size(160, 29);
            this.numUpDSavings.TabIndex = 999;
            // 
            // numUpDDiscount
            // 
            this.numUpDDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDDiscount.ForeColor = System.Drawing.Color.White;
            this.numUpDDiscount.Location = new System.Drawing.Point(169, 248);
            this.numUpDDiscount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDDiscount.Name = "numUpDDiscount";
            this.numUpDDiscount.Size = new System.Drawing.Size(160, 29);
            this.numUpDDiscount.TabIndex = 999;
            this.numUpDDiscount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbPlayedSum
            // 
            this.tbPlayedSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbPlayedSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlayedSum.ForeColor = System.Drawing.Color.White;
            this.tbPlayedSum.Location = new System.Drawing.Point(169, 283);
            this.tbPlayedSum.Name = "tbPlayedSum";
            this.tbPlayedSum.ReadOnly = true;
            this.tbPlayedSum.Size = new System.Drawing.Size(160, 29);
            this.tbPlayedSum.TabIndex = 999;
            // 
            // tbActivationDate
            // 
            this.tbActivationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbActivationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActivationDate.ForeColor = System.Drawing.Color.White;
            this.tbActivationDate.Location = new System.Drawing.Point(169, 213);
            this.tbActivationDate.MaxLength = 25;
            this.tbActivationDate.Name = "tbActivationDate";
            this.tbActivationDate.ReadOnly = true;
            this.tbActivationDate.Size = new System.Drawing.Size(160, 29);
            this.tbActivationDate.TabIndex = 999;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(169, 108);
            this.tbEmail.MaxLength = 25;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(241, 29);
            this.tbEmail.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhone.ForeColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(169, 178);
            this.tbPhone.MaxLength = 25;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(160, 29);
            this.tbPhone.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(169, 73);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 29);
            this.tbName.TabIndex = 1;
            // 
            // cbClients
            // 
            this.cbClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClients.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbClients.ForeColor = System.Drawing.Color.White;
            this.cbClients.Location = new System.Drawing.Point(169, 38);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(160, 29);
            this.cbClients.TabIndex = 0;
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.cbClients_SelectedIndexChanged);
            // 
            // lClientId
            // 
            this.lClientId.AutoSize = true;
            this.lClientId.Location = new System.Drawing.Point(8, 41);
            this.lClientId.Name = "lClientId";
            this.lClientId.Size = new System.Drawing.Size(84, 21);
            this.lClientId.TabIndex = 27;
            this.lClientId.Text = "ID клиента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(8, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Денег на карте";
            // 
            // lPlayedSum
            // 
            this.lPlayedSum.AutoSize = true;
            this.lPlayedSum.Location = new System.Drawing.Point(8, 285);
            this.lPlayedSum.Name = "lPlayedSum";
            this.lPlayedSum.Size = new System.Drawing.Size(143, 21);
            this.lPlayedSum.TabIndex = 26;
            this.lPlayedSum.Text = "Наигранныя сумма";
            // 
            // lPersonalDiscount
            // 
            this.lPersonalDiscount.AutoSize = true;
            this.lPersonalDiscount.Location = new System.Drawing.Point(8, 250);
            this.lPersonalDiscount.Name = "lPersonalDiscount";
            this.lPersonalDiscount.Size = new System.Drawing.Size(161, 21);
            this.lPersonalDiscount.TabIndex = 25;
            this.lPersonalDiscount.Text = "Персональная скидка";
            // 
            // lActivationDate
            // 
            this.lActivationDate.AutoSize = true;
            this.lActivationDate.Location = new System.Drawing.Point(8, 215);
            this.lActivationDate.Name = "lActivationDate";
            this.lActivationDate.Size = new System.Drawing.Size(120, 21);
            this.lActivationDate.TabIndex = 28;
            this.lActivationDate.Text = "Дата активации";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(8, 180);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(70, 21);
            this.lPhone.TabIndex = 30;
            this.lPhone.Text = "Телефон";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(8, 110);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(45, 21);
            this.lEmail.TabIndex = 31;
            this.lEmail.Text = "Email";
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Location = new System.Drawing.Point(8, 145);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(120, 21);
            this.lBirthday.TabIndex = 30;
            this.lBirthday.Text = "День рождения";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(8, 75);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 21);
            this.lName.TabIndex = 29;
            this.lName.Text = "Имя";
            // 
            // ClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(435, 425);
            this.ControlBox = false;
            this.Controls.Add(this.gbClientInfo);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientManager";
            this.Load += new System.EventHandler(this.ClientManager_Load);
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdBYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdBMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdBDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSavings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.NumericUpDown numUpDDiscount;
        private System.Windows.Forms.TextBox tbPlayedSum;
        private System.Windows.Forms.TextBox tbActivationDate;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label lClientId;
        private System.Windows.Forms.Label lPlayedSum;
        private System.Windows.Forms.Label lPersonalDiscount;
        private System.Windows.Forms.Label lActivationDate;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.NumericUpDown numUpDSavings;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.NumericUpDown numUpdBYear;
        private System.Windows.Forms.NumericUpDown numUpdBMonth;
        private System.Windows.Forms.NumericUpDown numUpdBDay;

    }
}