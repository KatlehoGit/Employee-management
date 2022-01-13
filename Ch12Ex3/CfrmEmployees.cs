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
using System.Globalization;
using System.Windows;
using Microsoft.VisualBasic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ch12Ex3
{
    public partial class CfrmEmployees : Form
    {
        CCommisioned commisioned = new CCommisioned();
        CEmployee cEmployee = new CEmployee();
        decimal _gross;
        static double dTax;
        double _tax = dTax;
        static double dcom;
        double com = dcom;
        public CfrmEmployees()
        {
            InitializeComponent();
            //_gross = decimal.Parse(txtGrossSalary.Text);
            //dTax = (double)nudTax.Value;
            //dcom = (double)nudCommission.Value;

            //if (radCommissioned.Checked)
            //{
            //    s = "Commissioned";
            //}
            //else
            //    s = "Salaried";
        }

        private void CfrmEmployees_Load(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtGrossSalary.Clear();
            nudCommission.Value = 0;
            nudTax.Value = 0;
            lstbxEmployees.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void radSalaried_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeType();
        }

        public string EmployeeType()
        {
            string c = "Commissioned";
            string s = "Salaried";
            if (radCommissioned.Checked)
            {
                var checkedButton = grpBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                return checkedButton.ToString();
            }
            else
                return s;
        }

        private void nudCommission_KeyUp(object sender, KeyEventArgs e)
        {
            commisioned.dCommision += 1;
        }

        private void nudCommission_KeyDown(object sender, KeyEventArgs e)
        {
            commisioned.dCommision -= 1;

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            //DateTime.P
            //DateTime date = new DateTime();
            string date = dtpDOB.Value.ToLongDateString();
            string Em = TypeOfEmployees();
            CfrmPayslip payslip = new CfrmPayslip(txtID.Text, txtSurname.Text, txtName.Text, GetDate(), decimal.Parse(txtGrossSalary.Text), EmployeeType(), NetSalary(_gross, dTax, com));

            

            payslip.ShowDialog();
        }

        private void nudCommission_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private decimal NetSalary(decimal _gross, double _tax, double _commission)
        {

            _gross = decimal.Parse(txtGrossSalary.Text);
            dTax = (double)nudTax.Value;
            dcom = (double)nudCommission.Value;

            if (radCommissioned.Checked)
            {
                CCommisioned commisioned = new CCommisioned();
                
                decimal Net = commisioned.NetSalary(_gross, dTax, dcom);
                return Net;
            }
            else
            {
                CSalaried salaried = new CSalaried();
                decimal net = salaried.NetSalary(_gross, dTax, dcom);
                return net;
            }
        }

        public string TypeOfEmployees()
        {
            if (radCommissioned.Checked)
                return radCommissioned.Text.ToString();
            else if (radSalaried.Checked)
                return radSalaried.Text.ToString();
            else
               return "button";
        }

        public string GetDate()
        {
            //object value = new DateTime();
            //DateTime result = (DateTime)value;
            //string s = 
            //Console.WriteLine(result.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));

            DateTime date = dtpDOB.Value;
            string sDay = date.Day.ToString();
            string sMonth = date.Month.ToString();
            string sYear = date.Year.ToString();

            string sDate = sDay + " " + sMonth + " " + sYear;
            return sDate;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstbxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("No value selected", "Value");
            }
            if (lstbxEmployees.SelectedIndex > -1)
            {
               if (MessageBox.Show("Are you sure you want to delete this Employee?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstbxEmployees.Items.RemoveAt(lstbxEmployees.SelectedIndex);
                }
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = Interaction.InputBox("Enter employee ID", "New Employee ID");
            cEmployee.ID = ID;
            string Name = Interaction.InputBox("Enter employee Name", "New Employee Name");
            cEmployee.Name = Name;
            string Surname = Interaction.InputBox("Enter employee Surname", "New Employee Surname");
            cEmployee.Surname = Surname;
            lstbxEmployees.Items.Add(cEmployee.Surname + ", " + cEmployee.Name);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use Employees.ser", "File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            sfdlgEmployees.InitialDirectory = Application.StartupPath;
            sfdlgEmployees.FileName = "Employees.ser";
            sfdlgEmployees.OverwritePrompt = false;
            if (sfdlgEmployees.ShowDialog() == DialogResult.OK)
            {
                cEmployee.Save(sfdlgEmployees.FileName);
                MessageBox.Show("Save successful");
            }
            else
                MessageBox.Show("Save unsuccessful");
        }

        private void lstbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            do
            {
                // lstbxEmployees.GetSelected(lstbxEmployees.SelectedIndex)
                string s = lstbxEmployees.SelectedItem.ToString();
                //string Name = s.Substring(',');
                string Name = s.Substring(s.IndexOf(","));
                string Surname = s.Substring(0, s.IndexOf(","));

                txtName.Text = Name;
                txtSurname.Text = Surname;
            }
            while (lstbxEmployees.SelectedIndex < lstbxEmployees.Items.Count);

            //string s = lstbxEmployees.SelectedValue.ToString();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            CFrmAbout about = new CFrmAbout();
            about.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //cEmployee.Read("Employees.ser");
            ofdlgEmployees.InitialDirectory = Application.StartupPath;
            ofdlgEmployees.FileName = "Employees.ser";

            if (ofdlgEmployees.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(ofdlgEmployees.FileName, FileMode.Open);
                BinaryReader f = new BinaryReader(file);

                lstbxEmployees.Items.Clear();
                
                while(f.PeekChar() > 0)
                {
                    lstbxEmployees.Items.Add(f.ReadString());
                }
                f.Close();
                file.Close();
            }
        }

        //public string TypeOfEmployees()
        //{

        //    if (radCommissioned.Checked)
        //    {
        //        //MessageBox.Show("Commissioned");
        //        return radCommissioned.Text.ToString();
        //    }
        //    else (radSalaried.Checked)
        //    {
        //        // MessageBox.Show("Salaried");
        //        return radSalaried.Text.ToString();
        //    }

        //}
    }
}
