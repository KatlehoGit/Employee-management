/*2017115029
Katleho Moalosi
Assignment 1
CSIS2614*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12Ex3
{
    public partial class CfrmPayslip : Form
    {
        public CfrmPayslip(string sId, string sSurname, string sName, string sDOB, decimal sGrossSalary,string sEmployeeType, decimal mNetSalary)
        {
            InitializeComponent();
            this.lblDOB.Text = this.lblGrossSalary.Text = this.lblID.Text = this.lblName.Text = this.lblNetSalary.Text = this.lblSurname.Text = this.lblType.Text = "";
            CfrmEmployees cfrmEmployees = new CfrmEmployees();

            //sEmployeeType = cfrmEmployees.EmployeeType();
            sDOB = cfrmEmployees.GetDate();

            this.lblID.Text += "ID" + "\t" + ": " + sId.PadRight(5);
            this.lblSurname.Text += "Surname" + "\t" + ": " + sSurname.PadLeft(5);
            this.lblName.Text += "Name" + "\t" + ": " + sName.PadRight(5);
            this.lblDOB.Text += "Date of birth" + "\t" + ": " + sDOB.PadRight(5);
            this.lblType.Text += "Employee type" + "\t" + ": "+ sEmployeeType; //Needs to be completeted
            this.lblGrossSalary.Text += "Gross salary" + "\t" + ": " + sGrossSalary.ToString();
            this.lblNetSalary.Text += "Net salary" + "\t" + ": " + mNetSalary.ToString();
        }

      
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CfrmPayslip_Load(object sender, EventArgs e)
        {

        }
    }
}
