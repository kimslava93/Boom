namespace Boom_Manager_Project
{
    partial class ChangeNumberOfItem
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
            this.lNumber = new System.Windows.Forms.Label();
            this.numUpDNumber = new System.Windows.Forms.NumericUpDown();
            this.bClose = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(31, 42);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(90, 21);
            this.lNumber.TabIndex = 0;
            this.lNumber.Text = "Количество";
            // 
            // numUpDNumber
            // 
            this.numUpDNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUpDNumber.ForeColor = System.Drawing.Color.White;
            this.numUpDNumber.Location = new System.Drawing.Point(137, 40);
            this.numUpDNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDNumber.Name = "numUpDNumber";
            this.numUpDNumber.Size = new System.Drawing.Size(120, 25);
            this.numUpDNumber.TabIndex = 1;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(9, 90);
            this.bClose.Margin = new System.Windows.Forms.Padding(5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(119, 31);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "ЗАКРЫТЬ";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(151, 90);
            this.bApply.Margin = new System.Windows.Forms.Padding(5);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(119, 31);
            this.bApply.TabIndex = 2;
            this.bApply.Text = "ПРИМЕНИТЬ";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // ChangeNumberOfItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.numUpDNumber);
            this.Controls.Add(this.lNumber);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeNumberOfItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeNumberOfItem";
            this.Load += new System.EventHandler(this.ChangeNumberOfItem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeNumberOfItem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeNumberOfItem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeNumberOfItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.NumericUpDown numUpDNumber;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bApply;
    }
}