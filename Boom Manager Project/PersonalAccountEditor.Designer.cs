namespace Boom_Manager_Project
{
    partial class PersonalAccountEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lSalary = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.bSalaryEdit = new System.Windows.Forms.Button();
            this.btnPasswordEdit = new System.Windows.Forms.Button();
            this.btnIdEdit = new System.Windows.Forms.Button();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.lShifts = new System.Windows.Forms.Label();
            this.lExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // lSalary
            // 
            this.lSalary.AutoSize = true;
            this.lSalary.Location = new System.Drawing.Point(19, 84);
            this.lSalary.Margin = new System.Windows.Forms.Padding(10);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(75, 21);
            this.lSalary.TabIndex = 0;
            this.lSalary.Text = "Зарплата";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(19, 125);
            this.lPassword.Margin = new System.Windows.Forms.Padding(10);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(62, 21);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID код";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(19, 43);
            this.lName.Margin = new System.Windows.Forms.Padding(10);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 21);
            this.lName.TabIndex = 0;
            this.lName.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Enabled = false;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(143, 41);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.ShortcutsEnabled = false;
            this.tbName.Size = new System.Drawing.Size(187, 29);
            this.tbName.TabIndex = 3;
            // 
            // tbSalary
            // 
            this.tbSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSalary.Enabled = false;
            this.tbSalary.ForeColor = System.Drawing.Color.White;
            this.tbSalary.Location = new System.Drawing.Point(143, 82);
            this.tbSalary.MaxLength = 50;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.ReadOnly = true;
            this.tbSalary.ShortcutsEnabled = false;
            this.tbSalary.Size = new System.Drawing.Size(187, 29);
            this.tbSalary.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Enabled = false;
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(143, 123);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.ShortcutsEnabled = false;
            this.tbPassword.Size = new System.Drawing.Size(187, 29);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbId.Enabled = false;
            this.tbId.ForeColor = System.Drawing.Color.White;
            this.tbId.Location = new System.Drawing.Point(143, 164);
            this.tbId.MaxLength = 50;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.ShortcutsEnabled = false;
            this.tbId.Size = new System.Drawing.Size(187, 29);
            this.tbId.TabIndex = 3;
            this.tbId.UseSystemPasswordChar = true;
            // 
            // bSalaryEdit
            // 
            this.bSalaryEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSalaryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalaryEdit.Location = new System.Drawing.Point(336, 82);
            this.bSalaryEdit.Name = "bSalaryEdit";
            this.bSalaryEdit.Size = new System.Drawing.Size(75, 29);
            this.bSalaryEdit.TabIndex = 4;
            this.bSalaryEdit.Text = "Изм.";
            this.bSalaryEdit.UseVisualStyleBackColor = false;
            // 
            // btnPasswordEdit
            // 
            this.btnPasswordEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.btnPasswordEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordEdit.Location = new System.Drawing.Point(336, 123);
            this.btnPasswordEdit.Name = "btnPasswordEdit";
            this.btnPasswordEdit.Size = new System.Drawing.Size(75, 29);
            this.btnPasswordEdit.TabIndex = 4;
            this.btnPasswordEdit.Text = "Изм.";
            this.btnPasswordEdit.UseVisualStyleBackColor = false;
            // 
            // btnIdEdit
            // 
            this.btnIdEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.btnIdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdEdit.Location = new System.Drawing.Point(336, 164);
            this.btnIdEdit.Name = "btnIdEdit";
            this.btnIdEdit.Size = new System.Drawing.Size(75, 29);
            this.btnIdEdit.TabIndex = 4;
            this.btnIdEdit.Text = "Изм.";
            this.btnIdEdit.UseVisualStyleBackColor = false;
            // 
            // dgvShifts
            // 
            this.dgvShifts.AllowUserToAddRows = false;
            this.dgvShifts.AllowUserToDeleteRows = false;
            this.dgvShifts.AllowUserToOrderColumns = true;
            this.dgvShifts.AllowUserToResizeColumns = false;
            this.dgvShifts.AllowUserToResizeRows = false;
            this.dgvShifts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShifts.EnableHeadersVisualStyles = false;
            this.dgvShifts.GridColor = System.Drawing.Color.White;
            this.dgvShifts.Location = new System.Drawing.Point(143, 235);
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.ReadOnly = true;
            this.dgvShifts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShifts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShifts.RowHeadersVisible = false;
            this.dgvShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShifts.Size = new System.Drawing.Size(268, 315);
            this.dgvShifts.TabIndex = 5;
            this.dgvShifts.VirtualMode = true;
            // 
            // lShifts
            // 
            this.lShifts.AutoSize = true;
            this.lShifts.Location = new System.Drawing.Point(19, 235);
            this.lShifts.Margin = new System.Windows.Forms.Padding(10);
            this.lShifts.Name = "lShifts";
            this.lShifts.Size = new System.Drawing.Size(58, 21);
            this.lShifts.TabIndex = 2;
            this.lShifts.Text = "Смены";
            // 
            // lExit
            // 
            this.lExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.lExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lExit.Location = new System.Drawing.Point(12, 517);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(114, 31);
            this.lExit.TabIndex = 4;
            this.lExit.Text = "Выход";
            this.lExit.UseVisualStyleBackColor = false;
            this.lExit.Click += new System.EventHandler(this.lExit_Click);
            // 
            // PersonalAccountEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(419, 560);
            this.Controls.Add(this.dgvShifts);
            this.Controls.Add(this.lExit);
            this.Controls.Add(this.btnIdEdit);
            this.Controls.Add(this.btnPasswordEdit);
            this.Controls.Add(this.bSalaryEdit);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lShifts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lSalary);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalAccountEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Account Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button bSalaryEdit;
        private System.Windows.Forms.Button btnPasswordEdit;
        private System.Windows.Forms.Button btnIdEdit;
        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.Label lShifts;
        private System.Windows.Forms.Button lExit;
    }
}