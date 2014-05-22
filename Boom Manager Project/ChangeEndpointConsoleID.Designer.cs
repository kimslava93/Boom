namespace Boom_Manager_Project
{
    partial class ChangeEndpointConsoleID
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
            this.gbConsoleID = new System.Windows.Forms.GroupBox();
            this.cbConsolesList = new System.Windows.Forms.ComboBox();
            this.tbEndPointID = new System.Windows.Forms.TextBox();
            this.lConsoleID = new System.Windows.Forms.Label();
            this.lEndpoint = new System.Windows.Forms.Label();
            this.bSetToZero = new System.Windows.Forms.Button();
            this.gbConsoleID.SuspendLayout();
            this.SuspendLayout();
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
            this.bApply.Location = new System.Drawing.Point(12, 190);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 34);
            this.bApply.TabIndex = 4;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(222, 190);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 34);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Cancel";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click_1);
            // 
            // gbConsoleID
            // 
            this.gbConsoleID.Controls.Add(this.bSetToZero);
            this.gbConsoleID.Controls.Add(this.cbConsolesList);
            this.gbConsoleID.Controls.Add(this.tbEndPointID);
            this.gbConsoleID.Controls.Add(this.lConsoleID);
            this.gbConsoleID.Controls.Add(this.lEndpoint);
            this.gbConsoleID.ForeColor = System.Drawing.Color.White;
            this.gbConsoleID.Location = new System.Drawing.Point(12, 12);
            this.gbConsoleID.Name = "gbConsoleID";
            this.gbConsoleID.Size = new System.Drawing.Size(285, 172);
            this.gbConsoleID.TabIndex = 6;
            this.gbConsoleID.TabStop = false;
            this.gbConsoleID.Text = "Choose console ID";
            // 
            // cbConsolesList
            // 
            this.cbConsolesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbConsolesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbConsolesList.ForeColor = System.Drawing.Color.White;
            this.cbConsolesList.FormattingEnabled = true;
            this.cbConsolesList.Location = new System.Drawing.Point(118, 80);
            this.cbConsolesList.Name = "cbConsolesList";
            this.cbConsolesList.Size = new System.Drawing.Size(161, 29);
            this.cbConsolesList.TabIndex = 8;
            // 
            // tbEndPointID
            // 
            this.tbEndPointID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbEndPointID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndPointID.ForeColor = System.Drawing.Color.White;
            this.tbEndPointID.Location = new System.Drawing.Point(118, 45);
            this.tbEndPointID.Name = "tbEndPointID";
            this.tbEndPointID.ReadOnly = true;
            this.tbEndPointID.Size = new System.Drawing.Size(161, 29);
            this.tbEndPointID.TabIndex = 7;
            // 
            // lConsoleID
            // 
            this.lConsoleID.AutoSize = true;
            this.lConsoleID.Location = new System.Drawing.Point(17, 83);
            this.lConsoleID.Name = "lConsoleID";
            this.lConsoleID.Size = new System.Drawing.Size(83, 21);
            this.lConsoleID.TabIndex = 0;
            this.lConsoleID.Text = "Console ID";
            // 
            // lEndpoint
            // 
            this.lEndpoint.AutoSize = true;
            this.lEndpoint.Location = new System.Drawing.Point(17, 47);
            this.lEndpoint.Name = "lEndpoint";
            this.lEndpoint.Size = new System.Drawing.Size(94, 21);
            this.lEndpoint.TabIndex = 0;
            this.lEndpoint.Text = "End point ID";
            // 
            // bSetToZero
            // 
            this.bSetToZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSetToZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSetToZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSetToZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bSetToZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSetToZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSetToZero.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSetToZero.ForeColor = System.Drawing.Color.White;
            this.bSetToZero.Location = new System.Drawing.Point(196, 115);
            this.bSetToZero.Name = "bSetToZero";
            this.bSetToZero.Size = new System.Drawing.Size(83, 26);
            this.bSetToZero.TabIndex = 9;
            this.bSetToZero.Text = "set to zero";
            this.bSetToZero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSetToZero.UseVisualStyleBackColor = false;
            this.bSetToZero.Click += new System.EventHandler(this.bSetToZero_Click);
            // 
            // ChangeEndpointConsoleID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 236);
            this.ControlBox = false;
            this.Controls.Add(this.gbConsoleID);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bApply);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeEndpointConsoleID";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End points manager";
            this.Load += new System.EventHandler(this.EndPointsManager_Load);
            this.gbConsoleID.ResumeLayout(false);
            this.gbConsoleID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.GroupBox gbConsoleID;
        private System.Windows.Forms.Label lConsoleID;
        private System.Windows.Forms.Label lEndpoint;
        private System.Windows.Forms.ComboBox cbConsolesList;
        private System.Windows.Forms.TextBox tbEndPointID;
        private System.Windows.Forms.Button bSetToZero;

    }
}