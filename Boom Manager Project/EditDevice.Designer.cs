namespace Boom_Manager_Project
{
    partial class EditDevice
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.numUpdDeviceId = new System.Windows.Forms.NumericUpDown();
            this.mtbIpAddress = new System.Windows.Forms.MaskedTextBox();
            this.lIPaddress = new System.Windows.Forms.Label();
            this.lDeviceId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdDeviceId)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(12, 155);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 31);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(146, 155);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(111, 31);
            this.bApply.TabIndex = 2;
            this.bApply.Text = "Применить";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // numUpdDeviceId
            // 
            this.numUpdDeviceId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdDeviceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdDeviceId.Enabled = false;
            this.numUpdDeviceId.ForeColor = System.Drawing.Color.White;
            this.numUpdDeviceId.Location = new System.Drawing.Point(126, 24);
            this.numUpdDeviceId.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpdDeviceId.Name = "numUpdDeviceId";
            this.numUpdDeviceId.ReadOnly = true;
            this.numUpdDeviceId.Size = new System.Drawing.Size(123, 29);
            this.numUpdDeviceId.TabIndex = 0;
            // 
            // mtbIpAddress
            // 
            this.mtbIpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mtbIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbIpAddress.ForeColor = System.Drawing.Color.White;
            this.mtbIpAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbIpAddress.Location = new System.Drawing.Point(126, 72);
            this.mtbIpAddress.Name = "mtbIpAddress";
            this.mtbIpAddress.ShortcutsEnabled = false;
            this.mtbIpAddress.Size = new System.Drawing.Size(123, 29);
            this.mtbIpAddress.SkipLiterals = false;
            this.mtbIpAddress.TabIndex = 1;
            this.mtbIpAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lIPaddress
            // 
            this.lIPaddress.AutoSize = true;
            this.lIPaddress.ForeColor = System.Drawing.Color.White;
            this.lIPaddress.Location = new System.Drawing.Point(19, 75);
            this.lIPaddress.Name = "lIPaddress";
            this.lIPaddress.Size = new System.Drawing.Size(68, 21);
            this.lIPaddress.TabIndex = 7;
            this.lIPaddress.Text = "IP адрес";
            // 
            // lDeviceId
            // 
            this.lDeviceId.AutoSize = true;
            this.lDeviceId.ForeColor = System.Drawing.Color.White;
            this.lDeviceId.Location = new System.Drawing.Point(19, 26);
            this.lDeviceId.Name = "lDeviceId";
            this.lDeviceId.Size = new System.Drawing.Size(86, 21);
            this.lDeviceId.TabIndex = 6;
            this.lDeviceId.Text = "ID девайса";
            // 
            // EditDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(269, 198);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.numUpdDeviceId);
            this.Controls.Add(this.mtbIpAddress);
            this.Controls.Add(this.lIPaddress);
            this.Controls.Add(this.lDeviceId);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDevice";
            this.Load += new System.EventHandler(this.EditDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdDeviceId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.NumericUpDown numUpdDeviceId;
        private System.Windows.Forms.MaskedTextBox mtbIpAddress;
        private System.Windows.Forms.Label lIPaddress;
        private System.Windows.Forms.Label lDeviceId;
    }
}