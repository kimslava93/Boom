namespace Boom_Manager_Project
{
    partial class WithdrawMoney
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
            this.gbWithdrawMoney = new System.Windows.Forms.GroupBox();
            this.lTime = new System.Windows.Forms.Label();
            this.lCashAmount = new System.Windows.Forms.Label();
            this.lManager = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.numUpDCashAmount = new System.Windows.Forms.NumericUpDown();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.gbWithdrawMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCashAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWithdrawMoney
            // 
            this.gbWithdrawMoney.Controls.Add(this.cbManager);
            this.gbWithdrawMoney.Controls.Add(this.numUpDCashAmount);
            this.gbWithdrawMoney.Controls.Add(this.tbTime);
            this.gbWithdrawMoney.Controls.Add(this.lManager);
            this.gbWithdrawMoney.Controls.Add(this.lCashAmount);
            this.gbWithdrawMoney.Controls.Add(this.lTime);
            this.gbWithdrawMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbWithdrawMoney.ForeColor = System.Drawing.Color.White;
            this.gbWithdrawMoney.Location = new System.Drawing.Point(0, 0);
            this.gbWithdrawMoney.Name = "gbWithdrawMoney";
            this.gbWithdrawMoney.Size = new System.Drawing.Size(334, 158);
            this.gbWithdrawMoney.TabIndex = 0;
            this.gbWithdrawMoney.TabStop = false;
            this.gbWithdrawMoney.Text = "Withdraw money";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(25, 40);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(42, 21);
            this.lTime.TabIndex = 0;
            this.lTime.Text = "Time";
            // 
            // lCashAmount
            // 
            this.lCashAmount.AutoSize = true;
            this.lCashAmount.Location = new System.Drawing.Point(25, 74);
            this.lCashAmount.Name = "lCashAmount";
            this.lCashAmount.Size = new System.Drawing.Size(100, 21);
            this.lCashAmount.TabIndex = 1;
            this.lCashAmount.Text = "Cash amount";
            // 
            // lManager
            // 
            this.lManager.AutoSize = true;
            this.lManager.Location = new System.Drawing.Point(25, 110);
            this.lManager.Name = "lManager";
            this.lManager.Size = new System.Drawing.Size(70, 21);
            this.lManager.TabIndex = 1;
            this.lManager.Text = "Manager";
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTime.ForeColor = System.Drawing.Color.White;
            this.tbTime.Location = new System.Drawing.Point(166, 37);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(161, 29);
            this.tbTime.TabIndex = 2;
            // 
            // numUpDCashAmount
            // 
            this.numUpDCashAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDCashAmount.ForeColor = System.Drawing.Color.White;
            this.numUpDCashAmount.Location = new System.Drawing.Point(166, 72);
            this.numUpDCashAmount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpDCashAmount.Name = "numUpDCashAmount";
            this.numUpDCashAmount.Size = new System.Drawing.Size(161, 29);
            this.numUpDCashAmount.TabIndex = 3;
            // 
            // cbManager
            // 
            this.cbManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbManager.ForeColor = System.Drawing.Color.White;
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(166, 107);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(161, 29);
            this.cbManager.TabIndex = 4;
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
            this.bCancel.Location = new System.Drawing.Point(12, 164);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 35);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
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
            this.bApply.Location = new System.Drawing.Point(247, 164);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 35);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 209);
            this.ControlBox = false;
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.gbWithdrawMoney);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WithdrawMoney";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawMoney";
            this.Load += new System.EventHandler(this.WithdrawMoney_Load);
            this.gbWithdrawMoney.ResumeLayout(false);
            this.gbWithdrawMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCashAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWithdrawMoney;
        private System.Windows.Forms.ComboBox cbManager;
        private System.Windows.Forms.NumericUpDown numUpDCashAmount;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lManager;
        private System.Windows.Forms.Label lCashAmount;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bApply;
    }
}