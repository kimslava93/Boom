namespace Boom_Manager_Project
{
    partial class Expences
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
            this.numUpdCash = new System.Windows.Forms.NumericUpDown();
            this.lCashAmounnt = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lTime = new System.Windows.Forms.Label();
            this.lComments = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdCash)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpdCash
            // 
            this.numUpdCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdCash.ForeColor = System.Drawing.Color.White;
            this.numUpdCash.Location = new System.Drawing.Point(154, 21);
            this.numUpdCash.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpdCash.Name = "numUpdCash";
            this.numUpdCash.Size = new System.Drawing.Size(123, 29);
            this.numUpdCash.TabIndex = 0;
            // 
            // lCashAmounnt
            // 
            this.lCashAmounnt.AutoSize = true;
            this.lCashAmounnt.ForeColor = System.Drawing.Color.White;
            this.lCashAmounnt.Location = new System.Drawing.Point(12, 23);
            this.lCashAmounnt.Name = "lCashAmounnt";
            this.lCashAmounnt.Size = new System.Drawing.Size(100, 21);
            this.lCashAmounnt.TabIndex = 4;
            this.lCashAmounnt.Text = "Кол-во денег";
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTime.ForeColor = System.Drawing.Color.White;
            this.tbTime.Location = new System.Drawing.Point(154, 56);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(161, 29);
            this.tbTime.TabIndex = 6;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(12, 58);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(54, 21);
            this.lTime.TabIndex = 5;
            this.lTime.Text = "Время";
            // 
            // lComments
            // 
            this.lComments.AutoSize = true;
            this.lComments.Location = new System.Drawing.Point(12, 91);
            this.lComments.Name = "lComments";
            this.lComments.Size = new System.Drawing.Size(127, 21);
            this.lComments.TabIndex = 5;
            this.lComments.Text = "Объяснительная";
            // 
            // rtbComments
            // 
            this.rtbComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComments.DetectUrls = false;
            this.rtbComments.ForeColor = System.Drawing.Color.White;
            this.rtbComments.Location = new System.Drawing.Point(154, 91);
            this.rtbComments.MaxLength = 500;
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.ShortcutsEnabled = false;
            this.rtbComments.Size = new System.Drawing.Size(201, 79);
            this.rtbComments.TabIndex = 1;
            this.rtbComments.Text = "";
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
            this.bApply.Location = new System.Drawing.Point(280, 193);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 35);
            this.bApply.TabIndex = 8;
            this.bApply.Text = "Снять";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
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
            this.bCancel.Location = new System.Drawing.Point(12, 193);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(86, 35);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Expences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(367, 240);
            this.ControlBox = false;
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.lComments);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.numUpdCash);
            this.Controls.Add(this.lCashAmounnt);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpdCash;
        private System.Windows.Forms.Label lCashAmounnt;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
    }
}