
namespace DeviceApp
{
    partial class SetupFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDeviceStatus = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPartStatus = new System.Windows.Forms.TabPage();
            this.tpDeviceType = new System.Windows.Forms.TabPage();
            this.tpUnits = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 46);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUnits);
            this.tabControl1.Controls.Add(this.tpDeviceStatus);
            this.tabControl1.Controls.Add(this.tpPartStatus);
            this.tabControl1.Controls.Add(this.tpDeviceType);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 522);
            this.tabControl1.TabIndex = 1;
            // 
            // tpDeviceStatus
            // 
            this.tpDeviceStatus.Location = new System.Drawing.Point(4, 27);
            this.tpDeviceStatus.Name = "tpDeviceStatus";
            this.tpDeviceStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeviceStatus.Size = new System.Drawing.Size(1014, 384);
            this.tpDeviceStatus.TabIndex = 1;
            this.tpDeviceStatus.Text = "DeviceStatus";
            this.tpDeviceStatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(382, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(502, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 39);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Save  Before Change Over To Other Page";
            // 
            // tpPartStatus
            // 
            this.tpPartStatus.Location = new System.Drawing.Point(4, 27);
            this.tpPartStatus.Name = "tpPartStatus";
            this.tpPartStatus.Size = new System.Drawing.Size(1014, 384);
            this.tpPartStatus.TabIndex = 2;
            this.tpPartStatus.Text = "PartStatus";
            this.tpPartStatus.UseVisualStyleBackColor = true;
            // 
            // tpDeviceType
            // 
            this.tpDeviceType.Location = new System.Drawing.Point(4, 27);
            this.tpDeviceType.Name = "tpDeviceType";
            this.tpDeviceType.Size = new System.Drawing.Size(1014, 384);
            this.tpDeviceType.TabIndex = 3;
            this.tpDeviceType.Text = "DeviceType";
            this.tpDeviceType.UseVisualStyleBackColor = true;
            // 
            // tpUnits
            // 
            this.tpUnits.Location = new System.Drawing.Point(4, 27);
            this.tpUnits.Name = "tpUnits";
            this.tpUnits.Size = new System.Drawing.Size(1014, 491);
            this.tpUnits.TabIndex = 4;
            this.tpUnits.Text = "Units";
            this.tpUnits.UseVisualStyleBackColor = true;
            // 
            // SetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SetupFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDeviceStatus;
        private System.Windows.Forms.TabPage tpPartStatus;
        private System.Windows.Forms.TabPage tpDeviceType;
        private System.Windows.Forms.TabPage tpUnits;
    }
}