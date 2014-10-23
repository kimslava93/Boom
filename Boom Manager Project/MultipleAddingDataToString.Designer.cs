namespace Boom_Manager_Project
{
    partial class MultipleAddingDataToString
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
            this.lbAllAvailableItems = new System.Windows.Forms.ListBox();
            this.lbResultItems = new System.Windows.Forms.ListBox();
            this.bAddSelectedItem = new System.Windows.Forms.Button();
            this.bDeleteSelectedItem = new System.Windows.Forms.Button();
            this.bAddAllItems = new System.Windows.Forms.Button();
            this.bDeletAll = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllAvailableItems
            // 
            this.lbAllAvailableItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbAllAvailableItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAllAvailableItems.ForeColor = System.Drawing.Color.White;
            this.lbAllAvailableItems.FormattingEnabled = true;
            this.lbAllAvailableItems.ItemHeight = 21;
            this.lbAllAvailableItems.Location = new System.Drawing.Point(45, 70);
            this.lbAllAvailableItems.Name = "lbAllAvailableItems";
            this.lbAllAvailableItems.Size = new System.Drawing.Size(146, 275);
            this.lbAllAvailableItems.Sorted = true;
            this.lbAllAvailableItems.TabIndex = 0;
            // 
            // lbResultItems
            // 
            this.lbResultItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbResultItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultItems.ForeColor = System.Drawing.Color.White;
            this.lbResultItems.FormattingEnabled = true;
            this.lbResultItems.ItemHeight = 21;
            this.lbResultItems.Location = new System.Drawing.Point(308, 70);
            this.lbResultItems.Name = "lbResultItems";
            this.lbResultItems.Size = new System.Drawing.Size(146, 275);
            this.lbResultItems.Sorted = true;
            this.lbResultItems.TabIndex = 0;
            // 
            // bAddSelectedItem
            // 
            this.bAddSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddSelectedItem.Location = new System.Drawing.Point(233, 109);
            this.bAddSelectedItem.Name = "bAddSelectedItem";
            this.bAddSelectedItem.Size = new System.Drawing.Size(47, 32);
            this.bAddSelectedItem.TabIndex = 1;
            this.bAddSelectedItem.Text = ">";
            this.bAddSelectedItem.UseVisualStyleBackColor = false;
            this.bAddSelectedItem.Click += new System.EventHandler(this.bAddSelectedItem_Click);
            // 
            // bDeleteSelectedItem
            // 
            this.bDeleteSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDeleteSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteSelectedItem.Location = new System.Drawing.Point(233, 147);
            this.bDeleteSelectedItem.Name = "bDeleteSelectedItem";
            this.bDeleteSelectedItem.Size = new System.Drawing.Size(47, 32);
            this.bDeleteSelectedItem.TabIndex = 1;
            this.bDeleteSelectedItem.Text = "<";
            this.bDeleteSelectedItem.UseVisualStyleBackColor = false;
            this.bDeleteSelectedItem.Click += new System.EventHandler(this.bDeleteSelectedItem_Click);
            // 
            // bAddAllItems
            // 
            this.bAddAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddAllItems.Location = new System.Drawing.Point(233, 240);
            this.bAddAllItems.Name = "bAddAllItems";
            this.bAddAllItems.Size = new System.Drawing.Size(47, 32);
            this.bAddAllItems.TabIndex = 1;
            this.bAddAllItems.Text = ">>";
            this.bAddAllItems.UseVisualStyleBackColor = false;
            this.bAddAllItems.Click += new System.EventHandler(this.bAddAllItems_Click);
            // 
            // bDeletAll
            // 
            this.bDeletAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDeletAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeletAll.Location = new System.Drawing.Point(233, 278);
            this.bDeletAll.Name = "bDeletAll";
            this.bDeletAll.Size = new System.Drawing.Size(47, 32);
            this.bDeletAll.TabIndex = 1;
            this.bDeletAll.Text = "<<";
            this.bDeletAll.UseVisualStyleBackColor = false;
            this.bDeletAll.Click += new System.EventHandler(this.bDeletAll_Click);
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
            this.bClose.Location = new System.Drawing.Point(45, 12);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(146, 38);
            this.bClose.TabIndex = 111;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bFinish
            // 
            this.bFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFinish.ForeColor = System.Drawing.Color.White;
            this.bFinish.Location = new System.Drawing.Point(308, 12);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(146, 38);
            this.bFinish.TabIndex = 111;
            this.bFinish.Text = "Продолжить";
            this.bFinish.UseVisualStyleBackColor = false;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // MultipleAddingDataToString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(496, 387);
            this.Controls.Add(this.bFinish);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bDeletAll);
            this.Controls.Add(this.bAddAllItems);
            this.Controls.Add(this.bDeleteSelectedItem);
            this.Controls.Add(this.bAddSelectedItem);
            this.Controls.Add(this.lbResultItems);
            this.Controls.Add(this.lbAllAvailableItems);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultipleAddingDataToString";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultipleAddingDataToString";
            this.Load += new System.EventHandler(this.MultipleAddingDataToString_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllAvailableItems;
        private System.Windows.Forms.ListBox lbResultItems;
        private System.Windows.Forms.Button bAddSelectedItem;
        private System.Windows.Forms.Button bDeleteSelectedItem;
        private System.Windows.Forms.Button bAddAllItems;
        private System.Windows.Forms.Button bDeletAll;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bFinish;
    }
}