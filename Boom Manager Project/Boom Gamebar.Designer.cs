namespace Boom_Manager_Project
{
    partial class BoomMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoomMainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.bScreenshot = new System.Windows.Forms.Button();
            this.lOperator = new System.Windows.Forms.Label();
            this.lAdmin = new System.Windows.Forms.Label();
            this.bExpenses = new System.Windows.Forms.Button();
            this.bLightCutOff = new System.Windows.Forms.Button();
            this.bBarRevision = new System.Windows.Forms.Button();
            this.bChangeShift = new System.Windows.Forms.Button();
            this.bExtendTime = new System.Windows.Forms.Button();
            this.bSolItemsList = new System.Windows.Forms.Button();
            this.bSellBarItem = new System.Windows.Forms.Button();
            this.bReplace = new System.Windows.Forms.Button();
            this.bCloseSession = new System.Windows.Forms.Button();
            this.bAddNewClient = new System.Windows.Forms.Button();
            this.bSlideMenu = new System.Windows.Forms.Button();
            this.lCurrentDate = new System.Windows.Forms.Label();
            this.lCurrentTime = new System.Windows.Forms.Label();
            this.dgvOpenedSessions = new System.Windows.Forms.DataGridView();
            this.gbManageGroup = new System.Windows.Forms.GroupBox();
            this.bStaff = new System.Windows.Forms.Button();
            this.bCEditlients = new System.Windows.Forms.Button();
            this.bItems = new System.Windows.Forms.Button();
            this.bDiscountSteps = new System.Windows.Forms.Button();
            this.bWithdrawMoney = new System.Windows.Forms.Button();
            this.bExitProgram = new System.Windows.Forms.Button();
            this.bDevicesManager = new System.Windows.Forms.Button();
            this.bAllGlobalSessions = new System.Windows.Forms.Button();
            this.bConsoleManager = new System.Windows.Forms.Button();
            this.bTimezoneManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenedSessions)).BeginInit();
            this.gbManageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.splitContainer.Panel1.Controls.Add(this.button1);
            this.splitContainer.Panel1.Controls.Add(this.bScreenshot);
            this.splitContainer.Panel1.Controls.Add(this.lOperator);
            this.splitContainer.Panel1.Controls.Add(this.lAdmin);
            this.splitContainer.Panel1.Controls.Add(this.bExpenses);
            this.splitContainer.Panel1.Controls.Add(this.bLightCutOff);
            this.splitContainer.Panel1.Controls.Add(this.bBarRevision);
            this.splitContainer.Panel1.Controls.Add(this.bChangeShift);
            this.splitContainer.Panel1.Controls.Add(this.bExtendTime);
            this.splitContainer.Panel1.Controls.Add(this.bSolItemsList);
            this.splitContainer.Panel1.Controls.Add(this.bSellBarItem);
            this.splitContainer.Panel1.Controls.Add(this.bReplace);
            this.splitContainer.Panel1.Controls.Add(this.bCloseSession);
            this.splitContainer.Panel1.Controls.Add(this.bAddNewClient);
            this.splitContainer.Panel1.Controls.Add(this.bSlideMenu);
            this.splitContainer.Panel1.Controls.Add(this.lCurrentDate);
            this.splitContainer.Panel1.Controls.Add(this.lCurrentTime);
            this.splitContainer.Panel1.Controls.Add(this.dgvOpenedSessions);
            this.splitContainer.Panel1MinSize = 1250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.splitContainer.Panel2.Controls.Add(this.gbManageGroup);
            this.splitContainer.Panel2Collapsed = true;
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(1668, 1038);
            this.splitContainer.SplitterDistance = 1537;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1076, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 1008;
            this.button1.Text = "ПОСЛЕДНИЕ СЕССИИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bScreenshot
            // 
            this.bScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bScreenshot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bScreenshot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bScreenshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bScreenshot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bScreenshot.ForeColor = System.Drawing.Color.White;
            this.bScreenshot.Location = new System.Drawing.Point(774, -8);
            this.bScreenshot.Margin = new System.Windows.Forms.Padding(10);
            this.bScreenshot.Name = "bScreenshot";
            this.bScreenshot.Size = new System.Drawing.Size(80, 28);
            this.bScreenshot.TabIndex = 1007;
            this.bScreenshot.Text = "скриншот";
            this.bScreenshot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bScreenshot.UseVisualStyleBackColor = false;
            this.bScreenshot.Visible = false;
            this.bScreenshot.Click += new System.EventHandler(this.bScreenshot_Click);
            this.bScreenshot.MouseLeave += new System.EventHandler(this.bScreenshot_MouseLeave);
            this.bScreenshot.MouseHover += new System.EventHandler(this.bScreenshot_MouseHover);
            // 
            // lOperator
            // 
            this.lOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lOperator.AutoSize = true;
            this.lOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lOperator.ForeColor = System.Drawing.Color.White;
            this.lOperator.Location = new System.Drawing.Point(1375, 38);
            this.lOperator.Name = "lOperator";
            this.lOperator.Size = new System.Drawing.Size(81, 21);
            this.lOperator.TabIndex = 1006;
            this.lOperator.Text = "Оператор";
            this.lOperator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lOperator.Click += new System.EventHandler(this.lOperator_Click);
            // 
            // lAdmin
            // 
            this.lAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lAdmin.AutoSize = true;
            this.lAdmin.ForeColor = System.Drawing.Color.White;
            this.lAdmin.Location = new System.Drawing.Point(1375, 13);
            this.lAdmin.Name = "lAdmin";
            this.lAdmin.Size = new System.Drawing.Size(123, 21);
            this.lAdmin.TabIndex = 1005;
            this.lAdmin.Text = "Администратор";
            this.lAdmin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bExpenses
            // 
            this.bExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExpenses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExpenses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExpenses.ForeColor = System.Drawing.Color.White;
            this.bExpenses.Location = new System.Drawing.Point(1190, 61);
            this.bExpenses.Margin = new System.Windows.Forms.Padding(5);
            this.bExpenses.Name = "bExpenses";
            this.bExpenses.Size = new System.Drawing.Size(83, 44);
            this.bExpenses.TabIndex = 1001;
            this.bExpenses.Text = "ЗАТРАТЫ";
            this.bExpenses.UseVisualStyleBackColor = false;
            this.bExpenses.Click += new System.EventHandler(this.bExpenses_Click);
            // 
            // bLightCutOff
            // 
            this.bLightCutOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLightCutOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bLightCutOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLightCutOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bLightCutOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bLightCutOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bLightCutOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLightCutOff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLightCutOff.ForeColor = System.Drawing.Color.White;
            this.bLightCutOff.Location = new System.Drawing.Point(1283, 61);
            this.bLightCutOff.Margin = new System.Windows.Forms.Padding(5);
            this.bLightCutOff.Name = "bLightCutOff";
            this.bLightCutOff.Size = new System.Drawing.Size(83, 44);
            this.bLightCutOff.TabIndex = 1001;
            this.bLightCutOff.Text = "ВЫКЛ СВЕТ";
            this.bLightCutOff.UseVisualStyleBackColor = false;
            this.bLightCutOff.Click += new System.EventHandler(this.bLightCutOff_Click);
            // 
            // bBarRevision
            // 
            this.bBarRevision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBarRevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bBarRevision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBarRevision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bBarRevision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bBarRevision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bBarRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarRevision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBarRevision.ForeColor = System.Drawing.Color.White;
            this.bBarRevision.Location = new System.Drawing.Point(1283, 7);
            this.bBarRevision.Margin = new System.Windows.Forms.Padding(5);
            this.bBarRevision.Name = "bBarRevision";
            this.bBarRevision.Size = new System.Drawing.Size(83, 44);
            this.bBarRevision.TabIndex = 1001;
            this.bBarRevision.Text = "РЕВИЗИЯ";
            this.bBarRevision.UseVisualStyleBackColor = false;
            this.bBarRevision.Click += new System.EventHandler(this.bBarRevision_Click);
            // 
            // bChangeShift
            // 
            this.bChangeShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bChangeShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bChangeShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bChangeShift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bChangeShift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bChangeShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bChangeShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangeShift.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChangeShift.ForeColor = System.Drawing.Color.White;
            this.bChangeShift.Location = new System.Drawing.Point(1190, 7);
            this.bChangeShift.Margin = new System.Windows.Forms.Padding(5);
            this.bChangeShift.Name = "bChangeShift";
            this.bChangeShift.Size = new System.Drawing.Size(83, 44);
            this.bChangeShift.TabIndex = 1001;
            this.bChangeShift.Text = "СМЕНА";
            this.bChangeShift.UseVisualStyleBackColor = false;
            this.bChangeShift.Click += new System.EventHandler(this.bChangeShift_Click);
            this.bChangeShift.MouseLeave += new System.EventHandler(this.bChangeShift_MouseLeave);
            this.bChangeShift.MouseHover += new System.EventHandler(this.bChangeShift_MouseHover);
            // 
            // bExtendTime
            // 
            this.bExtendTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExtendTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExtendTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExtendTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bExtendTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExtendTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExtendTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExtendTime.ForeColor = System.Drawing.Color.White;
            this.bExtendTime.Location = new System.Drawing.Point(122, 38);
            this.bExtendTime.Margin = new System.Windows.Forms.Padding(10);
            this.bExtendTime.Name = "bExtendTime";
            this.bExtendTime.Size = new System.Drawing.Size(98, 48);
            this.bExtendTime.TabIndex = 1000;
            this.bExtendTime.Text = "ПРОДЛИТЬ ВРЕМЯ";
            this.bExtendTime.UseVisualStyleBackColor = false;
            this.bExtendTime.Click += new System.EventHandler(this.bExtendTime_Click);
            this.bExtendTime.MouseLeave += new System.EventHandler(this.bExtendTime_MouseLeave);
            this.bExtendTime.MouseHover += new System.EventHandler(this.bExtendTime_MouseHover);
            // 
            // bSolItemsList
            // 
            this.bSolItemsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSolItemsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSolItemsList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSolItemsList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bSolItemsList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSolItemsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSolItemsList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSolItemsList.ForeColor = System.Drawing.Color.White;
            this.bSolItemsList.Location = new System.Drawing.Point(582, 39);
            this.bSolItemsList.Margin = new System.Windows.Forms.Padding(10);
            this.bSolItemsList.Name = "bSolItemsList";
            this.bSolItemsList.Size = new System.Drawing.Size(70, 48);
            this.bSolItemsList.TabIndex = 8;
            this.bSolItemsList.Text = "БАР";
            this.bSolItemsList.UseVisualStyleBackColor = false;
            this.bSolItemsList.Click += new System.EventHandler(this.bSolItemsList_Click);
            // 
            // bSellBarItem
            // 
            this.bSellBarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSellBarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSellBarItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSellBarItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bSellBarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bSellBarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSellBarItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSellBarItem.ForeColor = System.Drawing.Color.White;
            this.bSellBarItem.Location = new System.Drawing.Point(357, 75);
            this.bSellBarItem.Margin = new System.Windows.Forms.Padding(10);
            this.bSellBarItem.Name = "bSellBarItem";
            this.bSellBarItem.Size = new System.Drawing.Size(97, 48);
            this.bSellBarItem.TabIndex = 8;
            this.bSellBarItem.Text = "ПРОДАТЬ";
            this.bSellBarItem.UseVisualStyleBackColor = false;
            this.bSellBarItem.Click += new System.EventHandler(this.bSellBarItem_Click);
            // 
            // bReplace
            // 
            this.bReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReplace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReplace.ForeColor = System.Drawing.Color.White;
            this.bReplace.Location = new System.Drawing.Point(357, 7);
            this.bReplace.Margin = new System.Windows.Forms.Padding(10);
            this.bReplace.Name = "bReplace";
            this.bReplace.Size = new System.Drawing.Size(97, 48);
            this.bReplace.TabIndex = 8;
            this.bReplace.Text = "СМЕНА ПРИСТАВКИ";
            this.bReplace.UseVisualStyleBackColor = false;
            this.bReplace.Click += new System.EventHandler(this.bReplace_Click);
            // 
            // bCloseSession
            // 
            this.bCloseSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCloseSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCloseSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCloseSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCloseSession.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCloseSession.ForeColor = System.Drawing.Color.White;
            this.bCloseSession.Location = new System.Drawing.Point(240, 39);
            this.bCloseSession.Margin = new System.Windows.Forms.Padding(10);
            this.bCloseSession.Name = "bCloseSession";
            this.bCloseSession.Size = new System.Drawing.Size(97, 48);
            this.bCloseSession.TabIndex = 8;
            this.bCloseSession.Text = "ЗАКРЫТЬ СЕССИЮ";
            this.bCloseSession.UseVisualStyleBackColor = false;
            this.bCloseSession.Click += new System.EventHandler(this.bCloseSession_Click);
            this.bCloseSession.MouseLeave += new System.EventHandler(this.bCloseSession_MouseLeave);
            this.bCloseSession.MouseHover += new System.EventHandler(this.bCloseSession_MouseHover);
            // 
            // bAddNewClient
            // 
            this.bAddNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAddNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddNewClient.ForeColor = System.Drawing.Color.White;
            this.bAddNewClient.Location = new System.Drawing.Point(4, 38);
            this.bAddNewClient.Margin = new System.Windows.Forms.Padding(10);
            this.bAddNewClient.Name = "bAddNewClient";
            this.bAddNewClient.Size = new System.Drawing.Size(98, 48);
            this.bAddNewClient.TabIndex = 7;
            this.bAddNewClient.Text = "ОТКРЫТЬ СЕССИЮ";
            this.bAddNewClient.UseVisualStyleBackColor = false;
            this.bAddNewClient.Click += new System.EventHandler(this.bAddNewSession_Click);
            this.bAddNewClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bAddNewClient_MouseDown);
            this.bAddNewClient.MouseLeave += new System.EventHandler(this.bAddNewClient_MouseLeave);
            this.bAddNewClient.MouseHover += new System.EventHandler(this.bAddNewClient_MouseHover);
            // 
            // bSlideMenu
            // 
            this.bSlideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSlideMenu.FlatAppearance.BorderSize = 0;
            this.bSlideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSlideMenu.Location = new System.Drawing.Point(1656, 0);
            this.bSlideMenu.Name = "bSlideMenu";
            this.bSlideMenu.Size = new System.Drawing.Size(10, 36);
            this.bSlideMenu.TabIndex = 999;
            this.bSlideMenu.TabStop = false;
            this.bSlideMenu.Text = "<";
            this.bSlideMenu.UseVisualStyleBackColor = true;
            this.bSlideMenu.Click += new System.EventHandler(this.bSlideMenu_Click);
            // 
            // lCurrentDate
            // 
            this.lCurrentDate.AutoSize = true;
            this.lCurrentDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lCurrentDate.Location = new System.Drawing.Point(730, 93);
            this.lCurrentDate.Name = "lCurrentDate";
            this.lCurrentDate.Size = new System.Drawing.Size(92, 30);
            this.lCurrentDate.TabIndex = 5;
            this.lCurrentDate.Text = "CurDate";
            this.lCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lCurrentTime
            // 
            this.lCurrentTime.AutoSize = true;
            this.lCurrentTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lCurrentTime.Location = new System.Drawing.Point(665, 18);
            this.lCurrentTime.Name = "lCurrentTime";
            this.lCurrentTime.Size = new System.Drawing.Size(291, 86);
            this.lCurrentTime.TabIndex = 4;
            this.lCurrentTime.Text = "CurTime";
            this.lCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lCurrentTime.MouseLeave += new System.EventHandler(this.lCurrentTime_MouseLeave);
            this.lCurrentTime.MouseHover += new System.EventHandler(this.lCurrentTime_MouseHover);
            // 
            // dgvOpenedSessions
            // 
            this.dgvOpenedSessions.AllowUserToAddRows = false;
            this.dgvOpenedSessions.AllowUserToDeleteRows = false;
            this.dgvOpenedSessions.AllowUserToResizeColumns = false;
            this.dgvOpenedSessions.AllowUserToResizeRows = false;
            this.dgvOpenedSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenedSessions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvOpenedSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOpenedSessions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOpenedSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpenedSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpenedSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenedSessions.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOpenedSessions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOpenedSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOpenedSessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOpenedSessions.EnableHeadersVisualStyles = false;
            this.dgvOpenedSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dgvOpenedSessions.Location = new System.Drawing.Point(0, 127);
            this.dgvOpenedSessions.MultiSelect = false;
            this.dgvOpenedSessions.Name = "dgvOpenedSessions";
            this.dgvOpenedSessions.ReadOnly = true;
            this.dgvOpenedSessions.RowHeadersVisible = false;
            this.dgvOpenedSessions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOpenedSessions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOpenedSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpenedSessions.Size = new System.Drawing.Size(1666, 909);
            this.dgvOpenedSessions.TabIndex = 3;
            this.dgvOpenedSessions.TabStop = false;
            this.dgvOpenedSessions.VirtualMode = true;
            this.dgvOpenedSessions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOpenedSessions_CellFormatting);
            // 
            // gbManageGroup
            // 
            this.gbManageGroup.Controls.Add(this.bStaff);
            this.gbManageGroup.Controls.Add(this.bCEditlients);
            this.gbManageGroup.Controls.Add(this.bItems);
            this.gbManageGroup.Controls.Add(this.bDiscountSteps);
            this.gbManageGroup.Controls.Add(this.bWithdrawMoney);
            this.gbManageGroup.Controls.Add(this.bExitProgram);
            this.gbManageGroup.Controls.Add(this.bDevicesManager);
            this.gbManageGroup.Controls.Add(this.bAllGlobalSessions);
            this.gbManageGroup.Controls.Add(this.bConsoleManager);
            this.gbManageGroup.Controls.Add(this.bTimezoneManager);
            this.gbManageGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbManageGroup.ForeColor = System.Drawing.Color.White;
            this.gbManageGroup.Location = new System.Drawing.Point(0, 0);
            this.gbManageGroup.Name = "gbManageGroup";
            this.gbManageGroup.Size = new System.Drawing.Size(94, 98);
            this.gbManageGroup.TabIndex = 4;
            this.gbManageGroup.TabStop = false;
            this.gbManageGroup.Text = "MANAGE";
            // 
            // bStaff
            // 
            this.bStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bStaff.BackgroundImage")));
            this.bStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.bStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bStaff.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStaff.ForeColor = System.Drawing.Color.White;
            this.bStaff.Location = new System.Drawing.Point(3, 313);
            this.bStaff.Name = "bStaff";
            this.bStaff.Size = new System.Drawing.Size(88, 36);
            this.bStaff.TabIndex = 14;
            this.bStaff.Text = "Персонал";
            this.bStaff.UseVisualStyleBackColor = false;
            this.bStaff.Click += new System.EventHandler(this.bStaff_Click);
            // 
            // bCEditlients
            // 
            this.bCEditlients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCEditlients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCEditlients.BackgroundImage")));
            this.bCEditlients.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCEditlients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bCEditlients.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCEditlients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bCEditlients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bCEditlients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCEditlients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCEditlients.ForeColor = System.Drawing.Color.White;
            this.bCEditlients.Location = new System.Drawing.Point(3, 277);
            this.bCEditlients.Name = "bCEditlients";
            this.bCEditlients.Size = new System.Drawing.Size(88, 36);
            this.bCEditlients.TabIndex = 13;
            this.bCEditlients.Text = "Клиенты";
            this.bCEditlients.UseVisualStyleBackColor = false;
            this.bCEditlients.Click += new System.EventHandler(this.bCEditlients_Click);
            // 
            // bItems
            // 
            this.bItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bItems.BackgroundImage")));
            this.bItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.bItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bItems.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bItems.ForeColor = System.Drawing.Color.White;
            this.bItems.Location = new System.Drawing.Point(3, 241);
            this.bItems.Name = "bItems";
            this.bItems.Size = new System.Drawing.Size(88, 36);
            this.bItems.TabIndex = 12;
            this.bItems.Text = "Предметы";
            this.bItems.UseVisualStyleBackColor = false;
            this.bItems.Click += new System.EventHandler(this.bItems_Click);
            // 
            // bDiscountSteps
            // 
            this.bDiscountSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDiscountSteps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDiscountSteps.BackgroundImage")));
            this.bDiscountSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDiscountSteps.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bDiscountSteps.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDiscountSteps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bDiscountSteps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDiscountSteps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDiscountSteps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDiscountSteps.ForeColor = System.Drawing.Color.White;
            this.bDiscountSteps.Location = new System.Drawing.Point(3, 205);
            this.bDiscountSteps.Name = "bDiscountSteps";
            this.bDiscountSteps.Size = new System.Drawing.Size(88, 36);
            this.bDiscountSteps.TabIndex = 11;
            this.bDiscountSteps.Text = "Уровни скидок";
            this.bDiscountSteps.UseVisualStyleBackColor = false;
            this.bDiscountSteps.Click += new System.EventHandler(this.bDiscountSteps_Click);
            // 
            // bWithdrawMoney
            // 
            this.bWithdrawMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bWithdrawMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bWithdrawMoney.BackgroundImage")));
            this.bWithdrawMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.bWithdrawMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bWithdrawMoney.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bWithdrawMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bWithdrawMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bWithdrawMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bWithdrawMoney.ForeColor = System.Drawing.Color.White;
            this.bWithdrawMoney.Location = new System.Drawing.Point(3, 169);
            this.bWithdrawMoney.Name = "bWithdrawMoney";
            this.bWithdrawMoney.Size = new System.Drawing.Size(88, 36);
            this.bWithdrawMoney.TabIndex = 9;
            this.bWithdrawMoney.Text = "Снять";
            this.bWithdrawMoney.UseVisualStyleBackColor = false;
            this.bWithdrawMoney.Click += new System.EventHandler(this.bWithdrawMoney_Click);
            // 
            // bExitProgram
            // 
            this.bExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExitProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExitProgram.BackgroundImage")));
            this.bExitProgram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bExitProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bExitProgram.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExitProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bExitProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExitProgram.ForeColor = System.Drawing.Color.White;
            this.bExitProgram.Location = new System.Drawing.Point(3, 62);
            this.bExitProgram.Name = "bExitProgram";
            this.bExitProgram.Size = new System.Drawing.Size(88, 33);
            this.bExitProgram.TabIndex = 8;
            this.bExitProgram.Text = "EXIT";
            this.bExitProgram.UseVisualStyleBackColor = false;
            this.bExitProgram.Click += new System.EventHandler(this.bExitProgram_Click);
            // 
            // bDevicesManager
            // 
            this.bDevicesManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDevicesManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDevicesManager.BackgroundImage")));
            this.bDevicesManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDevicesManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bDevicesManager.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDevicesManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bDevicesManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bDevicesManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDevicesManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDevicesManager.ForeColor = System.Drawing.Color.White;
            this.bDevicesManager.Location = new System.Drawing.Point(3, 133);
            this.bDevicesManager.Name = "bDevicesManager";
            this.bDevicesManager.Size = new System.Drawing.Size(88, 36);
            this.bDevicesManager.TabIndex = 7;
            this.bDevicesManager.Text = "Устройства";
            this.bDevicesManager.UseVisualStyleBackColor = false;
            this.bDevicesManager.Click += new System.EventHandler(this.bDevicesManager_Click_1);
            // 
            // bAllGlobalSessions
            // 
            this.bAllGlobalSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAllGlobalSessions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAllGlobalSessions.BackgroundImage")));
            this.bAllGlobalSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAllGlobalSessions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAllGlobalSessions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAllGlobalSessions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bAllGlobalSessions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bAllGlobalSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAllGlobalSessions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAllGlobalSessions.ForeColor = System.Drawing.Color.White;
            this.bAllGlobalSessions.Location = new System.Drawing.Point(3, 97);
            this.bAllGlobalSessions.Name = "bAllGlobalSessions";
            this.bAllGlobalSessions.Size = new System.Drawing.Size(88, 36);
            this.bAllGlobalSessions.TabIndex = 6;
            this.bAllGlobalSessions.Text = "Смены";
            this.bAllGlobalSessions.UseVisualStyleBackColor = false;
            this.bAllGlobalSessions.Click += new System.EventHandler(this.bAllGlobalSessions_Click_1);
            // 
            // bConsoleManager
            // 
            this.bConsoleManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bConsoleManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bConsoleManager.BackgroundImage")));
            this.bConsoleManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsoleManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bConsoleManager.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bConsoleManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bConsoleManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bConsoleManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsoleManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bConsoleManager.ForeColor = System.Drawing.Color.White;
            this.bConsoleManager.Location = new System.Drawing.Point(3, 61);
            this.bConsoleManager.Name = "bConsoleManager";
            this.bConsoleManager.Size = new System.Drawing.Size(88, 36);
            this.bConsoleManager.TabIndex = 5;
            this.bConsoleManager.Text = "Приставки";
            this.bConsoleManager.UseVisualStyleBackColor = false;
            this.bConsoleManager.Click += new System.EventHandler(this.bConsoleManager_Click_1);
            // 
            // bTimezoneManager
            // 
            this.bTimezoneManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bTimezoneManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTimezoneManager.BackgroundImage")));
            this.bTimezoneManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTimezoneManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bTimezoneManager.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bTimezoneManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bTimezoneManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(91)))), ((int)(((byte)(103)))));
            this.bTimezoneManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTimezoneManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTimezoneManager.ForeColor = System.Drawing.Color.White;
            this.bTimezoneManager.Location = new System.Drawing.Point(3, 25);
            this.bTimezoneManager.Name = "bTimezoneManager";
            this.bTimezoneManager.Size = new System.Drawing.Size(88, 36);
            this.bTimezoneManager.TabIndex = 4;
            this.bTimezoneManager.Text = "Вр зоны";
            this.bTimezoneManager.UseVisualStyleBackColor = false;
            this.bTimezoneManager.Click += new System.EventHandler(this.bTimezoneManager_Click_1);
            // 
            // BoomMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1668, 1038);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoomMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boom Gamebar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoomMainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoomMainForm_FormClosed);
            this.Load += new System.EventHandler(this.BoomMainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoomMainForm_KeyPress);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenedSessions)).EndInit();
            this.gbManageGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lCurrentDate;
        private System.Windows.Forms.Label lCurrentTime;
        private System.Windows.Forms.DataGridView dgvOpenedSessions;
        private System.Windows.Forms.Button bSlideMenu;
        private System.Windows.Forms.Button bAddNewClient;
        private System.Windows.Forms.Button bCloseSession;
        private System.Windows.Forms.Button bExtendTime;
        private System.Windows.Forms.Button bChangeShift;
        private System.Windows.Forms.GroupBox gbManageGroup;
        private System.Windows.Forms.Button bDevicesManager;
        private System.Windows.Forms.Button bAllGlobalSessions;
        private System.Windows.Forms.Button bConsoleManager;
        private System.Windows.Forms.Button bTimezoneManager;
        private System.Windows.Forms.Button bExitProgram;
        private System.Windows.Forms.Button bWithdrawMoney;
        private System.Windows.Forms.Button bDiscountSteps;
        private System.Windows.Forms.Button bExpenses;
        private System.Windows.Forms.Label lOperator;
        private System.Windows.Forms.Label lAdmin;
        private System.Windows.Forms.Button bReplace;
        private System.Windows.Forms.Button bItems;
        private System.Windows.Forms.Button bLightCutOff;
        private System.Windows.Forms.Button bSellBarItem;
        private System.Windows.Forms.Button bBarRevision;
        private System.Windows.Forms.Button bSolItemsList;
        private System.Windows.Forms.Button bCEditlients;
        private System.Windows.Forms.Button bScreenshot;
        private System.Windows.Forms.Button bStaff;
        private System.Windows.Forms.Button button1;
    }
}

