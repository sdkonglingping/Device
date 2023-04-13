
namespace DeviceApp
{
    partial class PartDetailFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCN = new System.Windows.Forms.TextBox();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNameEN = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbManuf = new System.Windows.Forms.ComboBox();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkContinue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtNameCN
            // 
            this.txtNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PNameCN", true));
            this.txtNameCN.Location = new System.Drawing.Point(137, 56);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.Size = new System.Drawing.Size(338, 22);
            this.txtNameCN.TabIndex = 1;
            // 
            // cmbProvider
            // 
            this.cmbProvider.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "Provider", true));
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(137, 398);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(769, 24);
            this.cmbProvider.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NameCN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "NameEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lifecycle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manufacturer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Provider";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Remark";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(327, 576);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(484, 576);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 34);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PId", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(137, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtNameEN
            // 
            this.txtNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PNameEN", true));
            this.txtNameEN.Location = new System.Drawing.Point(137, 100);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(338, 22);
            this.txtNameEN.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PKKS", true));
            this.txtNo.Location = new System.Drawing.Point(137, 144);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(338, 22);
            this.txtNo.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PModel", true));
            this.txtModel.Location = new System.Drawing.Point(137, 232);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(769, 104);
            this.txtModel.TabIndex = 1;
            // 
            // cmbManuf
            // 
            this.cmbManuf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "Manufacturer", true));
            this.cmbManuf.FormattingEnabled = true;
            this.cmbManuf.Location = new System.Drawing.Point(137, 352);
            this.cmbManuf.Name = "cmbManuf";
            this.cmbManuf.Size = new System.Drawing.Size(769, 24);
            this.cmbManuf.TabIndex = 2;
            // 
            // txtLife
            // 
            this.txtLife.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "Lifecycle", true));
            this.txtLife.Location = new System.Drawing.Point(137, 188);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(338, 22);
            this.txtLife.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PRemark", true));
            this.txtRemark.Location = new System.Drawing.Point(137, 444);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(769, 104);
            this.txtRemark.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Year";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Model.Part);
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(756, 588);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(115, 21);
            this.chkContinue.TabIndex = 4;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // PartDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 630);
            this.Controls.Add(this.chkContinue);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbManuf);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.txtLife);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNameCN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartDetailFrm";
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameCN;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNameEN;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbManuf;
        private System.Windows.Forms.TextBox txtLife;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.CheckBox chkContinue;
    }
}