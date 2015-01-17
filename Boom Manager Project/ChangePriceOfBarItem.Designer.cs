namespace Boom_Manager_Project
{
    partial class ChangePriceOfBarItem
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
            this.bApply = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.numUpDPrice = new System.Windows.Forms.NumericUpDown();
            this.lNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPrice)).BeginInit();
            this.SuspendLayout();
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
            this.bApply.Location = new System.Drawing.Point(161, 113);
            this.bApply.Margin = new System.Windows.Forms.Padding(5);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(119, 31);
            this.bApply.TabIndex = 5;
            this.bApply.Text = "ПРИМЕНИТЬ";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
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
            this.bClose.Location = new System.Drawing.Point(14, 113);
            this.bClose.Margin = new System.Windows.Forms.Padding(5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(119, 31);
            this.bClose.TabIndex = 6;
            this.bClose.Text = "ЗАКРЫТЬ";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // numUpDPrice
            // 
            this.numUpDPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUpDPrice.ForeColor = System.Drawing.Color.White;
            this.numUpDPrice.Location = new System.Drawing.Point(134, 52);
            this.numUpDPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDPrice.Name = "numUpDPrice";
            this.numUpDPrice.Size = new System.Drawing.Size(120, 25);
            this.numUpDPrice.TabIndex = 4;
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(67, 56);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(46, 21);
            this.lNumber.TabIndex = 3;
            this.lNumber.Text = "Цена";
            this.lNumber.Click += new System.EventHandler(this.lNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ИЗМЕНИТЬ ЦЕНУ";
            // 
            // ChangePriceOfBarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(294, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.numUpDPrice);
            this.Controls.Add(this.lNumber);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePriceOfBarItem";
            this.Text = "ChangePriceOfBarItem";
            this.Load += new System.EventHandler(this.ChangePriceOfBarItem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePriceOfBarItem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePriceOfBarItem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePriceOfBarItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.NumericUpDown numUpDPrice;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label label1;
    }
}