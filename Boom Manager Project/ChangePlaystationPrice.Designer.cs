namespace Boom_Manager_Project
{
    partial class ChangePlaystationPrice
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
            this.numUpDPrice = new System.Windows.Forms.NumericUpDown();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.ForeColor = System.Drawing.Color.White;
            this.lWarning.Location = new System.Drawing.Point(52, 9);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(237, 21);
            this.lWarning.TabIndex = 0;
            this.lWarning.Text = "Установить цену для приставок: ";
            this.lWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numUpDPrice
            // 
            this.numUpDPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDPrice.ForeColor = System.Drawing.Color.White;
            this.numUpDPrice.Location = new System.Drawing.Point(84, 102);
            this.numUpDPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDPrice.Name = "numUpDPrice";
            this.numUpDPrice.Size = new System.Drawing.Size(120, 29);
            this.numUpDPrice.TabIndex = 1;
            this.numUpDPrice.ValueChanged += new System.EventHandler(this.numUpDPrice_ValueChanged);
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(12, 137);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(109, 39);
            this.bApply.TabIndex = 2;
            this.bApply.Text = "Применить";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(186, 137);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 39);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // ChangePlaystationPrice
            // 
            this.AcceptButton = this.bApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(288, 191);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.numUpDPrice);
            this.Controls.Add(this.lWarning);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePlaystationPrice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePlaystationPrice";
            this.Load += new System.EventHandler(this.ChangeCost_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePlaystationPrice_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePlaystationPrice_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePlaystationPrice_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.NumericUpDown numUpDPrice;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
    }
}