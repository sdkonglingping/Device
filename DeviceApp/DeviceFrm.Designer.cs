
namespace DeviceApp
{
    partial class DeviceFrm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            this.DId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNameEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNameCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DKKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDevicePage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNums = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDeviceList = new System.Windows.Forms.Panel();
            this.btnDeviceDel = new System.Windows.Forms.Button();
            this.btnDeviceImport = new System.Windows.Forms.Button();
            this.btnDeviceEXport = new System.Windows.Forms.Button();
            this.btnDeviceEdit = new System.Windows.Forms.Button();
            this.btnDeviceAdd = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblKKS = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKKS = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDefect = new System.Windows.Forms.TabPage();
            this.pnlAuxPage = new System.Windows.Forms.Panel();
            this.pnlAuxMenu = new System.Windows.Forms.Panel();
            this.btnDefectDel = new System.Windows.Forms.Button();
            this.btnDefectExport = new System.Windows.Forms.Button();
            this.btnDefectAdd = new System.Windows.Forms.Button();
            this.dgvDeviceDetail = new System.Windows.Forms.DataGridView();
            this.tpRepairPlan = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRepairPlanDel = new System.Windows.Forms.Button();
            this.btnRepairPlanExport = new System.Windows.Forms.Button();
            this.btnRepairPlanAdd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tpMaitPlan = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnMaintPlanDel = new System.Windows.Forms.Button();
            this.btnMaitePlanExport = new System.Windows.Forms.Button();
            this.btnMaitePlanAdd = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tpMaintOrder = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnMaintOrderDel = new System.Windows.Forms.Button();
            this.btnMaintOrderExport = new System.Windows.Forms.Button();
            this.btnMaintOrderAdd = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tpPlanOrder = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnPlanOrderDelete = new System.Windows.Forms.Button();
            this.btnPlanOrderExport = new System.Windows.Forms.Button();
            this.btnPlanOrderAdd = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tpPartChangeList = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tpPartsRelative = new System.Windows.Forms.TabPage();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button31 = new System.Windows.Forms.Button();
            this.btnPartsRelativeDelete = new System.Windows.Forms.Button();
            this.btnPartsRelativeExport = new System.Windows.Forms.Button();
            this.btnPartsRelativeSelect = new System.Windows.Forms.Button();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.tpDocRelative = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnDocDel = new System.Windows.Forms.Button();
            this.btnDocExport = new System.Windows.Forms.Button();
            this.btnDocAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.tpPicRelative = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnPicDel = new System.Windows.Forms.Button();
            this.btnPicSet = new System.Windows.Forms.Button();
            this.btnPicAdd = new System.Windows.Forms.Button();
            this.tpMaiteList = new System.Windows.Forms.TabPage();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnMaiteListDel = new System.Windows.Forms.Button();
            this.btnMaiteListExport = new System.Windows.Forms.Button();
            this.btnMaiteListAdd = new System.Windows.Forms.Button();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.pnlDevicePage.SuspendLayout();
            this.pnlDeviceList.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDefect.SuspendLayout();
            this.pnlAuxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceDetail)).BeginInit();
            this.tpRepairPlan.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpMaitPlan.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tpMaintOrder.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tpPlanOrder.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tpPartChangeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tpPartsRelative.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.tpDocRelative.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            this.tpPicRelative.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tpMaiteList.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDeviceList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlDevicePage);
            this.splitContainer1.Panel1.Controls.Add(this.pnlDeviceList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1413, 752);
            this.splitContainer1.SplitterDistance = 471;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.AllowUserToAddRows = false;
            this.dgvDeviceList.AutoGenerateColumns = false;
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DId,
            this.DNameEN,
            this.DNameCN,
            this.dTypeDataGridViewTextBoxColumn,
            this.dAreaDataGridViewTextBoxColumn,
            this.dModelDataGridViewTextBoxColumn,
            this.DKKS,
            this.DStatus,
            this.StartDate,
            this.manufacturerDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.DRemark});
            this.dgvDeviceList.DataSource = this.deviceBindingSource;
            this.dgvDeviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceList.Location = new System.Drawing.Point(0, 76);
            this.dgvDeviceList.MultiSelect = false;
            this.dgvDeviceList.Name = "dgvDeviceList";
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.RowHeadersWidth = 51;
            this.dgvDeviceList.RowTemplate.Height = 24;
            this.dgvDeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceList.Size = new System.Drawing.Size(1413, 360);
            this.dgvDeviceList.TabIndex = 3;
            // 
            // DId
            // 
            this.DId.DataPropertyName = "DId";
            this.DId.HeaderText = "DId";
            this.DId.MinimumWidth = 6;
            this.DId.Name = "DId";
            this.DId.Width = 60;
            // 
            // DNameEN
            // 
            this.DNameEN.DataPropertyName = "DNameEN";
            this.DNameEN.HeaderText = "DNameEN";
            this.DNameEN.MinimumWidth = 6;
            this.DNameEN.Name = "DNameEN";
            this.DNameEN.Width = 125;
            // 
            // DNameCN
            // 
            this.DNameCN.DataPropertyName = "DNameCN";
            this.DNameCN.HeaderText = "DNameCN";
            this.DNameCN.MinimumWidth = 6;
            this.DNameCN.Name = "DNameCN";
            this.DNameCN.Width = 125;
            // 
            // dTypeDataGridViewTextBoxColumn
            // 
            this.dTypeDataGridViewTextBoxColumn.DataPropertyName = "DType";
            this.dTypeDataGridViewTextBoxColumn.HeaderText = "DType";
            this.dTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dTypeDataGridViewTextBoxColumn.Name = "dTypeDataGridViewTextBoxColumn";
            this.dTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dAreaDataGridViewTextBoxColumn
            // 
            this.dAreaDataGridViewTextBoxColumn.DataPropertyName = "DArea";
            this.dAreaDataGridViewTextBoxColumn.HeaderText = "DArea";
            this.dAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAreaDataGridViewTextBoxColumn.Name = "dAreaDataGridViewTextBoxColumn";
            this.dAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dModelDataGridViewTextBoxColumn
            // 
            this.dModelDataGridViewTextBoxColumn.DataPropertyName = "DModel";
            this.dModelDataGridViewTextBoxColumn.HeaderText = "DModel";
            this.dModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dModelDataGridViewTextBoxColumn.Name = "dModelDataGridViewTextBoxColumn";
            this.dModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // DKKS
            // 
            this.DKKS.DataPropertyName = "DKKS";
            this.DKKS.HeaderText = "DKKS";
            this.DKKS.MinimumWidth = 6;
            this.DKKS.Name = "DKKS";
            this.DKKS.Width = 125;
            // 
            // DStatus
            // 
            this.DStatus.DataPropertyName = "DStatus";
            this.DStatus.HeaderText = "DStatus";
            this.DStatus.MinimumWidth = 6;
            this.DStatus.Name = "DStatus";
            this.DStatus.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.Width = 125;
            // 
            // DRemark
            // 
            this.DRemark.DataPropertyName = "DRemark";
            this.DRemark.HeaderText = "DRemark";
            this.DRemark.MinimumWidth = 6;
            this.DRemark.Name = "DRemark";
            this.DRemark.Width = 125;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(Model.Device);
            // 
            // pnlDevicePage
            // 
            this.pnlDevicePage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDevicePage.Controls.Add(this.label1);
            this.pnlDevicePage.Controls.Add(this.cmbNums);
            this.pnlDevicePage.Controls.Add(this.btnLast);
            this.pnlDevicePage.Controls.Add(this.btnNext);
            this.pnlDevicePage.Controls.Add(this.btnGo);
            this.pnlDevicePage.Controls.Add(this.btnPre);
            this.pnlDevicePage.Controls.Add(this.btnFirst);
            this.pnlDevicePage.Controls.Add(this.txtPage);
            this.pnlDevicePage.Controls.Add(this.lblPages);
            this.pnlDevicePage.Controls.Add(this.label3);
            this.pnlDevicePage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDevicePage.Location = new System.Drawing.Point(0, 436);
            this.pnlDevicePage.Name = "pnlDevicePage";
            this.pnlDevicePage.Size = new System.Drawing.Size(1413, 35);
            this.pnlDevicePage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Per page";
            // 
            // cmbNums
            // 
            this.cmbNums.FormattingEnabled = true;
            this.cmbNums.Location = new System.Drawing.Point(3, 5);
            this.cmbNums.Name = "cmbNums";
            this.cmbNums.Size = new System.Drawing.Size(67, 24);
            this.cmbNums.TabIndex = 3;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(537, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(47, 23);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(482, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(427, 6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(47, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(263, 6);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(47, 23);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(208, 6);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(47, 23);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(318, 6);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(57, 22);
            this.txtPage.TabIndex = 1;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(403, 9);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(16, 17);
            this.lblPages.TabIndex = 0;
            this.lblPages.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "/";
            // 
            // pnlDeviceList
            // 
            this.pnlDeviceList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlDeviceList.Controls.Add(this.btnDeviceDel);
            this.pnlDeviceList.Controls.Add(this.btnDeviceImport);
            this.pnlDeviceList.Controls.Add(this.btnDeviceEXport);
            this.pnlDeviceList.Controls.Add(this.btnDeviceEdit);
            this.pnlDeviceList.Controls.Add(this.btnDeviceAdd);
            this.pnlDeviceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceList.Location = new System.Drawing.Point(0, 42);
            this.pnlDeviceList.Name = "pnlDeviceList";
            this.pnlDeviceList.Size = new System.Drawing.Size(1413, 34);
            this.pnlDeviceList.TabIndex = 1;
            // 
            // btnDeviceDel
            // 
            this.btnDeviceDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeviceDel.Location = new System.Drawing.Point(244, 0);
            this.btnDeviceDel.Name = "btnDeviceDel";
            this.btnDeviceDel.Size = new System.Drawing.Size(122, 34);
            this.btnDeviceDel.TabIndex = 0;
            this.btnDeviceDel.Text = "Delete";
            this.btnDeviceDel.UseVisualStyleBackColor = true;
            this.btnDeviceDel.Click += new System.EventHandler(this.btnDeviceDel_Click);
            // 
            // btnDeviceImport
            // 
            this.btnDeviceImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeviceImport.Location = new System.Drawing.Point(1161, 0);
            this.btnDeviceImport.Name = "btnDeviceImport";
            this.btnDeviceImport.Size = new System.Drawing.Size(126, 34);
            this.btnDeviceImport.TabIndex = 0;
            this.btnDeviceImport.Text = "Import";
            this.btnDeviceImport.UseVisualStyleBackColor = true;
            this.btnDeviceImport.Click += new System.EventHandler(this.btnDeviceImport_Click);
            // 
            // btnDeviceEXport
            // 
            this.btnDeviceEXport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeviceEXport.Location = new System.Drawing.Point(1287, 0);
            this.btnDeviceEXport.Name = "btnDeviceEXport";
            this.btnDeviceEXport.Size = new System.Drawing.Size(126, 34);
            this.btnDeviceEXport.TabIndex = 0;
            this.btnDeviceEXport.Text = "Export";
            this.btnDeviceEXport.UseVisualStyleBackColor = true;
            // 
            // btnDeviceEdit
            // 
            this.btnDeviceEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeviceEdit.Location = new System.Drawing.Point(122, 0);
            this.btnDeviceEdit.Name = "btnDeviceEdit";
            this.btnDeviceEdit.Size = new System.Drawing.Size(122, 34);
            this.btnDeviceEdit.TabIndex = 0;
            this.btnDeviceEdit.Text = "Edit";
            this.btnDeviceEdit.UseVisualStyleBackColor = true;
            this.btnDeviceEdit.Click += new System.EventHandler(this.btnDeviceEdit_Click);
            // 
            // btnDeviceAdd
            // 
            this.btnDeviceAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeviceAdd.Location = new System.Drawing.Point(0, 0);
            this.btnDeviceAdd.Name = "btnDeviceAdd";
            this.btnDeviceAdd.Size = new System.Drawing.Size(122, 34);
            this.btnDeviceAdd.TabIndex = 0;
            this.btnDeviceAdd.Text = "Add";
            this.btnDeviceAdd.UseVisualStyleBackColor = true;
            this.btnDeviceAdd.Click += new System.EventHandler(this.btnDeviceAdd_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.comboBox1);
            this.pnlSearch.Controls.Add(this.cmbStatus);
            this.pnlSearch.Controls.Add(this.lblModel);
            this.pnlSearch.Controls.Add(this.lblArea);
            this.pnlSearch.Controls.Add(this.cmbArea);
            this.pnlSearch.Controls.Add(this.txtModel);
            this.pnlSearch.Controls.Add(this.lblStatus);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblKKS);
            this.pnlSearch.Controls.Add(this.lblName);
            this.pnlSearch.Controls.Add(this.txtName);
            this.pnlSearch.Controls.Add(this.txtKKS);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1413, 42);
            this.pnlSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dept.";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(1161, 9);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(163, 24);
            this.cmbStatus.TabIndex = 13;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(672, 13);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(217, 13);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(263, 9);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(152, 24);
            this.cmbArea.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModel.Location = new System.Drawing.Point(724, 10);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(170, 22);
            this.txtModel.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1107, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(1330, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblKKS
            // 
            this.lblKKS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKKS.AutoSize = true;
            this.lblKKS.Location = new System.Drawing.Point(911, 13);
            this.lblKKS.Name = "lblKKS";
            this.lblKKS.Size = new System.Drawing.Size(35, 17);
            this.lblKKS.TabIndex = 7;
            this.lblKKS.Text = "KKS";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(424, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.Location = new System.Drawing.Point(475, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 22);
            this.txtName.TabIndex = 18;
            // 
            // txtKKS
            // 
            this.txtKKS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKKS.Location = new System.Drawing.Point(952, 10);
            this.txtKKS.Name = "txtKKS";
            this.txtKKS.Size = new System.Drawing.Size(149, 22);
            this.txtKKS.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDefect);
            this.tabControl1.Controls.Add(this.tpRepairPlan);
            this.tabControl1.Controls.Add(this.tpMaitPlan);
            this.tabControl1.Controls.Add(this.tpMaintOrder);
            this.tabControl1.Controls.Add(this.tpPlanOrder);
            this.tabControl1.Controls.Add(this.tpPartChangeList);
            this.tabControl1.Controls.Add(this.tpPartsRelative);
            this.tabControl1.Controls.Add(this.tpDocRelative);
            this.tabControl1.Controls.Add(this.tpPicRelative);
            this.tabControl1.Controls.Add(this.tpMaiteList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 277);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDefect
            // 
            this.tpDefect.AutoScroll = true;
            this.tpDefect.Controls.Add(this.pnlAuxPage);
            this.tpDefect.Controls.Add(this.pnlAuxMenu);
            this.tpDefect.Controls.Add(this.dgvDeviceDetail);
            this.tpDefect.Location = new System.Drawing.Point(4, 25);
            this.tpDefect.Name = "tpDefect";
            this.tpDefect.Size = new System.Drawing.Size(1405, 248);
            this.tpDefect.TabIndex = 0;
            this.tpDefect.Text = "Defect";
            this.tpDefect.UseVisualStyleBackColor = true;
            // 
            // pnlAuxPage
            // 
            this.pnlAuxPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAuxPage.Location = new System.Drawing.Point(0, 218);
            this.pnlAuxPage.Name = "pnlAuxPage";
            this.pnlAuxPage.Size = new System.Drawing.Size(1405, 30);
            this.pnlAuxPage.TabIndex = 1;
            // 
            // pnlAuxMenu
            // 
            this.pnlAuxMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlAuxMenu.Controls.Add(this.btnDefectDel);
            this.pnlAuxMenu.Controls.Add(this.btnDefectExport);
            this.pnlAuxMenu.Controls.Add(this.btnDefectAdd);
            this.pnlAuxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuxMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlAuxMenu.Name = "pnlAuxMenu";
            this.pnlAuxMenu.Size = new System.Drawing.Size(1405, 30);
            this.pnlAuxMenu.TabIndex = 0;
            // 
            // btnDefectDel
            // 
            this.btnDefectDel.AutoSize = true;
            this.btnDefectDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDefectDel.Location = new System.Drawing.Point(150, 0);
            this.btnDefectDel.Name = "btnDefectDel";
            this.btnDefectDel.Size = new System.Drawing.Size(75, 30);
            this.btnDefectDel.TabIndex = 0;
            this.btnDefectDel.Text = "Delete";
            this.btnDefectDel.UseVisualStyleBackColor = true;
            // 
            // btnDefectExport
            // 
            this.btnDefectExport.AutoSize = true;
            this.btnDefectExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDefectExport.Location = new System.Drawing.Point(75, 0);
            this.btnDefectExport.Name = "btnDefectExport";
            this.btnDefectExport.Size = new System.Drawing.Size(75, 30);
            this.btnDefectExport.TabIndex = 0;
            this.btnDefectExport.Text = "Export";
            this.btnDefectExport.UseVisualStyleBackColor = true;
            // 
            // btnDefectAdd
            // 
            this.btnDefectAdd.AutoSize = true;
            this.btnDefectAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDefectAdd.Location = new System.Drawing.Point(0, 0);
            this.btnDefectAdd.Name = "btnDefectAdd";
            this.btnDefectAdd.Size = new System.Drawing.Size(75, 30);
            this.btnDefectAdd.TabIndex = 0;
            this.btnDefectAdd.Text = "Add";
            this.btnDefectAdd.UseVisualStyleBackColor = true;
            // 
            // dgvDeviceDetail
            // 
            this.dgvDeviceDetail.AllowUserToAddRows = false;
            this.dgvDeviceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDeviceDetail.Name = "dgvDeviceDetail";
            this.dgvDeviceDetail.RowHeadersWidth = 51;
            this.dgvDeviceDetail.RowTemplate.Height = 24;
            this.dgvDeviceDetail.Size = new System.Drawing.Size(1405, 248);
            this.dgvDeviceDetail.TabIndex = 2;
            // 
            // tpRepairPlan
            // 
            this.tpRepairPlan.AutoScroll = true;
            this.tpRepairPlan.Controls.Add(this.panel8);
            this.tpRepairPlan.Controls.Add(this.panel9);
            this.tpRepairPlan.Controls.Add(this.dataGridView3);
            this.tpRepairPlan.Location = new System.Drawing.Point(4, 25);
            this.tpRepairPlan.Name = "tpRepairPlan";
            this.tpRepairPlan.Size = new System.Drawing.Size(1405, 248);
            this.tpRepairPlan.TabIndex = 1;
            this.tpRepairPlan.Text = "Repair Plan";
            this.tpRepairPlan.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 218);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1405, 30);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel9.Controls.Add(this.btnRepairPlanDel);
            this.panel9.Controls.Add(this.btnRepairPlanExport);
            this.panel9.Controls.Add(this.btnRepairPlanAdd);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1405, 30);
            this.panel9.TabIndex = 3;
            // 
            // btnRepairPlanDel
            // 
            this.btnRepairPlanDel.AutoSize = true;
            this.btnRepairPlanDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRepairPlanDel.Location = new System.Drawing.Point(150, 0);
            this.btnRepairPlanDel.Name = "btnRepairPlanDel";
            this.btnRepairPlanDel.Size = new System.Drawing.Size(75, 30);
            this.btnRepairPlanDel.TabIndex = 0;
            this.btnRepairPlanDel.Text = "Delete";
            this.btnRepairPlanDel.UseVisualStyleBackColor = true;
            // 
            // btnRepairPlanExport
            // 
            this.btnRepairPlanExport.AutoSize = true;
            this.btnRepairPlanExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRepairPlanExport.Location = new System.Drawing.Point(75, 0);
            this.btnRepairPlanExport.Name = "btnRepairPlanExport";
            this.btnRepairPlanExport.Size = new System.Drawing.Size(75, 30);
            this.btnRepairPlanExport.TabIndex = 0;
            this.btnRepairPlanExport.Text = "Export";
            this.btnRepairPlanExport.UseVisualStyleBackColor = true;
            // 
            // btnRepairPlanAdd
            // 
            this.btnRepairPlanAdd.AutoSize = true;
            this.btnRepairPlanAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRepairPlanAdd.Location = new System.Drawing.Point(0, 0);
            this.btnRepairPlanAdd.Name = "btnRepairPlanAdd";
            this.btnRepairPlanAdd.Size = new System.Drawing.Size(75, 30);
            this.btnRepairPlanAdd.TabIndex = 0;
            this.btnRepairPlanAdd.Text = "Add";
            this.btnRepairPlanAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView3.TabIndex = 5;
            // 
            // tpMaitPlan
            // 
            this.tpMaitPlan.AutoScroll = true;
            this.tpMaitPlan.Controls.Add(this.panel10);
            this.tpMaitPlan.Controls.Add(this.panel11);
            this.tpMaitPlan.Controls.Add(this.dataGridView4);
            this.tpMaitPlan.Location = new System.Drawing.Point(4, 25);
            this.tpMaitPlan.Name = "tpMaitPlan";
            this.tpMaitPlan.Size = new System.Drawing.Size(1405, 248);
            this.tpMaitPlan.TabIndex = 2;
            this.tpMaitPlan.Text = "Mait Plan";
            this.tpMaitPlan.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 218);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1405, 30);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel11.Controls.Add(this.btnMaintPlanDel);
            this.panel11.Controls.Add(this.btnMaitePlanExport);
            this.panel11.Controls.Add(this.btnMaitePlanAdd);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1405, 30);
            this.panel11.TabIndex = 6;
            // 
            // btnMaintPlanDel
            // 
            this.btnMaintPlanDel.AutoSize = true;
            this.btnMaintPlanDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaintPlanDel.Location = new System.Drawing.Point(150, 0);
            this.btnMaintPlanDel.Name = "btnMaintPlanDel";
            this.btnMaintPlanDel.Size = new System.Drawing.Size(75, 30);
            this.btnMaintPlanDel.TabIndex = 0;
            this.btnMaintPlanDel.Text = "Delete";
            this.btnMaintPlanDel.UseVisualStyleBackColor = true;
            // 
            // btnMaitePlanExport
            // 
            this.btnMaitePlanExport.AutoSize = true;
            this.btnMaitePlanExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaitePlanExport.Location = new System.Drawing.Point(75, 0);
            this.btnMaitePlanExport.Name = "btnMaitePlanExport";
            this.btnMaitePlanExport.Size = new System.Drawing.Size(75, 30);
            this.btnMaitePlanExport.TabIndex = 0;
            this.btnMaitePlanExport.Text = "Export";
            this.btnMaitePlanExport.UseVisualStyleBackColor = true;
            // 
            // btnMaitePlanAdd
            // 
            this.btnMaitePlanAdd.AutoSize = true;
            this.btnMaitePlanAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaitePlanAdd.Location = new System.Drawing.Point(0, 0);
            this.btnMaitePlanAdd.Name = "btnMaitePlanAdd";
            this.btnMaitePlanAdd.Size = new System.Drawing.Size(75, 30);
            this.btnMaitePlanAdd.TabIndex = 0;
            this.btnMaitePlanAdd.Text = "Add";
            this.btnMaitePlanAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView4.TabIndex = 8;
            // 
            // tpMaintOrder
            // 
            this.tpMaintOrder.AutoScroll = true;
            this.tpMaintOrder.Controls.Add(this.panel12);
            this.tpMaintOrder.Controls.Add(this.panel13);
            this.tpMaintOrder.Controls.Add(this.dataGridView5);
            this.tpMaintOrder.Location = new System.Drawing.Point(4, 25);
            this.tpMaintOrder.Name = "tpMaintOrder";
            this.tpMaintOrder.Size = new System.Drawing.Size(1405, 248);
            this.tpMaintOrder.TabIndex = 3;
            this.tpMaintOrder.Text = "Maint Order";
            this.tpMaintOrder.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 218);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1405, 30);
            this.panel12.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel13.Controls.Add(this.btnMaintOrderDel);
            this.panel13.Controls.Add(this.btnMaintOrderExport);
            this.panel13.Controls.Add(this.btnMaintOrderAdd);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1405, 30);
            this.panel13.TabIndex = 6;
            // 
            // btnMaintOrderDel
            // 
            this.btnMaintOrderDel.AutoSize = true;
            this.btnMaintOrderDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaintOrderDel.Location = new System.Drawing.Point(150, 0);
            this.btnMaintOrderDel.Name = "btnMaintOrderDel";
            this.btnMaintOrderDel.Size = new System.Drawing.Size(75, 30);
            this.btnMaintOrderDel.TabIndex = 0;
            this.btnMaintOrderDel.Text = "Delete";
            this.btnMaintOrderDel.UseVisualStyleBackColor = true;
            // 
            // btnMaintOrderExport
            // 
            this.btnMaintOrderExport.AutoSize = true;
            this.btnMaintOrderExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaintOrderExport.Location = new System.Drawing.Point(75, 0);
            this.btnMaintOrderExport.Name = "btnMaintOrderExport";
            this.btnMaintOrderExport.Size = new System.Drawing.Size(75, 30);
            this.btnMaintOrderExport.TabIndex = 0;
            this.btnMaintOrderExport.Text = "Export";
            this.btnMaintOrderExport.UseVisualStyleBackColor = true;
            // 
            // btnMaintOrderAdd
            // 
            this.btnMaintOrderAdd.AutoSize = true;
            this.btnMaintOrderAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaintOrderAdd.Location = new System.Drawing.Point(0, 0);
            this.btnMaintOrderAdd.Name = "btnMaintOrderAdd";
            this.btnMaintOrderAdd.Size = new System.Drawing.Size(75, 30);
            this.btnMaintOrderAdd.TabIndex = 0;
            this.btnMaintOrderAdd.Text = "Add";
            this.btnMaintOrderAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView5.TabIndex = 8;
            // 
            // tpPlanOrder
            // 
            this.tpPlanOrder.AutoScroll = true;
            this.tpPlanOrder.Controls.Add(this.panel14);
            this.tpPlanOrder.Controls.Add(this.panel15);
            this.tpPlanOrder.Controls.Add(this.dataGridView6);
            this.tpPlanOrder.Location = new System.Drawing.Point(4, 25);
            this.tpPlanOrder.Name = "tpPlanOrder";
            this.tpPlanOrder.Size = new System.Drawing.Size(1405, 248);
            this.tpPlanOrder.TabIndex = 4;
            this.tpPlanOrder.Text = "Plan Order";
            this.tpPlanOrder.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 218);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1405, 30);
            this.panel14.TabIndex = 10;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel15.Controls.Add(this.btnPlanOrderDelete);
            this.panel15.Controls.Add(this.btnPlanOrderExport);
            this.panel15.Controls.Add(this.btnPlanOrderAdd);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1405, 30);
            this.panel15.TabIndex = 9;
            // 
            // btnPlanOrderDelete
            // 
            this.btnPlanOrderDelete.AutoSize = true;
            this.btnPlanOrderDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlanOrderDelete.Location = new System.Drawing.Point(150, 0);
            this.btnPlanOrderDelete.Name = "btnPlanOrderDelete";
            this.btnPlanOrderDelete.Size = new System.Drawing.Size(75, 30);
            this.btnPlanOrderDelete.TabIndex = 0;
            this.btnPlanOrderDelete.Text = "Delete";
            this.btnPlanOrderDelete.UseVisualStyleBackColor = true;
            // 
            // btnPlanOrderExport
            // 
            this.btnPlanOrderExport.AutoSize = true;
            this.btnPlanOrderExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlanOrderExport.Location = new System.Drawing.Point(75, 0);
            this.btnPlanOrderExport.Name = "btnPlanOrderExport";
            this.btnPlanOrderExport.Size = new System.Drawing.Size(75, 30);
            this.btnPlanOrderExport.TabIndex = 0;
            this.btnPlanOrderExport.Text = "Export";
            this.btnPlanOrderExport.UseVisualStyleBackColor = true;
            // 
            // btnPlanOrderAdd
            // 
            this.btnPlanOrderAdd.AutoSize = true;
            this.btnPlanOrderAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlanOrderAdd.Location = new System.Drawing.Point(0, 0);
            this.btnPlanOrderAdd.Name = "btnPlanOrderAdd";
            this.btnPlanOrderAdd.Size = new System.Drawing.Size(75, 30);
            this.btnPlanOrderAdd.TabIndex = 0;
            this.btnPlanOrderAdd.Text = "Add";
            this.btnPlanOrderAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView6.TabIndex = 11;
            // 
            // tpPartChangeList
            // 
            this.tpPartChangeList.AutoScroll = true;
            this.tpPartChangeList.Controls.Add(this.panel16);
            this.tpPartChangeList.Controls.Add(this.dataGridView7);
            this.tpPartChangeList.Location = new System.Drawing.Point(4, 25);
            this.tpPartChangeList.Name = "tpPartChangeList";
            this.tpPartChangeList.Size = new System.Drawing.Size(1405, 248);
            this.tpPartChangeList.TabIndex = 5;
            this.tpPartChangeList.Text = "Parts change List";
            this.tpPartChangeList.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 218);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1405, 30);
            this.panel16.TabIndex = 10;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(0, 0);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView7.TabIndex = 11;
            // 
            // tpPartsRelative
            // 
            this.tpPartsRelative.AutoScroll = true;
            this.tpPartsRelative.Controls.Add(this.panel17);
            this.tpPartsRelative.Controls.Add(this.panel18);
            this.tpPartsRelative.Controls.Add(this.dataGridView8);
            this.tpPartsRelative.Location = new System.Drawing.Point(4, 25);
            this.tpPartsRelative.Name = "tpPartsRelative";
            this.tpPartsRelative.Size = new System.Drawing.Size(1405, 248);
            this.tpPartsRelative.TabIndex = 6;
            this.tpPartsRelative.Text = "Parts relative";
            this.tpPartsRelative.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 218);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1405, 30);
            this.panel17.TabIndex = 10;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel18.Controls.Add(this.textBox6);
            this.panel18.Controls.Add(this.button31);
            this.panel18.Controls.Add(this.btnPartsRelativeDelete);
            this.panel18.Controls.Add(this.btnPartsRelativeExport);
            this.panel18.Controls.Add(this.btnPartsRelativeSelect);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1405, 30);
            this.panel18.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox6.Location = new System.Drawing.Point(1063, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(267, 22);
            this.textBox6.TabIndex = 3;
            // 
            // button31
            // 
            this.button31.Dock = System.Windows.Forms.DockStyle.Right;
            this.button31.Location = new System.Drawing.Point(1330, 0);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 30);
            this.button31.TabIndex = 2;
            this.button31.Text = "搜索";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // btnPartsRelativeDelete
            // 
            this.btnPartsRelativeDelete.AutoSize = true;
            this.btnPartsRelativeDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPartsRelativeDelete.Location = new System.Drawing.Point(162, 0);
            this.btnPartsRelativeDelete.Name = "btnPartsRelativeDelete";
            this.btnPartsRelativeDelete.Size = new System.Drawing.Size(75, 30);
            this.btnPartsRelativeDelete.TabIndex = 0;
            this.btnPartsRelativeDelete.Text = "Delete";
            this.btnPartsRelativeDelete.UseVisualStyleBackColor = true;
            // 
            // btnPartsRelativeExport
            // 
            this.btnPartsRelativeExport.AutoSize = true;
            this.btnPartsRelativeExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPartsRelativeExport.Location = new System.Drawing.Point(87, 0);
            this.btnPartsRelativeExport.Name = "btnPartsRelativeExport";
            this.btnPartsRelativeExport.Size = new System.Drawing.Size(75, 30);
            this.btnPartsRelativeExport.TabIndex = 0;
            this.btnPartsRelativeExport.Text = "Export";
            this.btnPartsRelativeExport.UseVisualStyleBackColor = true;
            // 
            // btnPartsRelativeSelect
            // 
            this.btnPartsRelativeSelect.AutoSize = true;
            this.btnPartsRelativeSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPartsRelativeSelect.Location = new System.Drawing.Point(0, 0);
            this.btnPartsRelativeSelect.Name = "btnPartsRelativeSelect";
            this.btnPartsRelativeSelect.Size = new System.Drawing.Size(87, 30);
            this.btnPartsRelativeSelect.TabIndex = 0;
            this.btnPartsRelativeSelect.Text = "Select Part";
            this.btnPartsRelativeSelect.UseVisualStyleBackColor = true;
            this.btnPartsRelativeSelect.Click += new System.EventHandler(this.btnPartsRelativeSelect_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView8.Location = new System.Drawing.Point(0, 0);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 24;
            this.dataGridView8.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView8.TabIndex = 11;
            // 
            // tpDocRelative
            // 
            this.tpDocRelative.AutoScroll = true;
            this.tpDocRelative.Controls.Add(this.panel19);
            this.tpDocRelative.Controls.Add(this.panel20);
            this.tpDocRelative.Controls.Add(this.dataGridView9);
            this.tpDocRelative.Location = new System.Drawing.Point(4, 25);
            this.tpDocRelative.Name = "tpDocRelative";
            this.tpDocRelative.Size = new System.Drawing.Size(1405, 248);
            this.tpDocRelative.TabIndex = 7;
            this.tpDocRelative.Text = "Doc relative";
            this.tpDocRelative.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel19.Location = new System.Drawing.Point(0, 218);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1405, 30);
            this.panel19.TabIndex = 10;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel20.Controls.Add(this.btnDocDel);
            this.panel20.Controls.Add(this.btnDocExport);
            this.panel20.Controls.Add(this.btnDocAdd);
            this.panel20.Controls.Add(this.label10);
            this.panel20.Controls.Add(this.label9);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1405, 30);
            this.panel20.TabIndex = 9;
            // 
            // btnDocDel
            // 
            this.btnDocDel.AutoSize = true;
            this.btnDocDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDocDel.Location = new System.Drawing.Point(159, 0);
            this.btnDocDel.Name = "btnDocDel";
            this.btnDocDel.Size = new System.Drawing.Size(75, 30);
            this.btnDocDel.TabIndex = 0;
            this.btnDocDel.Text = "Delete";
            this.btnDocDel.UseVisualStyleBackColor = true;
            // 
            // btnDocExport
            // 
            this.btnDocExport.AutoSize = true;
            this.btnDocExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDocExport.Location = new System.Drawing.Point(75, 0);
            this.btnDocExport.Name = "btnDocExport";
            this.btnDocExport.Size = new System.Drawing.Size(84, 30);
            this.btnDocExport.TabIndex = 0;
            this.btnDocExport.Text = "Export List";
            this.btnDocExport.UseVisualStyleBackColor = true;
            // 
            // btnDocAdd
            // 
            this.btnDocAdd.AutoSize = true;
            this.btnDocAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDocAdd.Location = new System.Drawing.Point(0, 0);
            this.btnDocAdd.Name = "btnDocAdd";
            this.btnDocAdd.Size = new System.Drawing.Size(75, 30);
            this.btnDocAdd.TabIndex = 0;
            this.btnDocAdd.Text = "Add";
            this.btnDocAdd.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "文档总数";
            // 
            // dataGridView9
            // 
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView9.Location = new System.Drawing.Point(0, 0);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.RowHeadersWidth = 51;
            this.dataGridView9.RowTemplate.Height = 24;
            this.dataGridView9.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView9.TabIndex = 11;
            // 
            // tpPicRelative
            // 
            this.tpPicRelative.AutoScroll = true;
            this.tpPicRelative.Controls.Add(this.panel22);
            this.tpPicRelative.Location = new System.Drawing.Point(4, 25);
            this.tpPicRelative.Name = "tpPicRelative";
            this.tpPicRelative.Size = new System.Drawing.Size(1405, 248);
            this.tpPicRelative.TabIndex = 8;
            this.tpPicRelative.Text = "Pic relative";
            this.tpPicRelative.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel22.Controls.Add(this.btnPicDel);
            this.panel22.Controls.Add(this.btnPicSet);
            this.panel22.Controls.Add(this.btnPicAdd);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1405, 30);
            this.panel22.TabIndex = 9;
            // 
            // btnPicDel
            // 
            this.btnPicDel.AutoSize = true;
            this.btnPicDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPicDel.Location = new System.Drawing.Point(195, 0);
            this.btnPicDel.Name = "btnPicDel";
            this.btnPicDel.Size = new System.Drawing.Size(75, 30);
            this.btnPicDel.TabIndex = 0;
            this.btnPicDel.Text = "Delete";
            this.btnPicDel.UseVisualStyleBackColor = true;
            // 
            // btnPicSet
            // 
            this.btnPicSet.AutoSize = true;
            this.btnPicSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPicSet.Location = new System.Drawing.Point(75, 0);
            this.btnPicSet.Name = "btnPicSet";
            this.btnPicSet.Size = new System.Drawing.Size(120, 30);
            this.btnPicSet.TabIndex = 0;
            this.btnPicSet.Text = "Set to thumbnail";
            this.btnPicSet.UseVisualStyleBackColor = true;
            // 
            // btnPicAdd
            // 
            this.btnPicAdd.AutoSize = true;
            this.btnPicAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPicAdd.Location = new System.Drawing.Point(0, 0);
            this.btnPicAdd.Name = "btnPicAdd";
            this.btnPicAdd.Size = new System.Drawing.Size(75, 30);
            this.btnPicAdd.TabIndex = 0;
            this.btnPicAdd.Text = "Upload";
            this.btnPicAdd.UseVisualStyleBackColor = true;
            // 
            // tpMaiteList
            // 
            this.tpMaiteList.AutoScroll = true;
            this.tpMaiteList.Controls.Add(this.panel21);
            this.tpMaiteList.Controls.Add(this.panel23);
            this.tpMaiteList.Controls.Add(this.dataGridView10);
            this.tpMaiteList.Location = new System.Drawing.Point(4, 25);
            this.tpMaiteList.Name = "tpMaiteList";
            this.tpMaiteList.Size = new System.Drawing.Size(1405, 248);
            this.tpMaiteList.TabIndex = 9;
            this.tpMaiteList.Text = "Maite list";
            this.tpMaiteList.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel21.Location = new System.Drawing.Point(0, 218);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1405, 30);
            this.panel21.TabIndex = 10;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel23.Controls.Add(this.btnMaiteListDel);
            this.panel23.Controls.Add(this.btnMaiteListExport);
            this.panel23.Controls.Add(this.btnMaiteListAdd);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(1405, 30);
            this.panel23.TabIndex = 9;
            // 
            // btnMaiteListDel
            // 
            this.btnMaiteListDel.AutoSize = true;
            this.btnMaiteListDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaiteListDel.Location = new System.Drawing.Point(150, 0);
            this.btnMaiteListDel.Name = "btnMaiteListDel";
            this.btnMaiteListDel.Size = new System.Drawing.Size(75, 30);
            this.btnMaiteListDel.TabIndex = 1;
            this.btnMaiteListDel.Text = "Delete";
            this.btnMaiteListDel.UseVisualStyleBackColor = true;
            // 
            // btnMaiteListExport
            // 
            this.btnMaiteListExport.AutoSize = true;
            this.btnMaiteListExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaiteListExport.Location = new System.Drawing.Point(75, 0);
            this.btnMaiteListExport.Name = "btnMaiteListExport";
            this.btnMaiteListExport.Size = new System.Drawing.Size(75, 30);
            this.btnMaiteListExport.TabIndex = 0;
            this.btnMaiteListExport.Text = "Export";
            this.btnMaiteListExport.UseVisualStyleBackColor = true;
            // 
            // btnMaiteListAdd
            // 
            this.btnMaiteListAdd.AutoSize = true;
            this.btnMaiteListAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaiteListAdd.Location = new System.Drawing.Point(0, 0);
            this.btnMaiteListAdd.Name = "btnMaiteListAdd";
            this.btnMaiteListAdd.Size = new System.Drawing.Size(75, 30);
            this.btnMaiteListAdd.TabIndex = 0;
            this.btnMaiteListAdd.Text = "Add";
            this.btnMaiteListAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView10.Location = new System.Drawing.Point(0, 0);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.RowHeadersWidth = 51;
            this.dataGridView10.RowTemplate.Height = 24;
            this.dataGridView10.Size = new System.Drawing.Size(1405, 248);
            this.dataGridView10.TabIndex = 11;
            // 
            // DeviceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 752);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceFrm";
            this.Text = "DeviceManageFrm";
            this.Load += new System.EventHandler(this.DeviceFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.pnlDevicePage.ResumeLayout(false);
            this.pnlDevicePage.PerformLayout();
            this.pnlDeviceList.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpDefect.ResumeLayout(false);
            this.pnlAuxMenu.ResumeLayout(false);
            this.pnlAuxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceDetail)).EndInit();
            this.tpRepairPlan.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpMaitPlan.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tpMaintOrder.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tpPlanOrder.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tpPartChangeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tpPartsRelative.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.tpDocRelative.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            this.tpPicRelative.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.tpMaiteList.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.Panel pnlDevicePage;
        private System.Windows.Forms.Panel pnlDeviceList;
        private System.Windows.Forms.Button btnDeviceDel;
        private System.Windows.Forms.Button btnDeviceImport;
        private System.Windows.Forms.Button btnDeviceEXport;
        private System.Windows.Forms.Button btnDeviceEdit;
        private System.Windows.Forms.Button btnDeviceAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDefect;
        private System.Windows.Forms.DataGridView dgvDeviceDetail;
        private System.Windows.Forms.Panel pnlAuxPage;
        private System.Windows.Forms.Panel pnlAuxMenu;
        private System.Windows.Forms.Button btnDefectDel;
        private System.Windows.Forms.Button btnDefectExport;
        private System.Windows.Forms.Button btnDefectAdd;
        private System.Windows.Forms.TabPage tpRepairPlan;
        private System.Windows.Forms.TabPage tpMaitPlan;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnMaintPlanDel;
        private System.Windows.Forms.Button btnMaitePlanExport;
        private System.Windows.Forms.Button btnMaitePlanAdd;
        private System.Windows.Forms.TabPage tpMaintOrder;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnMaintOrderDel;
        private System.Windows.Forms.Button btnMaintOrderExport;
        private System.Windows.Forms.Button btnMaintOrderAdd;
        private System.Windows.Forms.TabPage tpPlanOrder;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnPlanOrderDelete;
        private System.Windows.Forms.Button btnPlanOrderExport;
        private System.Windows.Forms.Button btnPlanOrderAdd;
        private System.Windows.Forms.TabPage tpPartChangeList;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TabPage tpPartsRelative;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button btnPartsRelativeDelete;
        private System.Windows.Forms.Button btnPartsRelativeExport;
        private System.Windows.Forms.Button btnPartsRelativeSelect;
        private System.Windows.Forms.TabPage tpDocRelative;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnDocDel;
        private System.Windows.Forms.Button btnDocExport;
        private System.Windows.Forms.Button btnDocAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpPicRelative;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnPicDel;
        private System.Windows.Forms.Button btnPicSet;
        private System.Windows.Forms.Button btnPicAdd;
        private System.Windows.Forms.TabPage tpMaiteList;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnMaiteListExport;
        private System.Windows.Forms.Button btnMaiteListAdd;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnRepairPlanDel;
        private System.Windows.Forms.Button btnRepairPlanExport;
        private System.Windows.Forms.Button btnRepairPlanAdd;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKKS;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKKS;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMaiteListDel;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNameEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNameCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DKKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNums;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}