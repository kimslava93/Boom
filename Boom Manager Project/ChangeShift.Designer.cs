namespace Boom_Manager_Project
{
    partial class ChangeShift
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
            this.bAcceptShift = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lWarning = new System.Windows.Forms.Label();
            this.gbOutcomingShift = new System.Windows.Forms.GroupBox();
            this.lOutgoingOperator = new System.Windows.Forms.Label();
            this.lOutgoingAdministrator = new System.Windows.Forms.Label();
            this.tbOutOperatorName = new System.Windows.Forms.TextBox();
            this.tbOutAdminName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbInAdminPassword = new System.Windows.Forms.TextBox();
            this.lIncomingAdministrator = new System.Windows.Forms.Label();
            this.tbInAdminLogin = new System.Windows.Forms.TextBox();
            this.bAddNewUser = new System.Windows.Forms.Button();
            this.gbOutcomingShift.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAcceptShift
            // 
            this.bAcceptShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAcceptShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAcceptShift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAcceptShift.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAcceptShift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAcceptShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAcceptShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAcceptShift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAcceptShift.ForeColor = System.Drawing.Color.White;
            this.bAcceptShift.Location = new System.Drawing.Point(352, 286);
            this.bAcceptShift.Name = "bAcceptShift";
            this.bAcceptShift.Size = new System.Drawing.Size(96, 32);
            this.bAcceptShift.TabIndex = 0;
            this.bAcceptShift.Text = "Принять";
            this.bAcceptShift.UseVisualStyleBackColor = false;
            this.bAcceptShift.Click += new System.EventHandler(this.bAcceptShift_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(12, 286);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(86, 32);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.ForeColor = System.Drawing.Color.Red;
            this.lWarning.Location = new System.Drawing.Point(46, 9);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(70, 21);
            this.lWarning.TabIndex = 12;
            this.lWarning.Text = "Warning";
            this.lWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOutcomingShift
            // 
            this.gbOutcomingShift.BackColor = System.Drawing.Color.Transparent;
            this.gbOutcomingShift.Controls.Add(this.lOutgoingOperator);
            this.gbOutcomingShift.Controls.Add(this.lOutgoingAdministrator);
            this.gbOutcomingShift.Controls.Add(this.tbOutOperatorName);
            this.gbOutcomingShift.Controls.Add(this.tbOutAdminName);
            this.gbOutcomingShift.ForeColor = System.Drawing.Color.White;
            this.gbOutcomingShift.Location = new System.Drawing.Point(12, 113);
            this.gbOutcomingShift.Name = "gbOutcomingShift";
            this.gbOutcomingShift.Size = new System.Drawing.Size(199, 164);
            this.gbOutcomingShift.TabIndex = 14;
            this.gbOutcomingShift.TabStop = false;
            this.gbOutcomingShift.Text = "Завершающая смена";
            // 
            // lOutgoingOperator
            // 
            this.lOutgoingOperator.AutoSize = true;
            this.lOutgoingOperator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOutgoingOperator.ForeColor = System.Drawing.Color.White;
            this.lOutgoingOperator.Location = new System.Drawing.Point(12, 95);
            this.lOutgoingOperator.Name = "lOutgoingOperator";
            this.lOutgoingOperator.Size = new System.Drawing.Size(81, 21);
            this.lOutgoingOperator.TabIndex = 9;
            this.lOutgoingOperator.Text = "Оператор";
            // 
            // lOutgoingAdministrator
            // 
            this.lOutgoingAdministrator.AutoSize = true;
            this.lOutgoingAdministrator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOutgoingAdministrator.ForeColor = System.Drawing.Color.White;
            this.lOutgoingAdministrator.Location = new System.Drawing.Point(12, 32);
            this.lOutgoingAdministrator.Name = "lOutgoingAdministrator";
            this.lOutgoingAdministrator.Size = new System.Drawing.Size(123, 21);
            this.lOutgoingAdministrator.TabIndex = 8;
            this.lOutgoingAdministrator.Text = "Администратор";
            // 
            // tbOutOperatorName
            // 
            this.tbOutOperatorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbOutOperatorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutOperatorName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutOperatorName.ForeColor = System.Drawing.Color.White;
            this.tbOutOperatorName.Location = new System.Drawing.Point(16, 119);
            this.tbOutOperatorName.Name = "tbOutOperatorName";
            this.tbOutOperatorName.ReadOnly = true;
            this.tbOutOperatorName.Size = new System.Drawing.Size(157, 29);
            this.tbOutOperatorName.TabIndex = 7;
            this.tbOutOperatorName.Text = "Имя";
            // 
            // tbOutAdminName
            // 
            this.tbOutAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbOutAdminName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutAdminName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutAdminName.ForeColor = System.Drawing.Color.White;
            this.tbOutAdminName.Location = new System.Drawing.Point(16, 56);
            this.tbOutAdminName.Name = "tbOutAdminName";
            this.tbOutAdminName.ReadOnly = true;
            this.tbOutAdminName.Size = new System.Drawing.Size(157, 29);
            this.tbOutAdminName.TabIndex = 6;
            this.tbOutAdminName.Text = "Имя";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbInAdminPassword);
            this.groupBox1.Controls.Add(this.lIncomingAdministrator);
            this.groupBox1.Controls.Add(this.tbInAdminLogin);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(252, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Принимающая смена";
            // 
            // tbInAdminPassword
            // 
            this.tbInAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbInAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInAdminPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInAdminPassword.ForeColor = System.Drawing.Color.White;
            this.tbInAdminPassword.Location = new System.Drawing.Point(10, 92);
            this.tbInAdminPassword.MaxLength = 30;
            this.tbInAdminPassword.Name = "tbInAdminPassword";
            this.tbInAdminPassword.PasswordChar = '*';
            this.tbInAdminPassword.ShortcutsEnabled = false;
            this.tbInAdminPassword.Size = new System.Drawing.Size(157, 29);
            this.tbInAdminPassword.TabIndex = 19;
            this.tbInAdminPassword.Text = "Пароль";
            this.tbInAdminPassword.UseSystemPasswordChar = true;
            this.tbInAdminPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbInAdminPassword_MouseClick);
            // 
            // lIncomingAdministrator
            // 
            this.lIncomingAdministrator.AutoSize = true;
            this.lIncomingAdministrator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncomingAdministrator.ForeColor = System.Drawing.Color.White;
            this.lIncomingAdministrator.Location = new System.Drawing.Point(6, 32);
            this.lIncomingAdministrator.Name = "lIncomingAdministrator";
            this.lIncomingAdministrator.Size = new System.Drawing.Size(123, 21);
            this.lIncomingAdministrator.TabIndex = 16;
            this.lIncomingAdministrator.Text = "Администратор";
            // 
            // tbInAdminLogin
            // 
            this.tbInAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbInAdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInAdminLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInAdminLogin.ForeColor = System.Drawing.Color.White;
            this.tbInAdminLogin.Location = new System.Drawing.Point(10, 56);
            this.tbInAdminLogin.Name = "tbInAdminLogin";
            this.tbInAdminLogin.ShortcutsEnabled = false;
            this.tbInAdminLogin.Size = new System.Drawing.Size(157, 29);
            this.tbInAdminLogin.TabIndex = 14;
            this.tbInAdminLogin.Text = "Логин";
            this.tbInAdminLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbInAdminLogin_MouseClick);
            // 
            // bAddNewUser
            // 
            this.bAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddNewUser.ForeColor = System.Drawing.Color.White;
            this.bAddNewUser.Location = new System.Drawing.Point(406, 76);
            this.bAddNewUser.Name = "bAddNewUser";
            this.bAddNewUser.Size = new System.Drawing.Size(45, 31);
            this.bAddNewUser.TabIndex = 16;
            this.bAddNewUser.Text = "+";
            this.bAddNewUser.UseVisualStyleBackColor = false;
            this.bAddNewUser.Click += new System.EventHandler(this.bAddNewUser_Click);
            // 
            // ChangeShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 330);
            this.ControlBox = false;
            this.Controls.Add(this.bAddNewUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOutcomingShift);
            this.Controls.Add(this.lWarning);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAcceptShift);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeShift";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change shift";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeShift_FormClosing);
            this.Load += new System.EventHandler(this.ChangeShift_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeShift_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeShift_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeShift_MouseUp);
            this.gbOutcomingShift.ResumeLayout(false);
            this.gbOutcomingShift.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAcceptShift;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.GroupBox gbOutcomingShift;
        private System.Windows.Forms.Label lOutgoingOperator;
        private System.Windows.Forms.Label lOutgoingAdministrator;
        private System.Windows.Forms.TextBox tbOutOperatorName;
        private System.Windows.Forms.TextBox tbOutAdminName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbInAdminPassword;
        private System.Windows.Forms.Label lIncomingAdministrator;
        private System.Windows.Forms.TextBox tbInAdminLogin;
        private System.Windows.Forms.Button bAddNewUser;
    }
}