namespace Boom_Manager_Project
{
    partial class AddNewItem
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
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.lCategory = new System.Windows.Forms.Label();
            this.numUpDCost = new System.Windows.Forms.NumericUpDown();
            this.lCost = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.bAddItem = new System.Windows.Forms.Button();
            this.bCancell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lItemName = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCost)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCategoryName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCategoryName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCategoryName.ForeColor = System.Drawing.Color.White;
            this.tbCategoryName.Location = new System.Drawing.Point(183, 53);
            this.tbCategoryName.MaxLength = 50;
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.ShortcutsEnabled = false;
            this.tbCategoryName.Size = new System.Drawing.Size(148, 29);
            this.tbCategoryName.TabIndex = 0;
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategory.ForeColor = System.Drawing.Color.White;
            this.lCategory.Location = new System.Drawing.Point(12, 55);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(80, 21);
            this.lCategory.TabIndex = 28;
            this.lCategory.Text = "Категория";
            // 
            // numUpDCost
            // 
            this.numUpDCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDCost.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDCost.ForeColor = System.Drawing.Color.White;
            this.numUpDCost.Location = new System.Drawing.Point(183, 123);
            this.numUpDCost.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDCost.Name = "numUpDCost";
            this.numUpDCost.Size = new System.Drawing.Size(89, 29);
            this.numUpDCost.TabIndex = 2;
            this.numUpDCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCost.ForeColor = System.Drawing.Color.White;
            this.lCost.Location = new System.Drawing.Point(12, 125);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(83, 21);
            this.lCost.TabIndex = 30;
            this.lCost.Text = "Стоимость";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.ForeColor = System.Drawing.Color.White;
            this.rtbDescription.Location = new System.Drawing.Point(183, 158);
            this.rtbDescription.MaxLength = 50;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(185, 95);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDescription.ForeColor = System.Drawing.Color.White;
            this.lDescription.Location = new System.Drawing.Point(12, 158);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(81, 21);
            this.lDescription.TabIndex = 30;
            this.lDescription.Text = "Описание";
            // 
            // bAddItem
            // 
            this.bAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddItem.ForeColor = System.Drawing.Color.White;
            this.bAddItem.Location = new System.Drawing.Point(272, 277);
            this.bAddItem.Name = "bAddItem";
            this.bAddItem.Size = new System.Drawing.Size(96, 38);
            this.bAddItem.TabIndex = 4;
            this.bAddItem.Text = "Добавить";
            this.bAddItem.UseVisualStyleBackColor = false;
            this.bAddItem.Click += new System.EventHandler(this.bAddItem_Click);
            // 
            // bCancell
            // 
            this.bCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancell.ForeColor = System.Drawing.Color.White;
            this.bCancell.Location = new System.Drawing.Point(12, 277);
            this.bCancell.Name = "bCancell";
            this.bCancell.Size = new System.Drawing.Size(96, 38);
            this.bCancell.TabIndex = 5;
            this.bCancell.Text = "Отмена";
            this.bCancell.UseVisualStyleBackColor = false;
            this.bCancell.Click += new System.EventHandler(this.bCancell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "ДОБАВИТЬ НОВЫЙ ПРЕДМЕТ ДЛЯ ПРОДАЖИ";
            // 
            // lItemName
            // 
            this.lItemName.AutoSize = true;
            this.lItemName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lItemName.ForeColor = System.Drawing.Color.White;
            this.lItemName.Location = new System.Drawing.Point(12, 90);
            this.lItemName.Name = "lItemName";
            this.lItemName.Size = new System.Drawing.Size(78, 21);
            this.lItemName.TabIndex = 28;
            this.lItemName.Text = "Название";
            // 
            // tbItemName
            // 
            this.tbItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbItemName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbItemName.ForeColor = System.Drawing.Color.White;
            this.tbItemName.Location = new System.Drawing.Point(183, 88);
            this.tbItemName.MaxLength = 50;
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ShortcutsEnabled = false;
            this.tbItemName.Size = new System.Drawing.Size(148, 29);
            this.tbItemName.TabIndex = 1;
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(380, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancell);
            this.Controls.Add(this.bAddItem);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.numUpDCost);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lItemName);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.lCategory);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItem";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNewItem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNewItem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddNewItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.NumericUpDown numUpDCost;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Button bAddItem;
        private System.Windows.Forms.Button bCancell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lItemName;
        private System.Windows.Forms.TextBox tbItemName;
    }
}