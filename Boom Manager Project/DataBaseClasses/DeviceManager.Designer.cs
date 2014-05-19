namespace Boom_Manager_Project.DataBaseClasses
{
    partial class DeviceManager
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
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllDevices = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAllEndPointsIndexes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDevices)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEndPointsIndexes)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(403, 370);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 34);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(381, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(97, 33);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add device";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAllDevices);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // dgvAllDevices
            // 
            this.dgvAllDevices.AllowUserToAddRows = false;
            this.dgvAllDevices.AllowUserToDeleteRows = false;
            this.dgvAllDevices.AllowUserToResizeColumns = false;
            this.dgvAllDevices.AllowUserToResizeRows = false;
            this.dgvAllDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllDevices.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllDevices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllDevices.EnableHeadersVisualStyles = false;
            this.dgvAllDevices.Location = new System.Drawing.Point(3, 25);
            this.dgvAllDevices.MultiSelect = false;
            this.dgvAllDevices.Name = "dgvAllDevices";
            this.dgvAllDevices.ReadOnly = true;
            this.dgvAllDevices.RowHeadersVisible = false;
            this.dgvAllDevices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllDevices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllDevices.ShowCellErrors = false;
            this.dgvAllDevices.ShowCellToolTips = false;
            this.dgvAllDevices.ShowEditingIcon = false;
            this.dgvAllDevices.ShowRowErrors = false;
            this.dgvAllDevices.Size = new System.Drawing.Size(322, 142);
            this.dgvAllDevices.TabIndex = 2;
            this.dgvAllDevices.VirtualMode = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAllEndPointsIndexes);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EndPoints on device";
            // 
            // dgvAllEndPointsIndexes
            // 
            this.dgvAllEndPointsIndexes.AllowUserToAddRows = false;
            this.dgvAllEndPointsIndexes.AllowUserToDeleteRows = false;
            this.dgvAllEndPointsIndexes.AllowUserToResizeColumns = false;
            this.dgvAllEndPointsIndexes.AllowUserToResizeRows = false;
            this.dgvAllEndPointsIndexes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllEndPointsIndexes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllEndPointsIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEndPointsIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllEndPointsIndexes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllEndPointsIndexes.EnableHeadersVisualStyles = false;
            this.dgvAllEndPointsIndexes.Location = new System.Drawing.Point(3, 25);
            this.dgvAllEndPointsIndexes.MultiSelect = false;
            this.dgvAllEndPointsIndexes.Name = "dgvAllEndPointsIndexes";
            this.dgvAllEndPointsIndexes.ReadOnly = true;
            this.dgvAllEndPointsIndexes.RowHeadersVisible = false;
            this.dgvAllEndPointsIndexes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllEndPointsIndexes.ShowCellErrors = false;
            this.dgvAllEndPointsIndexes.ShowCellToolTips = false;
            this.dgvAllEndPointsIndexes.ShowEditingIcon = false;
            this.dgvAllEndPointsIndexes.ShowRowErrors = false;
            this.dgvAllEndPointsIndexes.Size = new System.Drawing.Size(460, 142);
            this.dgvAllEndPointsIndexes.TabIndex = 2;
            this.dgvAllEndPointsIndexes.VirtualMode = true;
            // 
            // DeviceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(490, 416);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bClose);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device manager";
            this.Load += new System.EventHandler(this.DeviceManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDevices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEndPointsIndexes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAllEndPointsIndexes;

    }
}