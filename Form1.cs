using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_EmployeePayroll
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        Employee newHire = null;
        private int Option { get; set; }
        private string firstName = "";
        private string lastName = "";
        private string ssn = "";
        private decimal rate;
        private decimal hours;
        private decimal sales;
        public Form1()
        {
            InitializeComponent();
            rbSalary.Checked = true;    //Salary Employee is always Checked
            Option = 1;                 //Default selection
        }

        private void ClearUI()
        {
            //Clear input after create
            tbFirstName.Clear();
            tbLastName.Clear();
            tbSSN.Clear();
            tbRate.Clear();
            tbHours.Clear();
        }

        private bool ValidateEmp()
        {
            firstName = tbFirstName.Text.Trim();
            lastName = tbLastName.Text.Trim();
            ssn = tbSSN.Text.Trim();

            //Fields can't be null
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(ssn))
            {
                lbAlerts.Visible = true;
                lbAlerts.Text = "All fields must be filled.";
                return false;
            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                lbAlerts.Visible = true;
                lbAlerts.Text = "The name cannot contain numbers.";
                return false;
            }
            if (!ssn.Any(char.IsDigit))
            {
                lbAlerts.Visible = true;
                lbAlerts.Text = "A social cannot contain letters.";
                return false;
            }
            if (ssn.Length < 9 || ssn.Length > 9)
            {
                lbAlerts.Visible = true;
                lbAlerts.Text = "A social is 9 digits long.";
                return false;
            }
            if (!decimal.TryParse(tbRate.Text, out rate))
            {
                lbAlerts.Visible = true;
                lbAlerts.Text = "Please enter a rate. ";
                return false;
            }
            if (rate <= 0)
            {
                lbAlerts.Visible = true;
                lbAlerts.Text = "The rate entered cannot be negative or 0.";
                return false;
            }

            //Only parse if option 2 or 3
            if (Option == 2 || Option == 3)
            {
                if (!decimal.TryParse(tbHours.Text, out hours))
                {
                    lbAlerts.Visible = true;
                    lbAlerts.Text = "Please enter a valid amount of hours. ";
                    return false;
                }
                if (hours <= 0)
                {
                    lbAlerts.Visible = true;
                    lbAlerts.Text = "The hours entered cannot be negative or 0.";
                    return false;
                }
            }
            lbAlerts.Visible = false;
            return true;
        }
        private void NewEmployee()
        {
            //Do not create employee unless validation clears
            if(ValidateEmp())
            {
                lbAlerts.Visible = false;
                if (Option == 1)
                {
                    newHire = new SalaryEmployee(firstName, lastName, ssn, rate);
                }
                else if (Option == 2)
                {
                    newHire = new HourlyEmployee(firstName, lastName, ssn, rate, hours);
                }
                else if (Option == 3)
                {
                    sales = hours;
                    newHire = new CommissionEmployee(firstName, lastName, ssn, rate, sales);
                }

                //Create correct employee
                employees.Add(newHire);

                //Clear textboxes after created
                ClearUI();
            }
        }

        private void DisplayEmployee(Employee emp)
        {
            //Code to display employee in the listbox
            //emp.ToString();
            //Formatting data (hrs :0.##)(Currency :C)(Percent :P0)
                switch (emp)
                {
                    case SalaryEmployee s:
                        EmployeeListbox.Items.Add($"Name: {s.FirstName}, {s.LastName}");
                        EmployeeListbox.Items.Add($"SSN: {s.SSN} Type: Salary");
                        EmployeeListbox.Items.Add($"Weekly Salary: {s.WeeklySalary:C}");
                        EmployeeListbox.Items.Add($"Weekly Pay: {s.Earnings():C}");
                        break;

                    case HourlyEmployee hr:
                        EmployeeListbox.Items.Add($"Name: {hr.FirstName}, {hr.LastName}");
                        EmployeeListbox.Items.Add($"SSN: {hr.SSN} Type: Hourly");
                        EmployeeListbox.Items.Add($"Hours: {hr.Hours:0.##}   \nRate: {hr.HourlyWage:C}");
                        EmployeeListbox.Items.Add($"Weekly Pay: {hr.Earnings():C}");
                        break;
                    case CommissionEmployee c:
                        EmployeeListbox.Items.Add($"Name: {c.FirstName}, {c.LastName}");
                        EmployeeListbox.Items.Add($"SSN: {c.SSN} Type: Commission");
                        EmployeeListbox.Items.Add($"Sales: {c.SalesAmount:C}   \nRate: {c.CommissionRate:P0}");
                        EmployeeListbox.Items.Add($"Weekly Pay: {c.Earnings():C}");
                        break;
                }
                //Adding a break for user visual exp.
                EmployeeListbox.Items.Add(new string('-', 40));

        }

        private void rbSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalary.Checked)
            {
                Option = 1;
                lbRate.Text = "Weekly Salary:";
                lbHours.Visible = false;
                tbHours.Visible = false;
                tbRate.Clear();
                tbHours.Clear();
            }
        }

        private void rbHourly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHourly.Checked)
            {
                Option = 2;
                lbRate.Text = "Hourly Wage:";
                lbHours.Text = "Hours: ";
                lbHours.Visible = true;
                tbHours.Visible = true;
                tbRate.Clear();
                tbHours.Clear();
            }
        }

        private void rbCommission_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCommission.Checked)
            {
                Option = 3;
                lbRate.Text = "Commission %:";
                lbHours.Text = "Sales Amount:";
                lbHours.Visible = true;
                tbHours.Visible = true;
                tbRate.Clear();
                tbHours.Clear();
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            NewEmployee();
            DisplayEmployee(newHire);
        }
    }
}
