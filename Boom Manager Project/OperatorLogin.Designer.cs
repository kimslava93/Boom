namespace Boom_Manager_Project
{
    partial class OperatorLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInOperatorPassword = new System.Windows.Forms.TextBox();
            this.tbInOperatorLogin = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAcceptShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЛОГИН ОПЕРАТОРА";
            // 
            // tbInOperatorPassword
            // 
            this.tbInOperatorPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbInOperatorPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInOperatorPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInOperatorPassword.ForeColor = System.Drawing.Color.White;
            this.tbInOperatorPassword.Location = new System.Drawing.Point(70, 79);
            this.tbInOperatorPassword.MaxLength = 30;
            this.tbInOperatorPassword.Name = "tbInOperatorPassword";
            this.tbInOperatorPassword.PasswordChar = '*';
            this.tbInOperatorPassword.ShortcutsEnabled = false;
            this.tbInOperatorPassword.Size = new System.Drawing.Size(150, 29);
            this.tbInOperatorPassword.TabIndex = 21;
            this.tbInOperatorPassword.Text = "Пароль";
            this.tbInOperatorPassword.UseSystemPasswordChar = true;
            // 
            // tbInOperatorLogin
            // 
            this.tbInOperatorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbInOperatorLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInOperatorLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInOperatorLogin.ForeColor = System.Drawing.Color.White;
            this.tbInOperatorLogin.Location = new System.Drawing.Point(70, 43);
            this.tbInOperatorLogin.Name = "tbInOperatorLogin";
            this.tbInOperatorLogin.ShortcutsEnabled = false;
            this.tbInOperatorLogin.Size = new System.Drawing.Size(150, 29);
            this.tbInOperatorLogin.TabIndex = 20;
            this.tbInOperatorLogin.Text = "Логин";
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
            this.bCancel.Location = new System.Drawing.Point(12, 131);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(86, 32);
            this.bCancel.TabIndex = 23;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
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
            this.bAcceptShift.Location = new System.Drawing.Point(176, 131);
            this.bAcceptShift.Name = "bAcceptShift";
            this.bAcceptShift.Size = new System.Drawing.Size(96, 32);
            this.bAcceptShift.TabIndex = 22;
            this.bAcceptShift.Text = "Принять";
            this.bAcceptShift.UseVisualStyleBackColor = false;
            this.bAcceptShift.Click += new System.EventHandler(this.bAcceptShift_Click);
            // 
            // OperatorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAcceptShift);
            this.Controls.Add(this.tbInOperatorPassword);
            this.Controls.Add(this.tbInOperatorLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperatorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInOperatorPassword;
        private System.Windows.Forms.TextBox tbInOperatorLogin;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAcceptShift;
    }
}