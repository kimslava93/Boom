namespace Boom_Manager_Project
{
    partial class ManagerCardReader
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
            this.components = new System.ComponentModel.Container();
            this.tbDiscountCards = new System.Windows.Forms.TextBox();
            this.lClientDiscountId = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDiscountCards
            // 
            this.tbDiscountCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbDiscountCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscountCards.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiscountCards.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscountCards.ForeColor = System.Drawing.Color.White;
            this.tbDiscountCards.Location = new System.Drawing.Point(146, 25);
            this.tbDiscountCards.MaxLength = 50;
            this.tbDiscountCards.Name = "tbDiscountCards";
            this.tbDiscountCards.ShortcutsEnabled = false;
            this.tbDiscountCards.Size = new System.Drawing.Size(148, 29);
            this.tbDiscountCards.TabIndex = 0;
            this.tbDiscountCards.Text = "0";
            this.tbDiscountCards.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiscountCards_KeyPress);
            // 
            // lClientDiscountId
            // 
            this.lClientDiscountId.AutoSize = true;
            this.lClientDiscountId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClientDiscountId.ForeColor = System.Drawing.Color.White;
            this.lClientDiscountId.Location = new System.Drawing.Point(12, 28);
            this.lClientDiscountId.Name = "lClientDiscountId";
            this.lClientDiscountId.Size = new System.Drawing.Size(125, 21);
            this.lClientDiscountId.TabIndex = 28;
            this.lClientDiscountId.Text = "Карточки сессии";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(199, 60);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(96, 38);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTime.ForeColor = System.Drawing.Color.Red;
            this.lTime.Location = new System.Drawing.Point(12, 63);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(23, 28);
            this.lTime.TabIndex = 29;
            this.lTime.Text = "3";
            // 
            // ManagerCardReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(307, 108);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbDiscountCards);
            this.Controls.Add(this.lClientDiscountId);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerCardReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerCardReader";
            this.Load += new System.EventHandler(this.ManagerCardReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDiscountCards;
        private System.Windows.Forms.Label lClientDiscountId;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lTime;
    }
}