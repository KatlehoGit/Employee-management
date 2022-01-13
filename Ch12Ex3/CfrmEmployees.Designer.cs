namespace Ch12Ex3
{
    partial class CfrmEmployees
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
            this.radSalaried = new System.Windows.Forms.RadioButton();
            this.radCommissioned = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGrossSalary = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.grpbxPercentages = new System.Windows.Forms.GroupBox();
            this.nudCommission = new System.Windows.Forms.NumericUpDown();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.lblCommision = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbxEmployees = new System.Windows.Forms.ListBox();
            this.ofdlgEmployees = new System.Windows.Forms.OpenFileDialog();
            this.sfdlgEmployees = new System.Windows.Forms.SaveFileDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpbxPercentages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSalaried
            // 
            this.radSalaried.AutoSize = true;
            this.radSalaried.Location = new System.Drawing.Point(6, 21);
            this.radSalaried.Name = "radSalaried";
            this.radSalaried.Size = new System.Drawing.Size(111, 17);
            this.radSalaried.TabIndex = 0;
            this.radSalaried.TabStop = true;
            this.radSalaried.Text = "Salaried employee";
            this.radSalaried.UseVisualStyleBackColor = true;
            this.radSalaried.CheckedChanged += new System.EventHandler(this.radSalaried_CheckedChanged);
            // 
            // radCommissioned
            // 
            this.radCommissioned.AutoSize = true;
            this.radCommissioned.Location = new System.Drawing.Point(6, 44);
            this.radCommissioned.Name = "radCommissioned";
            this.radCommissioned.Size = new System.Drawing.Size(140, 17);
            this.radCommissioned.TabIndex = 1;
            this.radCommissioned.TabStop = true;
            this.radCommissioned.Text = "Commissioned employee";
            this.radCommissioned.UseVisualStyleBackColor = true;
            this.radCommissioned.CheckedChanged += new System.EventHandler(this.radSalaried_CheckedChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(179, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.Location = new System.Drawing.Point(179, 180);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(66, 13);
            this.lblGrossSalary.TabIndex = 3;
            this.lblGrossSalary.Text = "Gross Salary";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(179, 143);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(179, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(179, 78);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(281, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(281, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(281, 71);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 9;
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.Location = new System.Drawing.Point(281, 173);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.Size = new System.Drawing.Size(100, 20);
            this.txtGrossSalary.TabIndex = 10;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(455, 167);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(67, 23);
            this.btnClearFields.TabIndex = 12;
            this.btnClearFields.Text = "Clear fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPayslip
            // 
            this.btnPayslip.Location = new System.Drawing.Point(611, 206);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(52, 23);
            this.btnPayslip.TabIndex = 14;
            this.btnPayslip.Text = "Payslip";
            this.btnPayslip.UseVisualStyleBackColor = true;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // grpbxPercentages
            // 
            this.grpbxPercentages.Controls.Add(this.nudCommission);
            this.grpbxPercentages.Controls.Add(this.nudTax);
            this.grpbxPercentages.Controls.Add(this.lblCommision);
            this.grpbxPercentages.Controls.Add(this.lblTax);
            this.grpbxPercentages.Location = new System.Drawing.Point(653, 22);
            this.grpbxPercentages.Name = "grpbxPercentages";
            this.grpbxPercentages.Size = new System.Drawing.Size(200, 100);
            this.grpbxPercentages.TabIndex = 15;
            this.grpbxPercentages.TabStop = false;
            this.grpbxPercentages.Text = "Apply to all employees";
            // 
            // nudCommission
            // 
            this.nudCommission.Location = new System.Drawing.Point(142, 61);
            this.nudCommission.Name = "nudCommission";
            this.nudCommission.Size = new System.Drawing.Size(42, 20);
            this.nudCommission.TabIndex = 3;
            this.nudCommission.ValueChanged += new System.EventHandler(this.nudCommission_ValueChanged);
            this.nudCommission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudCommission_KeyDown);
            this.nudCommission.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudCommission_KeyUp);
            // 
            // nudTax
            // 
            this.nudTax.Location = new System.Drawing.Point(142, 26);
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(42, 20);
            this.nudTax.TabIndex = 2;
            // 
            // lblCommision
            // 
            this.lblCommision.AutoSize = true;
            this.lblCommision.Location = new System.Drawing.Point(6, 63);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(119, 13);
            this.lblCommision.TabIndex = 1;
            this.lblCommision.Text = "Commission percentage";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(6, 28);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(82, 13);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "Tax percentage";
            this.lblTax.Click += new System.EventHandler(this.label_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(281, 136);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpDOB.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(495, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.radSalaried);
            this.grpBox.Controls.Add(this.radCommissioned);
            this.grpBox.Location = new System.Drawing.Point(455, 38);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(153, 60);
            this.grpBox.TabIndex = 18;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Employees";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(281, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add new employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstbxEmployees
            // 
            this.lstbxEmployees.FormattingEnabled = true;
            this.lstbxEmployees.Location = new System.Drawing.Point(12, 12);
            this.lstbxEmployees.Name = "lstbxEmployees";
            this.lstbxEmployees.Size = new System.Drawing.Size(137, 225);
            this.lstbxEmployees.TabIndex = 21;
            this.lstbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lstbxEmployees_SelectedIndexChanged);
            // 
            // ofdlgEmployees
            // 
            this.ofdlgEmployees.FileName = "openFileDialog1";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(669, 206);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(596, 167);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 23);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load from file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // CfrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 241);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lstbxEmployees);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.grpbxPercentages);
            this.Controls.Add(this.btnPayslip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtGrossSalary);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.lblID);
            this.Name = "CfrmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.CfrmEmployees_Load);
            this.grpbxPercentages.ResumeLayout(false);
            this.grpbxPercentages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSalaried;
        private System.Windows.Forms.RadioButton radCommissioned;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGrossSalary;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPayslip;
        private System.Windows.Forms.GroupBox grpbxPercentages;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.NumericUpDown nudCommission;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstbxEmployees;
        private System.Windows.Forms.OpenFileDialog ofdlgEmployees;
        private System.Windows.Forms.SaveFileDialog sfdlgEmployees;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLoad;
    }
}

