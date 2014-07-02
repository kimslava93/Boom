namespace Boom_Manager_Project
{
    partial class AddNewDevice
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
            this.lDeviceId = new System.Windows.Forms.Label();
            this.lIPaddress = new System.Windows.Forms.Label();
            this.mtbIpAddress = new System.Windows.Forms.MaskedTextBox();
            this.numUpdDeviceId = new System.Windows.Forms.NumericUpDown();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdDeviceId)).BeginInit();
            this.SuspendLayout();
            // 
            // lDeviceId
            // 
            this.lDeviceId.AutoSize = true;
            this.lDeviceId.ForeColor = System.Drawing.Color.White;
            this.lDeviceId.Location = new System.Drawing.Point(12, 42);
            this.lDeviceId.Name = "lDeviceId";
            this.lDeviceId.Size = new System.Drawing.Size(85, 21);
            this.lDeviceId.TabIndex = 0;
            this.lDeviceId.Text = "ID девайса";
            // 
            // lIPaddress
            // 
            this.lIPaddress.AutoSize = true;
            this.lIPaddress.ForeColor = System.Drawing.Color.White;
            this.lIPaddress.Location = new System.Drawing.Point(12, 91);
            this.lIPaddress.Name = "lIPaddress";
            this.lIPaddress.Size = new System.Drawing.Size(67, 21);
            this.lIPaddress.TabIndex = 1;
            this.lIPaddress.Text = "IP адрес";
            // 
            // mtbIpAddress
            // 
            this.mtbIpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mtbIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbIpAddress.ForeColor = System.Drawing.Color.White;
            this.mtbIpAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbIpAddress.Location = new System.Drawing.Point(119, 88);
            this.mtbIpAddress.Name = "mtbIpAddress";
            this.mtbIpAddress.ShortcutsEnabled = false;
            this.mtbIpAddress.Size = new System.Drawing.Size(123, 29);
            this.mtbIpAddress.SkipLiterals = false;
            this.mtbIpAddress.TabIndex = 1;
            this.mtbIpAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbIpAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbIpAddress_KeyPress);
            // 
            // numUpdDeviceId
            // 
            this.numUpdDeviceId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdDeviceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdDeviceId.ForeColor = System.Drawing.Color.White;
            this.numUpdDeviceId.Location = new System.Drawing.Point(119, 40);
            this.numUpdDeviceId.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpdDeviceId.Name = "numUpdDeviceId";
            this.numUpdDeviceId.Size = new System.Drawing.Size(123, 29);
            this.numUpdDeviceId.TabIndex = 0;
            // 
            // bCreate
            // 
            this.bCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.ForeColor = System.Drawing.Color.White;
            this.bCreate.Location = new System.Drawing.Point(159, 163);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(83, 31);
            this.bCreate.TabIndex = 2;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
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
            this.bCancel.Location = new System.Drawing.Point(16, 163);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(81, 31);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // AddNewDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(260, 212);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.numUpdDeviceId);
            this.Controls.Add(this.mtbIpAddress);
            this.Controls.Add(this.lIPaddress);
            this.Controls.Add(this.lDeviceId);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewDevice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewDevice";
            this.Load += new System.EventHandler(this.AddNewDevice_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNewDevice_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNewDevice_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddNewDevice_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdDeviceId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDeviceId;
        private System.Windows.Forms.Label lIPaddress;
        private System.Windows.Forms.MaskedTextBox mtbIpAddress;
        private System.Windows.Forms.NumericUpDown numUpdDeviceId;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCancel;
    }
}