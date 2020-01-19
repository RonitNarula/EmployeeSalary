using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2RonitNarula
{
    public partial class Form1 : Form
    {
        Employee emp;
        List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GrpEmployeeType_Enter(object sender, EventArgs e)
        {

        }

        /*
         * Sets labels and text boxes accordingly when Hourly Paid Combo-box is selected
         */
        private void RdoHourlyPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHourlyPaid.Checked)
            {
                lbl1.Text = "Hours Worked:";
                lbl2.Text = "Hourly Wage:";
                txt2.Visible = true;
                txtName.Clear();
                txt1.Clear();
                txt2.Clear();
                txtGrossEarnings.Clear();
                txtLessTax.Clear();
                txtNetEarnings.Clear();
            }
        }

        /*
         * Sets labels and text boxes accordingly when Commission Based Combo-box is selected
         */
        private void RdoCommissionBased_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCommissionBased.Checked)
            {
                lbl1.Text = "Gross Sales:";
                lbl2.Text = "Commission Rate:";
                txt2.Visible = true;
                txtName.Clear();
                txt1.Clear();
                txt2.Clear();
                txtGrossEarnings.Clear();
                txtLessTax.Clear();
                txtNetEarnings.Clear();
            }
        }

        /*
         * Sets labels and text boxes accordingly when Weekly Salary Combo-box is selected
         */
        private void RdoWeeklySalary_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWeeklySalary.Checked)
            {
                lbl1.Text = "Weekly Salary:";
                lbl2.Text = "";
                txt2.Visible = false;
                txtName.Clear();
                txt1.Clear();
                txt2.Clear();
                txtGrossEarnings.Clear();
                txtLessTax.Clear();
                txtNetEarnings.Clear();
            }
        }

        /*
         * Closes the form when the close button is clicked
         */
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * Creates an employee object polymorphically
         */
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (rdoHourlyPaid.Checked)
            {
                try
                {
                    if (double.Parse(txt1.Text) <= 0 || double.Parse(txt1.Text) > 80)
                    {
                        throw new Exception("Hours worked cannot be more than 0 or less than 80");
                    }
                    if (txt1.Text == "" || txt2.Text == "")
                    {
                        throw new Exception("Hours worked or hourly wage cannot be left empty");
                    }
                    if(double.Parse(txt2.Text) <= 0)
                    {
                        throw new Exception("Hourly wage must be a positive real number");
                    }
                    else
                    {
                        emp = new HourlyEmployee(txtName.Text, EmployeeType.HourlyEmployee,
                            Double.Parse(txt1.Text), Double.Parse(txt2.Text));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (rdoCommissionBased.Checked)
            {
                try
                {
                    if(double.Parse(txt1.Text) <= 0 || double.Parse(txt2.Text) <= 0)
                    {
                        throw new Exception("Gross Sales or Commission Rate must be a positive real number");
                    }
                    if (txt1.Text == "" || txt2.Text == "")
                    {
                        throw new Exception("Commission rate or gross sales cannot be left empty");
                    }
                    else
                    {
                        emp = new CommissionEmployee(txtName.Text, EmployeeType.CommissionEmployee,
                            Double.Parse(txt1.Text), Double.Parse(txt2.Text));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (rdoWeeklySalary.Checked)
            {
                try
                {
                    if (double.Parse(txt1.Text) <= 0)
                    {
                        throw new Exception("Weekly Salary must be a positive real number");
                    }
                    if (txt1.Text == "")
                    {
                        throw new Exception("Weekly Salary cannot be left empty");
                    }
                    else
                    {
                        emp = new SalariedEmployee(txtName.Text, EmployeeType.SalariedEmployee,
                            Double.Parse(txt1.Text));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //foreach (Employee emp in employeeList)
            //{
            //    if (txtName.Text == emp.Name)
            //        throw new Exception("Name cannot be repeated");
            //}

            try
            {
                if (txtName.Text == "")
                {
                    throw new Exception("Name field cannot be left empty");
                }
                else
                {
                    txtGrossEarnings.Text = emp.GrossEarnings.ToString("C");
                    txtNetEarnings.Text = emp.NetEarnings.ToString("C");
                    txtLessTax.Text = emp.Tax.ToString("C");
                    employeeList.Add(emp);
                    cmbEmployees.Items.Add(txtName.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * Display Results based on the Name selected from the combo-box
         */
        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = employeeList[cmbEmployees.SelectedIndex];
            switch (employee.TypeOfEmployee)
            {
                case EmployeeType.HourlyEmployee:
                    rdoHourlyPaid.Select();
                    txtName.Text = employee.Name;
                    txt1.Text = employee.HoursWorked.ToString();
                    txt2.Text = employee.HourlyWage.ToString("C");
                    txtGrossEarnings.Text = employee.GrossEarnings.ToString("C");
                    txtNetEarnings.Text = employee.NetEarnings.ToString("C");
                    txtLessTax.Text = employee.Tax.ToString("C");
                    break;
                case EmployeeType.CommissionEmployee:
                    rdoCommissionBased.Select();
                    txtName.Text = employee.Name;
                    txt1.Text = employee.GrossSales.ToString("C");
                    txt2.Text = employee.CommissionRate.ToString("P");
                    txtGrossEarnings.Text = employee.GrossEarnings.ToString("C");
                    txtNetEarnings.Text = employee.NetEarnings.ToString("C");
                    txtLessTax.Text = employee.Tax.ToString("C");
                    break;
                case EmployeeType.SalariedEmployee:
                    rdoWeeklySalary.Select();
                    txtName.Text = employee.Name;
                    txt1.Text = employee.WeeklySalary.ToString("C");
                    txtGrossEarnings.Text = employee.GrossEarnings.ToString("C");
                    txtNetEarnings.Text = employee.NetEarnings.ToString("C");
                    txtLessTax.Text = employee.Tax.ToString("C");
                    break;
            }
        }

        /*
         * Clears the form when the clear button is clicked
         */
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txt1.Clear();
            txt2.Clear();
            txtGrossEarnings.Clear();
            txtLessTax.Clear();
            txtNetEarnings.Clear();
        }
    }
}
