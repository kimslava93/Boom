﻿namespace Boom_Manager_Project
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
            this.bAcceptShift.Location = new System.Drawing.Point(323, 248);
            this.bAcceptShift.Name = "bAcceptShift";
            this.bAcceptShift.Size = new System.Drawing.Size(78, 32);
            this.bAcceptShift.TabIndex = 0;
            this.bAcceptShift.Text = "Accept shift";
            this.bAcceptShift.UseVisualStyleBackColor = true;
            this.bAcceptShift.Click += new System.EventHandler(this.bAcceptShift_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(53, 248);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(86, 32);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.ForeColor = System.Drawing.Color.Red;
            this.lWarning.Location = new System.Drawing.Point(60, 9);
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
            this.gbOutcomingShift.Location = new System.Drawing.Point(12, 75);
            this.gbOutcomingShift.Name = "gbOutcomingShift";
            this.gbOutcomingShift.Size = new System.Drawing.Size(185, 164);
            this.gbOutcomingShift.TabIndex = 14;
            this.gbOutcomingShift.TabStop = false;
            this.gbOutcomingShift.Text = "Finishing shift";
            // 
            // lOutgoingOperator
            // 
            this.lOutgoingOperator.AutoSize = true;
            this.lOutgoingOperator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOutgoingOperator.Location = new System.Drawing.Point(12, 95);
            this.lOutgoingOperator.Name = "lOutgoingOperator";
            this.lOutgoingOperator.Size = new System.Drawing.Size(73, 21);
            this.lOutgoingOperator.TabIndex = 9;
            this.lOutgoingOperator.Text = "Operator";
            // 
            // lOutgoingAdministrator
            // 
            this.lOutgoingAdministrator.AutoSize = true;
            this.lOutgoingAdministrator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOutgoingAdministrator.Location = new System.Drawing.Point(12, 32);
            this.lOutgoingAdministrator.Name = "lOutgoingAdministrator";
            this.lOutgoingAdministrator.Size = new System.Drawing.Size(106, 21);
            this.lOutgoingAdministrator.TabIndex = 8;
            this.lOutgoingAdministrator.Text = "Administrator";
            // 
            // tbOutOperatorName
            // 
            this.tbOutOperatorName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutOperatorName.Location = new System.Drawing.Point(16, 119);
            this.tbOutOperatorName.Name = "tbOutOperatorName";
            this.tbOutOperatorName.ReadOnly = true;
            this.tbOutOperatorName.Size = new System.Drawing.Size(157, 29);
            this.tbOutOperatorName.TabIndex = 7;
            this.tbOutOperatorName.Text = "Name";
            // 
            // tbOutAdminName
            // 
            this.tbOutAdminName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutAdminName.Location = new System.Drawing.Point(16, 56);
            this.tbOutAdminName.Name = "tbOutAdminName";
            this.tbOutAdminName.ReadOnly = true;
            this.tbOutAdminName.Size = new System.Drawing.Size(157, 29);
            this.tbOutAdminName.TabIndex = 6;
            this.tbOutAdminName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbInAdminPassword);
            this.groupBox1.Controls.Add(this.lIncomingAdministrator);
            this.groupBox1.Controls.Add(this.tbInAdminLogin);
            this.groupBox1.Location = new System.Drawing.Point(263, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starting shift";
            // 
            // tbInAdminPassword
            // 
            this.tbInAdminPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInAdminPassword.Location = new System.Drawing.Point(10, 92);
            this.tbInAdminPassword.MaxLength = 30;
            this.tbInAdminPassword.Name = "tbInAdminPassword";
            this.tbInAdminPassword.PasswordChar = '*';
            this.tbInAdminPassword.ShortcutsEnabled = false;
            this.tbInAdminPassword.Size = new System.Drawing.Size(157, 29);
            this.tbInAdminPassword.TabIndex = 19;
            this.tbInAdminPassword.Text = "Password";
            this.tbInAdminPassword.UseSystemPasswordChar = true;
            this.tbInAdminPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbInAdminPassword_MouseClick);
            // 
            // lIncomingAdministrator
            // 
            this.lIncomingAdministrator.AutoSize = true;
            this.lIncomingAdministrator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncomingAdministrator.Location = new System.Drawing.Point(6, 32);
            this.lIncomingAdministrator.Name = "lIncomingAdministrator";
            this.lIncomingAdministrator.Size = new System.Drawing.Size(106, 21);
            this.lIncomingAdministrator.TabIndex = 16;
            this.lIncomingAdministrator.Text = "Administrator";
            // 
            // tbInAdminLogin
            // 
            this.tbInAdminLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInAdminLogin.Location = new System.Drawing.Point(10, 56);
            this.tbInAdminLogin.Name = "tbInAdminLogin";
            this.tbInAdminLogin.ShortcutsEnabled = false;
            this.tbInAdminLogin.Size = new System.Drawing.Size(157, 29);
            this.tbInAdminLogin.TabIndex = 14;
            this.tbInAdminLogin.Text = "Login";
            this.tbInAdminLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbInAdminLogin_MouseClick);
            // 
            // bAddNewUser
            // 
            this.bAddNewUser.Location = new System.Drawing.Point(403, 51);
            this.bAddNewUser.Name = "bAddNewUser";
            this.bAddNewUser.Size = new System.Drawing.Size(45, 31);
            this.bAddNewUser.TabIndex = 16;
            this.bAddNewUser.Text = "+";
            this.bAddNewUser.UseVisualStyleBackColor = true;
            this.bAddNewUser.Click += new System.EventHandler(this.bAddNewUser_Click);
            // 
            // ChangeShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 292);
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