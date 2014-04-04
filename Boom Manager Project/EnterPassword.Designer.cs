namespace Boom_Manager_Project
{
    partial class EnterPassword
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(40, 87);
            this.tbLogin.MaxLength = 40;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ShortcutsEnabled = false;
            this.tbLogin.Size = new System.Drawing.Size(222, 29);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Tag = "";
            this.tbLogin.Text = "Login";
            this.tbLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbLogin_MouseClick);
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // bAccept
            // 
            this.bAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAccept.Location = new System.Drawing.Point(40, 199);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 34);
            this.bAccept.TabIndex = 0;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(187, 199);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 34);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(40, 122);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(222, 29);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseClick);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // EnterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 256);
            this.ControlBox = false;
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 256);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 256);
            this.Name = "EnterPassword";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Password";
            this.Load += new System.EventHandler(this.EnterPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
    }
}