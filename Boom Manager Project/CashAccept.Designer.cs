namespace Boom_Manager_Project
{
    partial class CashAccept
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
            this.lWarning = new System.Windows.Forms.Label();
            this.numUpDCash = new System.Windows.Forms.NumericUpDown();
            this.lCash = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCash)).BeginInit();
            this.SuspendLayout();
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.Location = new System.Drawing.Point(75, 30);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(66, 21);
            this.lWarning.TabIndex = 0;
            this.lWarning.Text = "Warning";
            this.lWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDCash
            // 
            this.numUpDCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDCash.ForeColor = System.Drawing.Color.White;
            this.numUpDCash.Location = new System.Drawing.Point(153, 107);
            this.numUpDCash.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpDCash.Name = "numUpDCash";
            this.numUpDCash.Size = new System.Drawing.Size(120, 29);
            this.numUpDCash.TabIndex = 1;
            this.numUpDCash.ValueChanged += new System.EventHandler(this.numUpDCash_ValueChanged);
            // 
            // lCash
            // 
            this.lCash.AutoSize = true;
            this.lCash.Location = new System.Drawing.Point(32, 109);
            this.lCash.Name = "lCash";
            this.lCash.Size = new System.Drawing.Size(104, 21);
            this.lCash.TabIndex = 2;
            this.lCash.Text = "Денег в кассе";
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
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(114, 173);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(98, 37);
            this.bApply.TabIndex = 5;
            this.bApply.Text = "Принять";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // CashAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(355, 222);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.lCash);
            this.Controls.Add(this.numUpDCash);
            this.Controls.Add(this.lWarning);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashAccept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashAccept";
            this.Load += new System.EventHandler(this.CashAccept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.NumericUpDown numUpDCash;
        private System.Windows.Forms.Label lCash;
        private System.Windows.Forms.Button bApply;
    }
}