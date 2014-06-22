namespace Boom_Manager_Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllDevices = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAllEndPointsIndexes = new System.Windows.Forms.DataGridView();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDevices)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEndPointsIndexes)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(381, 370);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(97, 34);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(372, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(106, 62);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Добавить девайс";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAllDevices);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Девайсы";
            // 
            // dgvAllDevices
            // 
            this.dgvAllDevices.AllowUserToAddRows = false;
            this.dgvAllDevices.AllowUserToDeleteRows = false;
            this.dgvAllDevices.AllowUserToResizeColumns = false;
            this.dgvAllDevices.AllowUserToResizeRows = false;
            this.dgvAllDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllDevices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAllDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllDevices.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAllDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllDevices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllDevices.EnableHeadersVisualStyles = false;
            this.dgvAllDevices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Розетки на текущем девайсе";
            // 
            // dgvAllEndPointsIndexes
            // 
            this.dgvAllEndPointsIndexes.AllowUserToAddRows = false;
            this.dgvAllEndPointsIndexes.AllowUserToDeleteRows = false;
            this.dgvAllEndPointsIndexes.AllowUserToResizeColumns = false;
            this.dgvAllEndPointsIndexes.AllowUserToResizeRows = false;
            this.dgvAllEndPointsIndexes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllEndPointsIndexes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllEndPointsIndexes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAllEndPointsIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllEndPointsIndexes.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAllEndPointsIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllEndPointsIndexes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllEndPointsIndexes.EnableHeadersVisualStyles = false;
            this.dgvAllEndPointsIndexes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            this.dgvAllEndPointsIndexes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllEndPointsIndexes_CellClick);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(372, 146);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(106, 33);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.Location = new System.Drawing.Point(369, 89);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(106, 33);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // DeviceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(490, 416);
            this.ControlBox = false;
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bClose);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device manager";
            this.Load += new System.EventHandler(this.DeviceManager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeviceManager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeviceManager_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DeviceManager_MouseUp);
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
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;

    }
}