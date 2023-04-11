
namespace DeviceApp
{
    partial class DeviceDetailFrm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDeviceInfo = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.pnlDeviceStatus = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.pnlDocRelative = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.pnlPicRelative = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pnlDevice = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbDType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDModel = new System.Windows.Forms.TextBox();
            this.txtDNameEN = new System.Windows.Forms.TextBox();
            this.txtNameCN = new System.Windows.Forms.TextBox();
            this.txtKKS = new System.Windows.Forms.TextBox();
            this.txtDId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbDStatus = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pnlPics = new System.Windows.Forms.Panel();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pnlDoc = new System.Windows.Forms.Panel();
            this.pnlDeviceInfo.SuspendLayout();
            this.pnlDeviceStatus.SuspendLayout();
            this.pnlDocRelative.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlPicRelative.SuspendLayout();
            this.pnlDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(496, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 34);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(643, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 34);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDeviceInfo
            // 
            this.pnlDeviceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlDeviceInfo.Controls.Add(this.label31);
            this.pnlDeviceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlDeviceInfo.Name = "pnlDeviceInfo";
            this.pnlDeviceInfo.Size = new System.Drawing.Size(1238, 32);
            this.pnlDeviceInfo.TabIndex = 38;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = new System.Drawing.Point(5, 1);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(230, 29);
            this.label31.TabIndex = 23;
            this.label31.Text = "Device Information";
            // 
            // pnlDeviceStatus
            // 
            this.pnlDeviceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlDeviceStatus.Controls.Add(this.label22);
            this.pnlDeviceStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceStatus.Location = new System.Drawing.Point(0, 168);
            this.pnlDeviceStatus.Name = "pnlDeviceStatus";
            this.pnlDeviceStatus.Size = new System.Drawing.Size(1238, 32);
            this.pnlDeviceStatus.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(5, 1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 29);
            this.label22.TabIndex = 23;
            this.label22.Text = "Device Status";
            // 
            // pnlDocRelative
            // 
            this.pnlDocRelative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlDocRelative.Controls.Add(this.label32);
            this.pnlDocRelative.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocRelative.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDocRelative.Location = new System.Drawing.Point(0, 391);
            this.pnlDocRelative.Name = "pnlDocRelative";
            this.pnlDocRelative.Size = new System.Drawing.Size(1238, 32);
            this.pnlDocRelative.TabIndex = 38;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label32.Location = new System.Drawing.Point(5, 1);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(260, 29);
            this.label32.TabIndex = 23;
            this.label32.Text = "Relatived Documents";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.chkContinue);
            this.panel5.Controls.Add(this.btnSubmit);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 698);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1238, 44);
            this.panel5.TabIndex = 39;
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(1064, 13);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(115, 21);
            this.chkContinue.TabIndex = 35;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // pnlPicRelative
            // 
            this.pnlPicRelative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlPicRelative.Controls.Add(this.label23);
            this.pnlPicRelative.Controls.Add(this.label29);
            this.pnlPicRelative.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicRelative.Location = new System.Drawing.Point(0, 566);
            this.pnlPicRelative.Name = "pnlPicRelative";
            this.pnlPicRelative.Size = new System.Drawing.Size(1238, 32);
            this.pnlPicRelative.TabIndex = 38;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(5, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(225, 29);
            this.label23.TabIndex = 23;
            this.label23.Text = "Relatived Pictures";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = new System.Drawing.Point(908, 8);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(254, 17);
            this.label29.TabIndex = 38;
            this.label29.Text = "png/jpg/jpeg Only，and 5 Pcs is limited";
            // 
            // pnlDevice
            // 
            this.pnlDevice.Controls.Add(this.dtpStartDate);
            this.pnlDevice.Controls.Add(this.cmbProvider);
            this.pnlDevice.Controls.Add(this.cmbManufacturer);
            this.pnlDevice.Controls.Add(this.cmbDType);
            this.pnlDevice.Controls.Add(this.label12);
            this.pnlDevice.Controls.Add(this.label6);
            this.pnlDevice.Controls.Add(this.label5);
            this.pnlDevice.Controls.Add(this.label4);
            this.pnlDevice.Controls.Add(this.label3);
            this.pnlDevice.Controls.Add(this.label2);
            this.pnlDevice.Controls.Add(this.txtDModel);
            this.pnlDevice.Controls.Add(this.txtDNameEN);
            this.pnlDevice.Controls.Add(this.txtNameCN);
            this.pnlDevice.Controls.Add(this.txtKKS);
            this.pnlDevice.Controls.Add(this.txtDId);
            this.pnlDevice.Controls.Add(this.label1);
            this.pnlDevice.Controls.Add(this.label33);
            this.pnlDevice.Controls.Add(this.lblId);
            this.pnlDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDevice.Location = new System.Drawing.Point(0, 32);
            this.pnlDevice.Name = "pnlDevice";
            this.pnlDevice.Size = new System.Drawing.Size(1238, 136);
            this.pnlDevice.TabIndex = 40;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "StartDate", true));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(940, 55);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(307, 22);
            this.dtpStartDate.TabIndex = 65;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(Model.Device);
            // 
            // cmbProvider
            // 
            this.cmbProvider.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Provider", true));
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(693, 89);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(554, 24);
            this.cmbProvider.TabIndex = 62;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Manufacturer", true));
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(124, 89);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(449, 24);
            this.cmbManufacturer.TabIndex = 61;
            // 
            // cmbDType
            // 
            this.cmbDType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DType", true));
            this.cmbDType.FormattingEnabled = true;
            this.cmbDType.Location = new System.Drawing.Point(821, 14);
            this.cmbDType.Name = "cmbDType";
            this.cmbDType.Size = new System.Drawing.Size(187, 24);
            this.cmbDType.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(842, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Provider";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Manufecturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "NameEN";
            // 
            // txtDModel
            // 
            this.txtDModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DModel", true));
            this.txtDModel.Location = new System.Drawing.Point(76, 53);
            this.txtDModel.Name = "txtDModel";
            this.txtDModel.Size = new System.Drawing.Size(744, 22);
            this.txtDModel.TabIndex = 36;
            // 
            // txtDNameEN
            // 
            this.txtDNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DNameEN", true));
            this.txtDNameEN.Location = new System.Drawing.Point(516, 16);
            this.txtDNameEN.Name = "txtDNameEN";
            this.txtDNameEN.Size = new System.Drawing.Size(244, 22);
            this.txtDNameEN.TabIndex = 35;
            // 
            // txtNameCN
            // 
            this.txtNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DNameCN", true));
            this.txtNameCN.Location = new System.Drawing.Point(233, 16);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.Size = new System.Drawing.Size(199, 22);
            this.txtNameCN.TabIndex = 39;
            // 
            // txtKKS
            // 
            this.txtKKS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DKKS", true));
            this.txtKKS.Location = new System.Drawing.Point(1076, 16);
            this.txtKKS.Name = "txtKKS";
            this.txtKKS.Size = new System.Drawing.Size(171, 22);
            this.txtKKS.TabIndex = 39;
            // 
            // txtDId
            // 
            this.txtDId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DId", true));
            this.txtDId.Enabled = false;
            this.txtDId.Location = new System.Drawing.Point(76, 14);
            this.txtDId.Name = "txtDId";
            this.txtDId.Size = new System.Drawing.Size(81, 22);
            this.txtDId.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1030, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "KKS";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(163, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 17);
            this.label33.TabIndex = 34;
            this.label33.Text = "NameCN";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(24, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 17);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "Did";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.cmbArea);
            this.pnlStatus.Controls.Add(this.cmbDStatus);
            this.pnlStatus.Controls.Add(this.label20);
            this.pnlStatus.Controls.Add(this.label19);
            this.pnlStatus.Controls.Add(this.label16);
            this.pnlStatus.Controls.Add(this.txtRemark);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 200);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1238, 191);
            this.pnlStatus.TabIndex = 41;
            // 
            // cmbArea
            // 
            this.cmbArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DArea", true));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(693, 18);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(554, 24);
            this.cmbArea.TabIndex = 42;
            // 
            // cmbDStatus
            // 
            this.cmbDStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DStatus", true));
            this.cmbDStatus.FormattingEnabled = true;
            this.cmbDStatus.Location = new System.Drawing.Point(95, 11);
            this.cmbDStatus.Name = "cmbDStatus";
            this.cmbDStatus.Size = new System.Drawing.Size(478, 24);
            this.cmbDStatus.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(640, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 17);
            this.label20.TabIndex = 39;
            this.label20.Text = "Area";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 38;
            this.label19.Text = "Remark";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "Status";
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "DRemark", true));
            this.txtRemark.Location = new System.Drawing.Point(95, 54);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(1152, 120);
            this.txtRemark.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbDocType);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 55);
            this.panel1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 48;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbDocType
            // 
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Location = new System.Drawing.Point(139, 18);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(395, 24);
            this.cmbDocType.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 17);
            this.label21.TabIndex = 46;
            this.label21.Text = "Document Type";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(991, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 17);
            this.label28.TabIndex = 44;
            this.label28.Text = "M";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(950, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(679, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(267, 17);
            this.label26.TabIndex = 43;
            this.label26.Text = "Totle size is limited to 30M        Uploaded";
            // 
            // pnlPics
            // 
            this.pnlPics.Controls.Add(this.btnAddPic);
            this.pnlPics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPics.Location = new System.Drawing.Point(0, 598);
            this.pnlPics.Name = "pnlPics";
            this.pnlPics.Size = new System.Drawing.Size(1238, 100);
            this.pnlPics.TabIndex = 43;
            // 
            // btnAddPic
            // 
            this.btnAddPic.AutoSize = true;
            this.btnAddPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Location = new System.Drawing.Point(0, 0);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(101, 100);
            this.btnAddPic.TabIndex = 0;
            this.btnAddPic.Text = "Upload";
            this.btnAddPic.UseVisualStyleBackColor = true;
            // 
            // pnlDoc
            // 
            this.pnlDoc.AutoScroll = true;
            this.pnlDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDoc.Location = new System.Drawing.Point(0, 478);
            this.pnlDoc.Name = "pnlDoc";
            this.pnlDoc.Size = new System.Drawing.Size(1238, 88);
            this.pnlDoc.TabIndex = 45;
            // 
            // DeviceDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1259, 725);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlPics);
            this.Controls.Add(this.pnlPicRelative);
            this.Controls.Add(this.pnlDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDocRelative);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlDeviceStatus);
            this.Controls.Add(this.pnlDevice);
            this.Controls.Add(this.pnlDeviceInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceDetailFrm";
            this.Load += new System.EventHandler(this.DeviceDetailFrm_Load);
            this.pnlDeviceInfo.ResumeLayout(false);
            this.pnlDeviceInfo.PerformLayout();
            this.pnlDeviceStatus.ResumeLayout(false);
            this.pnlDeviceStatus.PerformLayout();
            this.pnlDocRelative.ResumeLayout(false);
            this.pnlDocRelative.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlPicRelative.ResumeLayout(false);
            this.pnlPicRelative.PerformLayout();
            this.pnlDevice.ResumeLayout(false);
            this.pnlDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPics.ResumeLayout(false);
            this.pnlPics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDeviceInfo;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel pnlDeviceStatus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pnlDocRelative;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlPicRelative;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlDevice;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbDType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDModel;
        private System.Windows.Forms.TextBox txtDNameEN;
        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbDStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel pnlPics;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDocType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel pnlDoc;
        private System.Windows.Forms.TextBox txtNameCN;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtKKS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.CheckBox chkContinue;
    }
}