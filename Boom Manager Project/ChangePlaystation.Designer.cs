namespace Boom_Manager_Project.DataBaseClasses
{
    partial class ChangePlaystation
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
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.cbPlaystationId = new System.Windows.Forms.ComboBox();
            this.lNewPlaystationId = new System.Windows.Forms.Label();
            this.lOldPlaystationId = new System.Windows.Forms.Label();
            this.tbOldPLaystationId = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddSession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbComments
            // 
            this.rtbComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComments.DetectUrls = false;
            this.rtbComments.ForeColor = System.Drawing.Color.White;
            this.rtbComments.Location = new System.Drawing.Point(28, 152);
            this.rtbComments.MaxLength = 100;
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.ShortcutsEnabled = false;
            this.rtbComments.Size = new System.Drawing.Size(328, 149);
            this.rtbComments.TabIndex = 0;
            this.rtbComments.Text = "";
            // 
            // cbPlaystationId
            // 
            this.cbPlaystationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlaystationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbPlaystationId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlaystationId.ForeColor = System.Drawing.Color.White;
            this.cbPlaystationId.Location = new System.Drawing.Point(215, 70);
            this.cbPlaystationId.Name = "cbPlaystationId";
            this.cbPlaystationId.Size = new System.Drawing.Size(95, 29);
            this.cbPlaystationId.TabIndex = 21;
            // 
            // lNewPlaystationId
            // 
            this.lNewPlaystationId.AutoSize = true;
            this.lNewPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNewPlaystationId.ForeColor = System.Drawing.Color.White;
            this.lNewPlaystationId.Location = new System.Drawing.Point(24, 73);
            this.lNewPlaystationId.Name = "lNewPlaystationId";
            this.lNewPlaystationId.Size = new System.Drawing.Size(156, 21);
            this.lNewPlaystationId.TabIndex = 22;
            this.lNewPlaystationId.Text = "Новый № приставки";
            // 
            // lOldPlaystationId
            // 
            this.lOldPlaystationId.AutoSize = true;
            this.lOldPlaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOldPlaystationId.ForeColor = System.Drawing.Color.White;
            this.lOldPlaystationId.Location = new System.Drawing.Point(24, 38);
            this.lOldPlaystationId.Name = "lOldPlaystationId";
            this.lOldPlaystationId.Size = new System.Drawing.Size(136, 21);
            this.lOldPlaystationId.TabIndex = 22;
            this.lOldPlaystationId.Text = "№ приставки был";
            // 
            // tbOldPLaystationId
            // 
            this.tbOldPLaystationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbOldPLaystationId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOldPLaystationId.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbOldPLaystationId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOldPLaystationId.ForeColor = System.Drawing.Color.White;
            this.tbOldPLaystationId.Location = new System.Drawing.Point(215, 35);
            this.tbOldPLaystationId.MaxLength = 50;
            this.tbOldPLaystationId.Name = "tbOldPLaystationId";
            this.tbOldPLaystationId.ReadOnly = true;
            this.tbOldPLaystationId.ShortcutsEnabled = false;
            this.tbOldPLaystationId.Size = new System.Drawing.Size(95, 29);
            this.tbOldPLaystationId.TabIndex = 23;
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
            this.bCancel.Location = new System.Drawing.Point(12, 314);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(96, 38);
            this.bCancel.TabIndex = 25;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddSession
            // 
            this.bAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddSession.ForeColor = System.Drawing.Color.White;
            this.bAddSession.Location = new System.Drawing.Point(279, 314);
            this.bAddSession.Name = "bAddSession";
            this.bAddSession.Size = new System.Drawing.Size(96, 38);
            this.bAddSession.TabIndex = 24;
            this.bAddSession.Text = "Добавить";
            this.bAddSession.UseVisualStyleBackColor = false;
            this.bAddSession.Click += new System.EventHandler(this.bAddSession_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Комментарии";
            // 
            // ChangePlaystation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAddSession);
            this.Controls.Add(this.tbOldPLaystationId);
            this.Controls.Add(this.lOldPlaystationId);
            this.Controls.Add(this.cbPlaystationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNewPlaystationId);
            this.Controls.Add(this.rtbComments);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePlaystation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePlaystation";
            this.Load += new System.EventHandler(this.ChangePlaystation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.ComboBox cbPlaystationId;
        private System.Windows.Forms.Label lNewPlaystationId;
        private System.Windows.Forms.Label lOldPlaystationId;
        private System.Windows.Forms.TextBox tbOldPLaystationId;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddSession;
        private System.Windows.Forms.Label label1;
    }
}