namespace Boom_Manager_Project
{
    partial class CreateNewDiscountStep
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
            this.lName = new System.Windows.Forms.Label();
            this.lRequirement = new System.Windows.Forms.Label();
            this.lDiscount = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRequirements = new System.Windows.Forms.TextBox();
            this.numUpdDiscount = new System.Windows.Forms.NumericUpDown();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lSom = new System.Windows.Forms.Label();
            this.lDisc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 48);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(78, 21);
            this.lName.TabIndex = 0;
            this.lName.Text = "Название";
            // 
            // lRequirement
            // 
            this.lRequirement.AutoSize = true;
            this.lRequirement.Location = new System.Drawing.Point(12, 83);
            this.lRequirement.Name = "lRequirement";
            this.lRequirement.Size = new System.Drawing.Size(131, 21);
            this.lRequirement.TabIndex = 0;
            this.lRequirement.Text = "Требуемая сумма";
            // 
            // lDiscount
            // 
            this.lDiscount.AutoSize = true;
            this.lDiscount.Location = new System.Drawing.Point(12, 118);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(59, 21);
            this.lDiscount.TabIndex = 0;
            this.lDiscount.Text = "Скидка";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(153, 46);
            this.tbName.MaxLength = 25;
            this.tbName.Name = "tbName";
            this.tbName.ShortcutsEnabled = false;
            this.tbName.Size = new System.Drawing.Size(178, 29);
            this.tbName.TabIndex = 0;
            // 
            // tbRequirements
            // 
            this.tbRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRequirements.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbRequirements.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbRequirements.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRequirements.ForeColor = System.Drawing.Color.White;
            this.tbRequirements.Location = new System.Drawing.Point(153, 81);
            this.tbRequirements.MaxLength = 6;
            this.tbRequirements.Name = "tbRequirements";
            this.tbRequirements.ShortcutsEnabled = false;
            this.tbRequirements.Size = new System.Drawing.Size(127, 29);
            this.tbRequirements.TabIndex = 1;
            // 
            // numUpdDiscount
            // 
            this.numUpdDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpdDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdDiscount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdDiscount.ForeColor = System.Drawing.Color.White;
            this.numUpdDiscount.Location = new System.Drawing.Point(153, 116);
            this.numUpdDiscount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdDiscount.Name = "numUpdDiscount";
            this.numUpdDiscount.Size = new System.Drawing.Size(54, 29);
            this.numUpdDiscount.TabIndex = 2;
            this.numUpdDiscount.ThousandsSeparator = true;
            this.numUpdDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bCreate
            // 
            this.bCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.ForeColor = System.Drawing.Color.White;
            this.bCreate.Location = new System.Drawing.Point(11, 158);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(96, 38);
            this.bCreate.TabIndex = 3;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
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
            this.bCancel.Location = new System.Drawing.Point(234, 158);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(96, 38);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "СОЗДАТЬ УРОВЕНЬ СКИДКИ";
            // 
            // lSom
            // 
            this.lSom.AutoSize = true;
            this.lSom.Location = new System.Drawing.Point(286, 83);
            this.lSom.Name = "lSom";
            this.lSom.Size = new System.Drawing.Size(36, 21);
            this.lSom.TabIndex = 33;
            this.lSom.Text = "сом";
            // 
            // lDisc
            // 
            this.lDisc.AutoSize = true;
            this.lDisc.Location = new System.Drawing.Point(213, 118);
            this.lDisc.Name = "lDisc";
            this.lDisc.Size = new System.Drawing.Size(23, 21);
            this.lDisc.TabIndex = 33;
            this.lDisc.Text = "%";
            // 
            // CreateNewDiscountStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(342, 208);
            this.ControlBox = false;
            this.Controls.Add(this.lDisc);
            this.Controls.Add(this.lSom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.numUpdDiscount);
            this.Controls.Add(this.tbRequirements);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lDiscount);
            this.Controls.Add(this.lRequirement);
            this.Controls.Add(this.lName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewDiscountStep";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewDiscountStep";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateNewDiscountStep_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateNewDiscountStep_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateNewDiscountStep_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lRequirement;
        private System.Windows.Forms.Label lDiscount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRequirements;
        private System.Windows.Forms.NumericUpDown numUpdDiscount;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSom;
        private System.Windows.Forms.Label lDisc;
    }
}