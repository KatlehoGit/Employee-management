namespace Ch12Ex3
{
    partial class CfrmPayslip
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
            this.btnOK = new System.Windows.Forms.Button();
            this.grpbxPayslip = new System.Windows.Forms.GroupBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpbxPayslip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(183, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpbxPayslip
            // 
            this.grpbxPayslip.Controls.Add(this.lblSurname);
            this.grpbxPayslip.Controls.Add(this.lblName);
            this.grpbxPayslip.Controls.Add(this.lblDOB);
            this.grpbxPayslip.Controls.Add(this.lblType);
            this.grpbxPayslip.Controls.Add(this.lblGrossSalary);
            this.grpbxPayslip.Controls.Add(this.lblNetSalary);
            this.grpbxPayslip.Controls.Add(this.lblID);
            this.grpbxPayslip.Location = new System.Drawing.Point(12, 12);
            this.grpbxPayslip.Name = "grpbxPayslip";
            this.grpbxPayslip.Size = new System.Drawing.Size(430, 251);
            this.grpbxPayslip.TabIndex = 15;
            this.grpbxPayslip.TabStop = false;
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(15, 49);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(398, 33);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "label7";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 33);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label6";
            // 
            // lblDOB
            // 
            this.lblDOB.Location = new System.Drawing.Point(15, 127);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(119, 24);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "label5";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(15, 151);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(119, 24);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "label4";
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.Location = new System.Drawing.Point(15, 175);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(119, 33);
            this.lblGrossSalary.TabIndex = 2;
            this.lblGrossSalary.Text = "label3";
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.Location = new System.Drawing.Point(15, 208);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(119, 29);
            this.lblNetSalary.TabIndex = 1;
            this.lblNetSalary.Text = "label2";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(15, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "label1";
            // 
            // CfrmPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 316);
            this.Controls.Add(this.grpbxPayslip);
            this.Controls.Add(this.btnOK);
            this.Name = "CfrmPayslip";
            this.Text = "Pay Slip";
            this.Load += new System.EventHandler(this.CfrmPayslip_Load);
            this.grpbxPayslip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpbxPayslip;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label lblID;
    }
}