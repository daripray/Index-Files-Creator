using System.Windows.Forms;

namespace File_Creator
{
    partial class MainForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TabBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblProgressCopy = new System.Windows.Forms.Label();
            this.pgBarCopy = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBrowseCopy = new System.Windows.Forms.Button();
            this.txtRootPathCopy = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.dataGridViewCopy = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcludeParamsCopy = new System.Windows.Forms.TextBox();
            this.chkExcludeCopy = new System.Windows.Forms.CheckBox();
            this.btnScanCopy = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblProgressDelete = new System.Windows.Forms.Label();
            this.pgBarDelete = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRootPathDelete = new System.Windows.Forms.TextBox();
            this.btnBrowseDelete = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkExcludeDelete = new System.Windows.Forms.CheckBox();
            this.txtExcludeParamsDelete = new System.Windows.Forms.TextBox();
            this.btnScanDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgWorkerCopy = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerDelete = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TabBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCopy)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // TabBox
            // 
            this.TabBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabBox.Controls.Add(this.tabPage1);
            this.TabBox.Controls.Add(this.tabPage2);
            this.TabBox.Controls.Add(this.tabPage3);
            this.TabBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabBox.Location = new System.Drawing.Point(12, 12);
            this.TabBox.Name = "TabBox";
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(834, 496);
            this.TabBox.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblProgressCopy);
            this.tabPage1.Controls.Add(this.pgBarCopy);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 467);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "COPY";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblProgressCopy
            // 
            this.lblProgressCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressCopy.AutoSize = true;
            this.lblProgressCopy.Location = new System.Drawing.Point(655, 442);
            this.lblProgressCopy.Name = "lblProgressCopy";
            this.lblProgressCopy.Size = new System.Drawing.Size(104, 16);
            this.lblProgressCopy.TabIndex = 13;
            this.lblProgressCopy.Text = "Proses: 0/0 (0%)";
            // 
            // pgBarCopy
            // 
            this.pgBarCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgBarCopy.Location = new System.Drawing.Point(9, 438);
            this.pgBarCopy.Name = "pgBarCopy";
            this.pgBarCopy.Size = new System.Drawing.Size(640, 23);
            this.pgBarCopy.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnBrowseCopy);
            this.panel3.Controls.Add(this.txtRootPathCopy);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 45);
            this.panel3.TabIndex = 7;
            // 
            // btnBrowseCopy
            // 
            this.btnBrowseCopy.Location = new System.Drawing.Point(3, 7);
            this.btnBrowseCopy.Name = "btnBrowseCopy";
            this.btnBrowseCopy.Size = new System.Drawing.Size(81, 32);
            this.btnBrowseCopy.TabIndex = 3;
            this.btnBrowseCopy.Text = "Browse";
            this.btnBrowseCopy.UseVisualStyleBackColor = true;
            this.btnBrowseCopy.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRootPathCopy
            // 
            this.txtRootPathCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootPathCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRootPathCopy.Location = new System.Drawing.Point(90, 9);
            this.txtRootPathCopy.Name = "txtRootPathCopy";
            this.txtRootPathCopy.Size = new System.Drawing.Size(721, 26);
            this.txtRootPathCopy.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(252, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 375);
            this.panel2.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnCopyAll);
            this.groupBox4.Controls.Add(this.dataGridViewCopy);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 369);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasil";
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopyAll.Location = new System.Drawing.Point(6, 19);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(135, 45);
            this.btnCopyAll.TabIndex = 1;
            this.btnCopyAll.Text = "Copy ke Semua";
            this.btnCopyAll.UseVisualStyleBackColor = false;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // dataGridViewCopy
            // 
            this.dataGridViewCopy.AllowUserToAddRows = false;
            this.dataGridViewCopy.AllowUserToDeleteRows = false;
            this.dataGridViewCopy.AllowUserToOrderColumns = true;
            this.dataGridViewCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCopy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.statusCopy,
            this.dataGridViewButtonColumn2});
            this.dataGridViewCopy.Location = new System.Drawing.Point(6, 70);
            this.dataGridViewCopy.Name = "dataGridViewCopy";
            this.dataGridViewCopy.ReadOnly = true;
            this.dataGridViewCopy.Size = new System.Drawing.Size(550, 293);
            this.dataGridViewCopy.TabIndex = 2;
            this.dataGridViewCopy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCopy_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(6, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 375);
            this.panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtExcludeParamsCopy);
            this.groupBox3.Controls.Add(this.chkExcludeCopy);
            this.groupBox3.Controls.Add(this.btnScanCopy);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 369);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "(folder project)";
            // 
            // txtExcludeParamsCopy
            // 
            this.txtExcludeParamsCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeParamsCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcludeParamsCopy.Location = new System.Drawing.Point(6, 55);
            this.txtExcludeParamsCopy.Multiline = true;
            this.txtExcludeParamsCopy.Name = "txtExcludeParamsCopy";
            this.txtExcludeParamsCopy.Size = new System.Drawing.Size(225, 249);
            this.txtExcludeParamsCopy.TabIndex = 6;
            this.txtExcludeParamsCopy.Text = " ";
            // 
            // chkExcludeCopy
            // 
            this.chkExcludeCopy.AutoSize = true;
            this.chkExcludeCopy.Checked = true;
            this.chkExcludeCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeCopy.Location = new System.Drawing.Point(6, 19);
            this.chkExcludeCopy.Name = "chkExcludeCopy";
            this.chkExcludeCopy.Size = new System.Drawing.Size(216, 20);
            this.chkExcludeCopy.TabIndex = 5;
            this.chkExcludeCopy.Text = "Lewati pengecekan folder berisi";
            this.chkExcludeCopy.UseVisualStyleBackColor = false;
            // 
            // btnScanCopy
            // 
            this.btnScanCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanCopy.BackColor = System.Drawing.Color.GreenYellow;
            this.btnScanCopy.Location = new System.Drawing.Point(6, 310);
            this.btnScanCopy.Name = "btnScanCopy";
            this.btnScanCopy.Size = new System.Drawing.Size(225, 53);
            this.btnScanCopy.TabIndex = 0;
            this.btnScanCopy.Text = "Scan";
            this.btnScanCopy.UseVisualStyleBackColor = false;
            this.btnScanCopy.Click += new System.EventHandler(this.btnScanCopy_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblProgressDelete);
            this.tabPage2.Controls.Add(this.pgBarDelete);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DELETE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblProgressDelete
            // 
            this.lblProgressDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressDelete.AutoSize = true;
            this.lblProgressDelete.Location = new System.Drawing.Point(655, 442);
            this.lblProgressDelete.Name = "lblProgressDelete";
            this.lblProgressDelete.Size = new System.Drawing.Size(104, 16);
            this.lblProgressDelete.TabIndex = 12;
            this.lblProgressDelete.Text = "Proses: 0/0 (0%)";
            // 
            // pgBarDelete
            // 
            this.pgBarDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgBarDelete.Location = new System.Drawing.Point(9, 438);
            this.pgBarDelete.Name = "pgBarDelete";
            this.pgBarDelete.Size = new System.Drawing.Size(640, 23);
            this.pgBarDelete.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtRootPathDelete);
            this.panel4.Controls.Add(this.btnBrowseDelete);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 45);
            this.panel4.TabIndex = 10;
            // 
            // txtRootPathDelete
            // 
            this.txtRootPathDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootPathDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRootPathDelete.Location = new System.Drawing.Point(90, 9);
            this.txtRootPathDelete.Name = "txtRootPathDelete";
            this.txtRootPathDelete.Size = new System.Drawing.Size(721, 26);
            this.txtRootPathDelete.TabIndex = 4;
            // 
            // btnBrowseDelete
            // 
            this.btnBrowseDelete.Location = new System.Drawing.Point(3, 7);
            this.btnBrowseDelete.Name = "btnBrowseDelete";
            this.btnBrowseDelete.Size = new System.Drawing.Size(81, 32);
            this.btnBrowseDelete.TabIndex = 3;
            this.btnBrowseDelete.Text = "Browse";
            this.btnBrowseDelete.UseVisualStyleBackColor = true;
            this.btnBrowseDelete.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.groupBox5);
            this.panel5.Location = new System.Drawing.Point(252, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(568, 375);
            this.panel5.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dataGridViewDelete);
            this.groupBox5.Controls.Add(this.btnDeleteAll);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 369);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hasil";
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AllowUserToAddRows = false;
            this.dataGridViewDelete.AllowUserToDeleteRows = false;
            this.dataGridViewDelete.AllowUserToOrderColumns = true;
            this.dataGridViewDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.statusDelete,
            this.dataGridViewButtonColumn1});
            this.dataGridViewDelete.Location = new System.Drawing.Point(6, 70);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.ReadOnly = true;
            this.dataGridViewDelete.Size = new System.Drawing.Size(550, 293);
            this.dataGridViewDelete.TabIndex = 2;
            this.dataGridViewDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDelete_CellContentClick);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteAll.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(134, 45);
            this.btnDeleteAll.TabIndex = 1;
            this.btnDeleteAll.Text = "Hapus Semua";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.groupBox6);
            this.panel6.Location = new System.Drawing.Point(6, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 375);
            this.panel6.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.chkExcludeDelete);
            this.groupBox6.Controls.Add(this.txtExcludeParamsDelete);
            this.groupBox6.Controls.Add(this.btnScanDelete);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 369);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter";
            // 
            // chkExcludeDelete
            // 
            this.chkExcludeDelete.AutoSize = true;
            this.chkExcludeDelete.Checked = true;
            this.chkExcludeDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeDelete.Location = new System.Drawing.Point(6, 19);
            this.chkExcludeDelete.Name = "chkExcludeDelete";
            this.chkExcludeDelete.Size = new System.Drawing.Size(216, 20);
            this.chkExcludeDelete.TabIndex = 5;
            this.chkExcludeDelete.Text = "Lewati pengecekan folder berisi";
            this.chkExcludeDelete.UseVisualStyleBackColor = false;
            // 
            // txtExcludeParamsDelete
            // 
            this.txtExcludeParamsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeParamsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcludeParamsDelete.Location = new System.Drawing.Point(6, 55);
            this.txtExcludeParamsDelete.Multiline = true;
            this.txtExcludeParamsDelete.Name = "txtExcludeParamsDelete";
            this.txtExcludeParamsDelete.Size = new System.Drawing.Size(225, 249);
            this.txtExcludeParamsDelete.TabIndex = 6;
            this.txtExcludeParamsDelete.Text = " ";
            // 
            // btnScanDelete
            // 
            this.btnScanDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanDelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btnScanDelete.Location = new System.Drawing.Point(6, 310);
            this.btnScanDelete.Name = "btnScanDelete";
            this.btnScanDelete.Size = new System.Drawing.Size(225, 53);
            this.btnScanDelete.TabIndex = 0;
            this.btnScanDelete.Text = " Scan";
            this.btnScanDelete.UseVisualStyleBackColor = false;
            this.btnScanDelete.Click += new System.EventHandler(this.btnScanDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(folder project)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClearLog);
            this.tabPage3.Controls.Add(this.dgvLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1047, 448);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(966, 397);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 45);
            this.btnClearLog.TabIndex = 6;
            this.btnClearLog.Text = "Reset";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToOrderColumns = true;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.path,
            this.action,
            this.status});
            this.dgvLog.Location = new System.Drawing.Point(6, 6);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.Size = new System.Drawing.Size(1035, 385);
            this.dgvLog.TabIndex = 0;
            // 
            // time
            // 
            this.time.FillWeight = 150F;
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 150;
            // 
            // path
            // 
            this.path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.path.HeaderText = "Path";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // bgWorkerCopy
            // 
            this.bgWorkerCopy.WorkerReportsProgress = true;
            this.bgWorkerCopy.WorkerSupportsCancellation = true;
            this.bgWorkerCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerCopy_DoWork);
            this.bgWorkerCopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerCopy_ProgressChanged);
            this.bgWorkerCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerCopy_RunWorkerCompleted);
            // 
            // bgWorkerDelete
            // 
            this.bgWorkerDelete.WorkerReportsProgress = true;
            this.bgWorkerDelete.WorkerSupportsCancellation = true;
            this.bgWorkerDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerDelete_DoWork);
            this.bgWorkerDelete.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerDelete_ProgressChanged);
            this.bgWorkerDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerDelete_RunWorkerCompleted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Index Path";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDelete
            // 
            this.statusDelete.HeaderText = "Status Delete";
            this.statusDelete.Name = "statusDelete";
            this.statusDelete.ReadOnly = true;
            this.statusDelete.Width = 120;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FillWeight = 150F;
            this.dataGridViewButtonColumn1.HeaderText = "Action";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valid Location";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // statusCopy
            // 
            this.statusCopy.HeaderText = "Status Copy";
            this.statusCopy.Name = "statusCopy";
            this.statusCopy.ReadOnly = true;
            this.statusCopy.Width = 120;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Action";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Width = 150;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(858, 520);
            this.Controls.Add(this.TabBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TabBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCopy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }
    

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private TabControl TabBox;
        private TabPage tabPage2;
        private Button btnDeleteAll;
        private DataGridView dataGridViewDelete;
        private Button btnScanDelete;
        private TextBox txtRootPathDelete;
        private TabPage tabPage1;
        private GroupBox groupBox4;
        private Button btnCopyAll;
        private DataGridView dataGridViewCopy;
        private GroupBox groupBox3;
        private Button btnScanCopy;
        private TextBox txtRootPathCopy;
        private Button btnBrowseCopy;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button btnBrowseDelete;
        private Panel panel5;
        private GroupBox groupBox5;
        private Panel panel6;
        private GroupBox groupBox6;
        private Label label2;
        public CheckBox chkExcludeDelete;
        public CheckBox chkExcludeCopy;
        public TextBox txtExcludeParamsCopy;
        public TextBox txtExcludeParamsDelete;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn path;
        private DataGridViewTextBoxColumn action;
        private DataGridViewTextBoxColumn status;
        public DataGridView dgvLog;
        private Button btnClearLog;
        private System.ComponentModel.BackgroundWorker bgWorkerCopy;
        private System.ComponentModel.BackgroundWorker bgWorkerDelete;
        private ProgressBar pgBarCopy;
        private ProgressBar pgBarDelete;
        private Label lblProgressDelete;
        private Label lblProgressCopy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDelete;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn statusCopy;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}

