namespace Boom_Manager_Project
{
    partial class ConsoleManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbConsoleInfo = new System.Windows.Forms.GroupBox();
            this.mtbOrderTime = new System.Windows.Forms.MaskedTextBox();
            this.cbCurrentState = new System.Windows.Forms.ComboBox();
            this.tbConsoleName = new System.Windows.Forms.TextBox();
            this.lOrderTime = new System.Windows.Forms.Label();
            this.lCurrentState = new System.Windows.Forms.Label();
            this.lConsoleName = new System.Windows.Forms.Label();
            this.dgvPriceListOfConsole = new System.Windows.Forms.DataGridView();
            this.bApplyChanges = new System.Windows.Forms.Button();
            this.gbAllConsoles = new System.Windows.Forms.GroupBox();
            this.dgvAllConsoles = new System.Windows.Forms.DataGridView();
            this.bAddNewConsole = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.gbConsoleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceListOfConsole)).BeginInit();
            this.gbAllConsoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllConsoles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsoleInfo
            // 
            this.gbConsoleInfo.Controls.Add(this.mtbOrderTime);
            this.gbConsoleInfo.Controls.Add(this.cbCurrentState);
            this.gbConsoleInfo.Controls.Add(this.tbConsoleName);
            this.gbConsoleInfo.Controls.Add(this.lOrderTime);
            this.gbConsoleInfo.Controls.Add(this.lCurrentState);
            this.gbConsoleInfo.Controls.Add(this.lConsoleName);
            this.gbConsoleInfo.Controls.Add(this.dgvPriceListOfConsole);
            this.gbConsoleInfo.Controls.Add(this.bApplyChanges);
            this.gbConsoleInfo.ForeColor = System.Drawing.Color.White;
            this.gbConsoleInfo.Location = new System.Drawing.Point(178, 56);
            this.gbConsoleInfo.Name = "gbConsoleInfo";
            this.gbConsoleInfo.Size = new System.Drawing.Size(333, 312);
            this.gbConsoleInfo.TabIndex = 1;
            this.gbConsoleInfo.TabStop = false;
            this.gbConsoleInfo.Text = "Информация о приставке";
            // 
            // mtbOrderTime
            // 
            this.mtbOrderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mtbOrderTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbOrderTime.ForeColor = System.Drawing.Color.White;
            this.mtbOrderTime.Location = new System.Drawing.Point(163, 93);
            this.mtbOrderTime.Mask = "00.00.0000 00:00";
            this.mtbOrderTime.Name = "mtbOrderTime";
            this.mtbOrderTime.Size = new System.Drawing.Size(161, 29);
            this.mtbOrderTime.TabIndex = 7;
            // 
            // cbCurrentState
            // 
            this.cbCurrentState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbCurrentState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurrentState.ForeColor = System.Drawing.Color.White;
            this.cbCurrentState.FormattingEnabled = true;
            this.cbCurrentState.Items.AddRange(new object[] {
            "free",
            "busy",
            "order",
            "unknown"});
            this.cbCurrentState.Location = new System.Drawing.Point(163, 58);
            this.cbCurrentState.Name = "cbCurrentState";
            this.cbCurrentState.Size = new System.Drawing.Size(161, 29);
            this.cbCurrentState.TabIndex = 6;
            // 
            // tbConsoleName
            // 
            this.tbConsoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbConsoleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConsoleName.ForeColor = System.Drawing.Color.White;
            this.tbConsoleName.Location = new System.Drawing.Point(163, 23);
            this.tbConsoleName.Name = "tbConsoleName";
            this.tbConsoleName.Size = new System.Drawing.Size(161, 29);
            this.tbConsoleName.TabIndex = 5;
            // 
            // lOrderTime
            // 
            this.lOrderTime.AutoSize = true;
            this.lOrderTime.ForeColor = System.Drawing.Color.White;
            this.lOrderTime.Location = new System.Drawing.Point(6, 95);
            this.lOrderTime.Name = "lOrderTime";
            this.lOrderTime.Size = new System.Drawing.Size(103, 21);
            this.lOrderTime.TabIndex = 4;
            this.lOrderTime.Text = "Время заказа";
            // 
            // lCurrentState
            // 
            this.lCurrentState.AutoSize = true;
            this.lCurrentState.ForeColor = System.Drawing.Color.White;
            this.lCurrentState.Location = new System.Drawing.Point(6, 60);
            this.lCurrentState.Name = "lCurrentState";
            this.lCurrentState.Size = new System.Drawing.Size(144, 21);
            this.lCurrentState.TabIndex = 3;
            this.lCurrentState.Text = "Текущее состояние";
            this.lCurrentState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lConsoleName
            // 
            this.lConsoleName.AutoSize = true;
            this.lConsoleName.ForeColor = System.Drawing.Color.White;
            this.lConsoleName.Location = new System.Drawing.Point(6, 25);
            this.lConsoleName.Name = "lConsoleName";
            this.lConsoleName.Size = new System.Drawing.Size(78, 21);
            this.lConsoleName.TabIndex = 2;
            this.lConsoleName.Text = "Название";
            // 
            // dgvPriceListOfConsole
            // 
            this.dgvPriceListOfConsole.AllowUserToAddRows = false;
            this.dgvPriceListOfConsole.AllowUserToDeleteRows = false;
            this.dgvPriceListOfConsole.AllowUserToResizeColumns = false;
            this.dgvPriceListOfConsole.AllowUserToResizeRows = false;
            this.dgvPriceListOfConsole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPriceListOfConsole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPriceListOfConsole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPriceListOfConsole.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPriceListOfConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPriceListOfConsole.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPriceListOfConsole.EnableHeadersVisualStyles = false;
            this.dgvPriceListOfConsole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvPriceListOfConsole.Location = new System.Drawing.Point(3, 136);
            this.dgvPriceListOfConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPriceListOfConsole.Name = "dgvPriceListOfConsole";
            this.dgvPriceListOfConsole.ReadOnly = true;
            this.dgvPriceListOfConsole.RowHeadersVisible = false;
            this.dgvPriceListOfConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPriceListOfConsole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceListOfConsole.ShowCellErrors = false;
            this.dgvPriceListOfConsole.ShowCellToolTips = false;
            this.dgvPriceListOfConsole.ShowEditingIcon = false;
            this.dgvPriceListOfConsole.ShowRowErrors = false;
            this.dgvPriceListOfConsole.Size = new System.Drawing.Size(327, 142);
            this.dgvPriceListOfConsole.TabIndex = 1;
            this.dgvPriceListOfConsole.VirtualMode = true;
            // 
            // bApplyChanges
            // 
            this.bApplyChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApplyChanges.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bApplyChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApplyChanges.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApplyChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bApplyChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApplyChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApplyChanges.ForeColor = System.Drawing.Color.White;
            this.bApplyChanges.Location = new System.Drawing.Point(3, 278);
            this.bApplyChanges.Name = "bApplyChanges";
            this.bApplyChanges.Size = new System.Drawing.Size(327, 31);
            this.bApplyChanges.TabIndex = 0;
            this.bApplyChanges.Text = "Внести изменения";
            this.bApplyChanges.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bApplyChanges.UseVisualStyleBackColor = false;
            // 
            // gbAllConsoles
            // 
            this.gbAllConsoles.Controls.Add(this.dgvAllConsoles);
            this.gbAllConsoles.ForeColor = System.Drawing.Color.White;
            this.gbAllConsoles.Location = new System.Drawing.Point(12, 56);
            this.gbAllConsoles.Name = "gbAllConsoles";
            this.gbAllConsoles.Size = new System.Drawing.Size(160, 312);
            this.gbAllConsoles.TabIndex = 2;
            this.gbAllConsoles.TabStop = false;
            this.gbAllConsoles.Text = "Все приставки";
            // 
            // dgvAllConsoles
            // 
            this.dgvAllConsoles.AllowUserToAddRows = false;
            this.dgvAllConsoles.AllowUserToDeleteRows = false;
            this.dgvAllConsoles.AllowUserToResizeColumns = false;
            this.dgvAllConsoles.AllowUserToResizeRows = false;
            this.dgvAllConsoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllConsoles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvAllConsoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllConsoles.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllConsoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllConsoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllConsoles.EnableHeadersVisualStyles = false;
            this.dgvAllConsoles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvAllConsoles.Location = new System.Drawing.Point(3, 25);
            this.dgvAllConsoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAllConsoles.MultiSelect = false;
            this.dgvAllConsoles.Name = "dgvAllConsoles";
            this.dgvAllConsoles.ReadOnly = true;
            this.dgvAllConsoles.RowHeadersVisible = false;
            this.dgvAllConsoles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllConsoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllConsoles.ShowCellErrors = false;
            this.dgvAllConsoles.ShowCellToolTips = false;
            this.dgvAllConsoles.ShowEditingIcon = false;
            this.dgvAllConsoles.ShowRowErrors = false;
            this.dgvAllConsoles.Size = new System.Drawing.Size(154, 284);
            this.dgvAllConsoles.TabIndex = 1;
            this.dgvAllConsoles.VirtualMode = true;
            this.dgvAllConsoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllConsoles_CellClick);
            // 
            // bAddNewConsole
            // 
            this.bAddNewConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewConsole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewConsole.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddNewConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewConsole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddNewConsole.ForeColor = System.Drawing.Color.White;
            this.bAddNewConsole.Location = new System.Drawing.Point(15, 15);
            this.bAddNewConsole.Name = "bAddNewConsole";
            this.bAddNewConsole.Size = new System.Drawing.Size(98, 31);
            this.bAddNewConsole.TabIndex = 2;
            this.bAddNewConsole.Text = "Добавить";
            this.bAddNewConsole.UseVisualStyleBackColor = false;
            this.bAddNewConsole.Click += new System.EventHandler(this.bAddNewConsole_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(119, 15);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(85, 31);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
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
            this.bClose.Location = new System.Drawing.Point(371, 13);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(96, 34);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ConsoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(524, 382);
            this.ControlBox = false;
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAddNewConsole);
            this.Controls.Add(this.gbAllConsoles);
            this.Controls.Add(this.gbConsoleInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console manager";
            this.Load += new System.EventHandler(this.ConsoleManager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConsoleManager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConsoleManager_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConsoleManager_MouseUp);
            this.gbConsoleInfo.ResumeLayout(false);
            this.gbConsoleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceListOfConsole)).EndInit();
            this.gbAllConsoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllConsoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsoleInfo;
        private System.Windows.Forms.ComboBox cbCurrentState;
        private System.Windows.Forms.TextBox tbConsoleName;
        private System.Windows.Forms.Label lOrderTime;
        private System.Windows.Forms.Label lCurrentState;
        private System.Windows.Forms.Label lConsoleName;
        private System.Windows.Forms.DataGridView dgvPriceListOfConsole;
        private System.Windows.Forms.Button bApplyChanges;
        private System.Windows.Forms.GroupBox gbAllConsoles;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAddNewConsole;
        private System.Windows.Forms.DataGridView dgvAllConsoles;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.MaskedTextBox mtbOrderTime;
    }
}