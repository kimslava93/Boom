namespace Boom_Manager_Project
{
    partial class AddNewStaffUser
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
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.bSubmit = new System.Windows.Forms.Button();
            this.lSalaryPerDay = new System.Windows.Forms.Label();
            this.lHomeAddress = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lAdditionalPhone = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lPosition = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lPersonId = new System.Windows.Forms.Label();
            this.tbHomeAddress = new System.Windows.Forms.TextBox();
            this.tbAdditionalPhone = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPersonId = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.numUpDSalary = new System.Windows.Forms.NumericUpDown();
            this.bCancel = new System.Windows.Forms.Button();
            this.ltext = new System.Windows.Forms.Label();
            this.lRegistrationDate = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(163, 310);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(187, 29);
            this.dtpBirthday.TabIndex = 45;
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSubmit.Location = new System.Drawing.Point(32, 474);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 37);
            this.bSubmit.TabIndex = 44;
            this.bSubmit.Text = "Create";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // lSalaryPerDay
            // 
            this.lSalaryPerDay.AutoSize = true;
            this.lSalaryPerDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSalaryPerDay.Location = new System.Drawing.Point(27, 383);
            this.lSalaryPerDay.Name = "lSalaryPerDay";
            this.lSalaryPerDay.Size = new System.Drawing.Size(109, 21);
            this.lSalaryPerDay.TabIndex = 38;
            this.lSalaryPerDay.Text = "Salary per day";
            // 
            // lHomeAddress
            // 
            this.lHomeAddress.AutoSize = true;
            this.lHomeAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHomeAddress.Location = new System.Drawing.Point(27, 348);
            this.lHomeAddress.Name = "lHomeAddress";
            this.lHomeAddress.Size = new System.Drawing.Size(110, 21);
            this.lHomeAddress.TabIndex = 39;
            this.lHomeAddress.Text = "Home address";
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBirthday.Location = new System.Drawing.Point(27, 316);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(68, 21);
            this.lBirthday.TabIndex = 36;
            this.lBirthday.Text = "Birthday";
            // 
            // lAdditionalPhone
            // 
            this.lAdditionalPhone.AutoSize = true;
            this.lAdditionalPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAdditionalPhone.Location = new System.Drawing.Point(27, 278);
            this.lAdditionalPhone.Name = "lAdditionalPhone";
            this.lAdditionalPhone.Size = new System.Drawing.Size(129, 21);
            this.lAdditionalPhone.TabIndex = 37;
            this.lAdditionalPhone.Text = "Additional phone";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPhone.Location = new System.Drawing.Point(28, 243);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(54, 21);
            this.lPhone.TabIndex = 42;
            this.lPhone.Text = "Phone";
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPosition.Location = new System.Drawing.Point(29, 208);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(66, 21);
            this.lPosition.TabIndex = 43;
            this.lPosition.Text = "Position";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPassword.Location = new System.Drawing.Point(27, 175);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(77, 21);
            this.lPassword.TabIndex = 40;
            this.lPassword.Text = "Password";
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLogin.Location = new System.Drawing.Point(27, 138);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(49, 21);
            this.lLogin.TabIndex = 41;
            this.lLogin.Text = "Login";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(27, 103);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(52, 21);
            this.lName.TabIndex = 35;
            this.lName.Text = "Name";
            // 
            // lPersonId
            // 
            this.lPersonId.AutoSize = true;
            this.lPersonId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPersonId.Location = new System.Drawing.Point(28, 68);
            this.lPersonId.Name = "lPersonId";
            this.lPersonId.Size = new System.Drawing.Size(77, 21);
            this.lPersonId.TabIndex = 34;
            this.lPersonId.Text = "Person ID";
            // 
            // tbHomeAddress
            // 
            this.tbHomeAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHomeAddress.Location = new System.Drawing.Point(163, 345);
            this.tbHomeAddress.MaxLength = 30;
            this.tbHomeAddress.Name = "tbHomeAddress";
            this.tbHomeAddress.Size = new System.Drawing.Size(187, 29);
            this.tbHomeAddress.TabIndex = 28;
            // 
            // tbAdditionalPhone
            // 
            this.tbAdditionalPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdditionalPhone.Location = new System.Drawing.Point(163, 275);
            this.tbAdditionalPhone.MaxLength = 25;
            this.tbAdditionalPhone.Name = "tbAdditionalPhone";
            this.tbAdditionalPhone.Size = new System.Drawing.Size(187, 29);
            this.tbAdditionalPhone.TabIndex = 25;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(163, 240);
            this.tbPhone.MaxLength = 25;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(187, 29);
            this.tbPhone.TabIndex = 26;
            // 
            // tbPassword
            // 
            this.tbPassword.CausesValidation = false;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.HideSelection = false;
            this.tbPassword.Location = new System.Drawing.Point(163, 170);
            this.tbPassword.MaxLength = 25;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ShortcutsEnabled = false;
            this.tbPassword.Size = new System.Drawing.Size(187, 29);
            this.tbPassword.TabIndex = 32;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(163, 135);
            this.tbLogin.MaxLength = 15;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(187, 29);
            this.tbLogin.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(163, 100);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(187, 29);
            this.tbName.TabIndex = 30;
            // 
            // tbPersonId
            // 
            this.tbPersonId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPersonId.Location = new System.Drawing.Point(163, 65);
            this.tbPersonId.MaxLength = 10;
            this.tbPersonId.Name = "tbPersonId";
            this.tbPersonId.Size = new System.Drawing.Size(187, 29);
            this.tbPersonId.TabIndex = 31;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "ADMINISTRATOR",
            "OPERATOR",
            "MANAGER"});
            this.cbPosition.Location = new System.Drawing.Point(163, 205);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(187, 29);
            this.cbPosition.TabIndex = 46;
            // 
            // numUpDSalary
            // 
            this.numUpDSalary.Location = new System.Drawing.Point(163, 381);
            this.numUpDSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDSalary.Name = "numUpDSalary";
            this.numUpDSalary.Size = new System.Drawing.Size(187, 29);
            this.numUpDSalary.TabIndex = 47;
            this.numUpDSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDSalary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(265, 474);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 37);
            this.bCancel.TabIndex = 48;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // ltext
            // 
            this.ltext.AutoSize = true;
            this.ltext.Location = new System.Drawing.Point(182, 9);
            this.ltext.Name = "ltext";
            this.ltext.Size = new System.Drawing.Size(42, 21);
            this.ltext.TabIndex = 49;
            this.ltext.Text = "lText";
            this.ltext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRegistrationDate
            // 
            this.lRegistrationDate.AutoSize = true;
            this.lRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRegistrationDate.Location = new System.Drawing.Point(27, 422);
            this.lRegistrationDate.Name = "lRegistrationDate";
            this.lRegistrationDate.Size = new System.Drawing.Size(135, 21);
            this.lRegistrationDate.TabIndex = 36;
            this.lRegistrationDate.Text = "Registarttion Date";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(163, 416);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(187, 29);
            this.dtpRegistrationDate.TabIndex = 45;
            // 
            // AddNewStaffUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(386, 523);
            this.ControlBox = false;
            this.Controls.Add(this.ltext);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.numUpDSalary);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.lSalaryPerDay);
            this.Controls.Add(this.lHomeAddress);
            this.Controls.Add(this.lRegistrationDate);
            this.Controls.Add(this.lBirthday);
            this.Controls.Add(this.lAdditionalPhone);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lPosition);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lPersonId);
            this.Controls.Add(this.tbHomeAddress);
            this.Controls.Add(this.tbAdditionalPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPersonId);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewStaffUser";
            this.ShowIcon = false;
            this.Text = "Create a new user";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label lSalaryPerDay;
        private System.Windows.Forms.Label lHomeAddress;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lAdditionalPhone;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPersonId;
        private System.Windows.Forms.TextBox tbHomeAddress;
        private System.Windows.Forms.TextBox tbAdditionalPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPersonId;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.NumericUpDown numUpDSalary;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label ltext;
        private System.Windows.Forms.Label lRegistrationDate;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
    }
}