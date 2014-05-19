namespace Boom_Manager_Project.Controllers
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
            this.lDeviceId.Location = new System.Drawing.Point(12, 42);
            this.lDeviceId.Name = "lDeviceId";
            this.lDeviceId.Size = new System.Drawing.Size(73, 21);
            this.lDeviceId.TabIndex = 0;
            this.lDeviceId.Text = "Device ID";
            // 
            // lIPaddress
            // 
            this.lIPaddress.AutoSize = true;
            this.lIPaddress.Location = new System.Drawing.Point(12, 91);
            this.lIPaddress.Name = "lIPaddress";
            this.lIPaddress.Size = new System.Drawing.Size(78, 21);
            this.lIPaddress.TabIndex = 1;
            this.lIPaddress.Text = "IP address";
            // 
            // mtbIpAddress
            // 
            this.mtbIpAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbIpAddress.Location = new System.Drawing.Point(119, 88);
            this.mtbIpAddress.Name = "mtbIpAddress";
            this.mtbIpAddress.ShortcutsEnabled = false;
            this.mtbIpAddress.Size = new System.Drawing.Size(123, 29);
            this.mtbIpAddress.SkipLiterals = false;
            this.mtbIpAddress.TabIndex = 2;
            this.mtbIpAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbIpAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbIpAddress_KeyPress);
            // 
            // numUpdDeviceId
            // 
            this.numUpdDeviceId.Location = new System.Drawing.Point(119, 40);
            this.numUpdDeviceId.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpdDeviceId.Name = "numUpdDeviceId";
            this.numUpdDeviceId.Size = new System.Drawing.Size(123, 29);
            this.numUpdDeviceId.TabIndex = 3;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(165, 163);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(77, 31);
            this.bCreate.TabIndex = 4;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(16, 163);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(77, 31);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // AddNewDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(260, 212);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.numUpdDeviceId);
            this.Controls.Add(this.mtbIpAddress);
            this.Controls.Add(this.lIPaddress);
            this.Controls.Add(this.lDeviceId);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewDevice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewDevice";
            this.Load += new System.EventHandler(this.AddNewDevice_Load);
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