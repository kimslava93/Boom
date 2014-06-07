namespace Boom_Manager_Project
{
    partial class DiscountStepsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lFormName = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.dgvDiscountSteps = new System.Windows.Forms.DataGridView();
            this.bCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscountSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // lFormName
            // 
            this.lFormName.AutoSize = true;
            this.lFormName.Location = new System.Drawing.Point(121, 9);
            this.lFormName.Name = "lFormName";
            this.lFormName.Size = new System.Drawing.Size(198, 21);
            this.lFormName.TabIndex = 0;
            this.lFormName.Text = "Менеджер уровней скидок";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.dgvDiscountSteps);
            this.gb.ForeColor = System.Drawing.Color.White;
            this.gb.Location = new System.Drawing.Point(10, 47);
            this.gb.Margin = new System.Windows.Forms.Padding(1);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(422, 305);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Все уровни";
            // 
            // dgvDiscountSteps
            // 
            this.dgvDiscountSteps.AllowUserToAddRows = false;
            this.dgvDiscountSteps.AllowUserToDeleteRows = false;
            this.dgvDiscountSteps.AllowUserToResizeColumns = false;
            this.dgvDiscountSteps.AllowUserToResizeRows = false;
            this.dgvDiscountSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscountSteps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvDiscountSteps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDiscountSteps.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDiscountSteps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscountSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDiscountSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscountSteps.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscountSteps.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiscountSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiscountSteps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscountSteps.EnableHeadersVisualStyles = false;
            this.dgvDiscountSteps.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvDiscountSteps.Location = new System.Drawing.Point(3, 25);
            this.dgvDiscountSteps.MultiSelect = false;
            this.dgvDiscountSteps.Name = "dgvDiscountSteps";
            this.dgvDiscountSteps.ReadOnly = true;
            this.dgvDiscountSteps.RowHeadersVisible = false;
            this.dgvDiscountSteps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDiscountSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDiscountSteps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscountSteps.Size = new System.Drawing.Size(416, 277);
            this.dgvDiscountSteps.TabIndex = 4;
            this.dgvDiscountSteps.TabStop = false;
            this.dgvDiscountSteps.VirtualMode = true;
            // 
            // bCreate
            // 
            this.bCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.ForeColor = System.Drawing.Color.White;
            this.bCreate.Location = new System.Drawing.Point(13, 379);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(96, 38);
            this.bCreate.TabIndex = 1;
            this.bCreate.Text = "Новый";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(125, 379);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(96, 38);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // DiscountStepsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(442, 429);
            this.ControlBox = false;
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lFormName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountStepsManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountStepsManager";
            this.Load += new System.EventHandler(this.DiscountStepsManager_Load);
            this.gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscountSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFormName;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.DataGridView dgvDiscountSteps;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bDelete;
    }
}