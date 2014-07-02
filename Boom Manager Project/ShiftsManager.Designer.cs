namespace Boom_Manager_Project
{
    partial class ShiftsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbShifts = new System.Windows.Forms.GroupBox();
            this.lShifts = new System.Windows.Forms.Label();
            this.dgvAllGlobalSessions = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.bReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGlobalSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // gbShifts
            // 
            this.gbShifts.Controls.Add(this.lShifts);
            this.gbShifts.Controls.Add(this.dgvAllGlobalSessions);
            this.gbShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbShifts.Location = new System.Drawing.Point(3, 33);
            this.gbShifts.Name = "gbShifts";
            this.gbShifts.Size = new System.Drawing.Size(683, 277);
            this.gbShifts.TabIndex = 1;
            this.gbShifts.TabStop = false;
            // 
            // lShifts
            // 
            this.lShifts.AutoSize = true;
            this.lShifts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lShifts.ForeColor = System.Drawing.Color.White;
            this.lShifts.Location = new System.Drawing.Point(12, 1);
            this.lShifts.Name = "lShifts";
            this.lShifts.Size = new System.Drawing.Size(64, 21);
            this.lShifts.TabIndex = 2;
            this.lShifts.Text = "Смены";
            // 
            // dgvAllGlobalSessions
            // 
            this.dgvAllGlobalSessions.AllowUserToAddRows = false;
            this.dgvAllGlobalSessions.AllowUserToDeleteRows = false;
            this.dgvAllGlobalSessions.AllowUserToResizeColumns = false;
            this.dgvAllGlobalSessions.AllowUserToResizeRows = false;
            this.dgvAllGlobalSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllGlobalSessions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvAllGlobalSessions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAllGlobalSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllGlobalSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllGlobalSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllGlobalSessions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllGlobalSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllGlobalSessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllGlobalSessions.EnableHeadersVisualStyles = false;
            this.dgvAllGlobalSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvAllGlobalSessions.Location = new System.Drawing.Point(3, 25);
            this.dgvAllGlobalSessions.MultiSelect = false;
            this.dgvAllGlobalSessions.Name = "dgvAllGlobalSessions";
            this.dgvAllGlobalSessions.ReadOnly = true;
            this.dgvAllGlobalSessions.RowHeadersVisible = false;
            this.dgvAllGlobalSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllGlobalSessions.ShowCellErrors = false;
            this.dgvAllGlobalSessions.ShowCellToolTips = false;
            this.dgvAllGlobalSessions.ShowEditingIcon = false;
            this.dgvAllGlobalSessions.ShowRowErrors = false;
            this.dgvAllGlobalSessions.Size = new System.Drawing.Size(677, 249);
            this.dgvAllGlobalSessions.TabIndex = 1;
            this.dgvAllGlobalSessions.VirtualMode = true;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(580, 329);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(97, 37);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            this.bClose.MouseHover += new System.EventHandler(this.bClose_MouseHover);
            // 
            // bReport
            // 
            this.bReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReport.ForeColor = System.Drawing.Color.White;
            this.bReport.Location = new System.Drawing.Point(19, 329);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(97, 37);
            this.bReport.TabIndex = 3;
            this.bReport.Text = "Отчет";
            this.bReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReport.UseVisualStyleBackColor = false;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
            this.bReport.MouseLeave += new System.EventHandler(this.bReport_MouseLeave);
            this.bReport.MouseHover += new System.EventHandler(this.bReport_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Управление сменами";
            // 
            // ShiftsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(689, 378);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReport);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.gbShifts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftsManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftsManager";
            this.Load += new System.EventHandler(this.ShiftsManager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShiftsManager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShiftsManager_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShiftsManager_MouseUp);
            this.gbShifts.ResumeLayout(false);
            this.gbShifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGlobalSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbShifts;
        private System.Windows.Forms.DataGridView dgvAllGlobalSessions;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bReport;
        private System.Windows.Forms.Label lShifts;
        private System.Windows.Forms.Label label1;

    }
}