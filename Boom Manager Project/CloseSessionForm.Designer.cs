namespace Boom_Manager_Project
{
    partial class CloseSessionForm
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
            this.bClientHasGone = new System.Windows.Forms.Button();
            this.bProblems = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lQuestion = new System.Windows.Forms.Label();
            this.lProbleDescription = new System.Windows.Forms.Label();
            this.bSubmitAndClose = new System.Windows.Forms.Button();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bClientHasGone
            // 
            this.bClientHasGone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClientHasGone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClientHasGone.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClientHasGone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bClientHasGone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bClientHasGone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClientHasGone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClientHasGone.ForeColor = System.Drawing.Color.White;
            this.bClientHasGone.Location = new System.Drawing.Point(12, 134);
            this.bClientHasGone.Name = "bClientHasGone";
            this.bClientHasGone.Size = new System.Drawing.Size(147, 54);
            this.bClientHasGone.TabIndex = 0;
            this.bClientHasGone.Text = "Клиент ушел раньше";
            this.bClientHasGone.UseVisualStyleBackColor = false;
            this.bClientHasGone.Click += new System.EventHandler(this.bClientHasGone_Click);
            // 
            // bProblems
            // 
            this.bProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bProblems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bProblems.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bProblems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bProblems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bProblems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProblems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bProblems.ForeColor = System.Drawing.Color.White;
            this.bProblems.Location = new System.Drawing.Point(179, 201);
            this.bProblems.Name = "bProblems";
            this.bProblems.Size = new System.Drawing.Size(102, 32);
            this.bProblems.TabIndex = 1;
            this.bProblems.Text = "Проблема";
            this.bProblems.UseVisualStyleBackColor = false;
            this.bProblems.Click += new System.EventHandler(this.bProblems_Click);
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
            this.bCancel.Location = new System.Drawing.Point(314, 141);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(138, 41);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.ForeColor = System.Drawing.Color.White;
            this.lQuestion.Location = new System.Drawing.Point(61, 54);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(71, 21);
            this.lQuestion.TabIndex = 3;
            this.lQuestion.Text = "Question";
            // 
            // lProbleDescription
            // 
            this.lProbleDescription.AutoSize = true;
            this.lProbleDescription.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProbleDescription.Location = new System.Drawing.Point(98, 257);
            this.lProbleDescription.Name = "lProbleDescription";
            this.lProbleDescription.Size = new System.Drawing.Size(189, 20);
            this.lProbleDescription.TabIndex = 8;
            this.lProbleDescription.Text = "Please, describe the problem";
            // 
            // bSubmitAndClose
            // 
            this.bSubmitAndClose.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSubmitAndClose.Location = new System.Drawing.Point(136, 405);
            this.bSubmitAndClose.Name = "bSubmitAndClose";
            this.bSubmitAndClose.Size = new System.Drawing.Size(213, 34);
            this.bSubmitAndClose.TabIndex = 7;
            this.bSubmitAndClose.Text = "Submit and close";
            this.bSubmitAndClose.UseVisualStyleBackColor = true;
            this.bSubmitAndClose.Click += new System.EventHandler(this.bSubmitAndClose_Click);
            // 
            // rtbComments
            // 
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbComments.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbComments.Location = new System.Drawing.Point(12, 288);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(440, 111);
            this.rtbComments.TabIndex = 6;
            this.rtbComments.Text = "";
            // 
            // CloseSessionForm
            // 
            this.AcceptButton = this.bClientHasGone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(464, 242);
            this.ControlBox = false;
            this.Controls.Add(this.lProbleDescription);
            this.Controls.Add(this.bSubmitAndClose);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bProblems);
            this.Controls.Add(this.bClientHasGone);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseSessionForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close Session";
            this.Load += new System.EventHandler(this.CloseSessionForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseSessionForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseSessionForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseSessionForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClientHasGone;
        private System.Windows.Forms.Button bProblems;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lProbleDescription;
        private System.Windows.Forms.Button bSubmitAndClose;
        private System.Windows.Forms.RichTextBox rtbComments;
    }
}