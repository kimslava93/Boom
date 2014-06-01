namespace Boom_Manager_Project
{
    partial class CreateNewConsole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lConsoleName = new System.Windows.Forms.Label();
            this.tbConsoleName = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.gbPriceList = new System.Windows.Forms.GroupBox();
            this.dgvPriceList = new System.Windows.Forms.DataGridView();
            this.bCreateTimeZonePriceList = new System.Windows.Forms.Button();
            this.gbPriceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // lConsoleName
            // 
            this.lConsoleName.AutoSize = true;
            this.lConsoleName.ForeColor = System.Drawing.Color.White;
            this.lConsoleName.Location = new System.Drawing.Point(11, 28);
            this.lConsoleName.Name = "lConsoleName";
            this.lConsoleName.Size = new System.Drawing.Size(154, 21);
            this.lConsoleName.TabIndex = 0;
            this.lConsoleName.Text = "Название приставки";
            // 
            // tbConsoleName
            // 
            this.tbConsoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbConsoleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConsoleName.ForeColor = System.Drawing.Color.White;
            this.tbConsoleName.Location = new System.Drawing.Point(171, 26);
            this.tbConsoleName.MaxLength = 10;
            this.tbConsoleName.Name = "tbConsoleName";
            this.tbConsoleName.Size = new System.Drawing.Size(123, 29);
            this.tbConsoleName.TabIndex = 1;
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
            this.bCreate.Location = new System.Drawing.Point(300, 18);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(87, 40);
            this.bCreate.TabIndex = 2;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // gbPriceList
            // 
            this.gbPriceList.Controls.Add(this.dgvPriceList);
            this.gbPriceList.ForeColor = System.Drawing.Color.White;
            this.gbPriceList.Location = new System.Drawing.Point(12, 103);
            this.gbPriceList.Name = "gbPriceList";
            this.gbPriceList.Size = new System.Drawing.Size(375, 218);
            this.gbPriceList.TabIndex = 3;
            this.gbPriceList.TabStop = false;
            this.gbPriceList.Text = "Прайс лист";
            // 
            // dgvPriceList
            // 
            this.dgvPriceList.AllowUserToAddRows = false;
            this.dgvPriceList.AllowUserToDeleteRows = false;
            this.dgvPriceList.AllowUserToResizeColumns = false;
            this.dgvPriceList.AllowUserToResizeRows = false;
            this.dgvPriceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPriceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPriceList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPriceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPriceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPriceList.EnableHeadersVisualStyles = false;
            this.dgvPriceList.Location = new System.Drawing.Point(3, 25);
            this.dgvPriceList.Name = "dgvPriceList";
            this.dgvPriceList.RowHeadersVisible = false;
            this.dgvPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceList.ShowCellErrors = false;
            this.dgvPriceList.ShowCellToolTips = false;
            this.dgvPriceList.ShowEditingIcon = false;
            this.dgvPriceList.ShowRowErrors = false;
            this.dgvPriceList.Size = new System.Drawing.Size(369, 190);
            this.dgvPriceList.TabIndex = 0;
            this.dgvPriceList.VirtualMode = true;
            this.dgvPriceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriceList_CellClick);
            // 
            // bCreateTimeZonePriceList
            // 
            this.bCreateTimeZonePriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreateTimeZonePriceList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreateTimeZonePriceList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreateTimeZonePriceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCreateTimeZonePriceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreateTimeZonePriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateTimeZonePriceList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateTimeZonePriceList.ForeColor = System.Drawing.Color.White;
            this.bCreateTimeZonePriceList.Location = new System.Drawing.Point(146, 327);
            this.bCreateTimeZonePriceList.Name = "bCreateTimeZonePriceList";
            this.bCreateTimeZonePriceList.Size = new System.Drawing.Size(88, 40);
            this.bCreateTimeZonePriceList.TabIndex = 4;
            this.bCreateTimeZonePriceList.Text = "Создать";
            this.bCreateTimeZonePriceList.UseVisualStyleBackColor = false;
            this.bCreateTimeZonePriceList.Click += new System.EventHandler(this.bApply_Click);
            // 
            // CreateNewConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(399, 81);
            this.ControlBox = false;
            this.Controls.Add(this.bCreateTimeZonePriceList);
            this.Controls.Add(this.gbPriceList);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbConsoleName);
            this.Controls.Add(this.lConsoleName);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewConsole";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new console";
            this.Load += new System.EventHandler(this.CreateNewConsole_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateNewConsole_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateNewConsole_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateNewConsole_MouseUp);
            this.gbPriceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lConsoleName;
        private System.Windows.Forms.TextBox tbConsoleName;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.GroupBox gbPriceList;
        private System.Windows.Forms.DataGridView dgvPriceList;
        private System.Windows.Forms.Button bCreateTimeZonePriceList;
    }
}