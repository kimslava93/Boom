namespace Boom_Manager_Project
{
    partial class LightCutOff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSessionsToClose = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.bCloseSession = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bSwitchOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsToClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSessionsToClose
            // 
            this.dgvSessionsToClose.AllowUserToAddRows = false;
            this.dgvSessionsToClose.AllowUserToDeleteRows = false;
            this.dgvSessionsToClose.AllowUserToResizeColumns = false;
            this.dgvSessionsToClose.AllowUserToResizeRows = false;
            this.dgvSessionsToClose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionsToClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSessionsToClose.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSessionsToClose.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSessionsToClose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessionsToClose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSessionsToClose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionsToClose.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSessionsToClose.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSessionsToClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSessionsToClose.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSessionsToClose.EnableHeadersVisualStyles = false;
            this.dgvSessionsToClose.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvSessionsToClose.Location = new System.Drawing.Point(0, 0);
            this.dgvSessionsToClose.MultiSelect = false;
            this.dgvSessionsToClose.Name = "dgvSessionsToClose";
            this.dgvSessionsToClose.ReadOnly = true;
            this.dgvSessionsToClose.RowHeadersVisible = false;
            this.dgvSessionsToClose.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSessionsToClose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSessionsToClose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionsToClose.Size = new System.Drawing.Size(167, 441);
            this.dgvSessionsToClose.TabIndex = 4;
            this.dgvSessionsToClose.TabStop = false;
            this.dgvSessionsToClose.VirtualMode = true;
            this.dgvSessionsToClose.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessionsToClose_CellClick);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(290, 389);
            this.bClose.Margin = new System.Windows.Forms.Padding(5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(107, 38);
            this.bClose.TabIndex = 1002;
            this.bClose.Text = "ОТМЕНИТЬ";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bCloseSession
            // 
            this.bCloseSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCloseSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCloseSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCloseSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCloseSession.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCloseSession.ForeColor = System.Drawing.Color.White;
            this.bCloseSession.Location = new System.Drawing.Point(187, 97);
            this.bCloseSession.Margin = new System.Windows.Forms.Padding(5);
            this.bCloseSession.Name = "bCloseSession";
            this.bCloseSession.Size = new System.Drawing.Size(210, 38);
            this.bCloseSession.TabIndex = 1002;
            this.bCloseSession.Text = "ЗАКРЫТЬ СЕССИЮ";
            this.bCloseSession.UseVisualStyleBackColor = false;
            this.bCloseSession.Click += new System.EventHandler(this.bCloseSession_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bSwitchOff
            // 
            this.bSwitchOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSwitchOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSwitchOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSwitchOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSwitchOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bSwitchOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSwitchOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSwitchOff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSwitchOff.ForeColor = System.Drawing.Color.White;
            this.bSwitchOff.Location = new System.Drawing.Point(173, 389);
            this.bSwitchOff.Margin = new System.Windows.Forms.Padding(5);
            this.bSwitchOff.Name = "bSwitchOff";
            this.bSwitchOff.Size = new System.Drawing.Size(107, 38);
            this.bSwitchOff.TabIndex = 1002;
            this.bSwitchOff.Text = "ВЫКЛЮЧИТЬ";
            this.bSwitchOff.UseVisualStyleBackColor = false;
            this.bSwitchOff.Click += new System.EventHandler(this.bSwitchOff_Click);
            // 
            // LightCutOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(411, 441);
            this.ControlBox = false;
            this.Controls.Add(this.bCloseSession);
            this.Controls.Add(this.bSwitchOff);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dgvSessionsToClose);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LightCutOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightCutOff";
            this.Load += new System.EventHandler(this.LightCutOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsToClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSessionsToClose;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bCloseSession;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button bSwitchOff;
    }
}