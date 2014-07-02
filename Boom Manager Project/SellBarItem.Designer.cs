namespace Boom_Manager_Project
{
    partial class SellBarItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllItems = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.bSell = new System.Windows.Forms.Button();
            this.numUpDNumber = new System.Windows.Forms.NumericUpDown();
            this.lSum = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllItems
            // 
            this.dgvAllItems.AllowUserToAddRows = false;
            this.dgvAllItems.AllowUserToDeleteRows = false;
            this.dgvAllItems.AllowUserToResizeColumns = false;
            this.dgvAllItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dgvAllItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvAllItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAllItems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAllItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllItems.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAllItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllItems.EnableHeadersVisualStyles = false;
            this.dgvAllItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvAllItems.Location = new System.Drawing.Point(0, 0);
            this.dgvAllItems.MultiSelect = false;
            this.dgvAllItems.Name = "dgvAllItems";
            this.dgvAllItems.ReadOnly = true;
            this.dgvAllItems.RowHeadersVisible = false;
            this.dgvAllItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dgvAllItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllItems.Size = new System.Drawing.Size(445, 644);
            this.dgvAllItems.TabIndex = 5;
            this.dgvAllItems.TabStop = false;
            this.dgvAllItems.VirtualMode = true;
            this.dgvAllItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllItems_CellClick);
            this.dgvAllItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAllItems_KeyDown);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(451, 594);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(106, 38);
            this.bClose.TabIndex = 6;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSell
            // 
            this.bSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSell.ForeColor = System.Drawing.Color.White;
            this.bSell.Location = new System.Drawing.Point(451, 349);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(106, 38);
            this.bSell.TabIndex = 6;
            this.bSell.Text = "Продать";
            this.bSell.UseVisualStyleBackColor = false;
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // numUpDNumber
            // 
            this.numUpDNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUpDNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDNumber.ForeColor = System.Drawing.Color.White;
            this.numUpDNumber.Location = new System.Drawing.Point(452, 232);
            this.numUpDNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDNumber.Name = "numUpDNumber";
            this.numUpDNumber.Size = new System.Drawing.Size(105, 31);
            this.numUpDNumber.TabIndex = 7;
            this.numUpDNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDNumber.ValueChanged += new System.EventHandler(this.numUpDNumber_ValueChanged);
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSum.Location = new System.Drawing.Point(451, 266);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(73, 25);
            this.lSum.TabIndex = 8;
            this.lSum.Text = "ИТОГО";
            // 
            // tbSum
            // 
            this.tbSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSum.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSum.ForeColor = System.Drawing.Color.White;
            this.tbSum.Location = new System.Drawing.Point(451, 294);
            this.tbSum.MaxLength = 5;
            this.tbSum.Name = "tbSum";
            this.tbSum.ReadOnly = true;
            this.tbSum.ShortcutsEnabled = false;
            this.tbSum.Size = new System.Drawing.Size(106, 33);
            this.tbSum.TabIndex = 9;
            this.tbSum.Text = "0";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNumber.Location = new System.Drawing.Point(451, 204);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(83, 25);
            this.lNumber.TabIndex = 8;
            this.lNumber.Text = "КОЛ-ВО";
            // 
            // SellBarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(570, 644);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.lSum);
            this.Controls.Add(this.numUpDNumber);
            this.Controls.Add(this.bSell);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dgvAllItems);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellBarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellBarItem";
            this.Load += new System.EventHandler(this.SellBarItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllItems;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.NumericUpDown numUpDNumber;
        private System.Windows.Forms.Label lSum;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label lNumber;
    }
}