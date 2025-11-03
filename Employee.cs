using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_EmployeePayroll
{
    #region BaseEmployee
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }

        public Employee(string fName, string lName, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
        }

        public override string ToString()
        {
            //return FirstName + " " + LastName + "\n SSN: " + SSN;
            return $"{FirstName} {LastName} \nSSN: {SSN}";
        }
        public abstract decimal Earnings();
    }
    #endregion
    #region SalaryEmployee
    public class SalaryEmployee : Employee
    {
        public decimal WeeklySalary { get; set; }
        public SalaryEmployee(string fName, string lName, string ssn, decimal weeklySalary) : base(fName, lName, ssn)
        {
            WeeklySalary = weeklySalary;
        }

        public override string ToString()
        {
            //return FirstName + " " + LastName + "\n SSN: " + SSN + "\nSalaried Employee: " + WeeklySalary;
            return $"{FirstName} {LastName} \nSSN: {SSN} \nSalaried Employee:\nWeekly Salary: {WeeklySalary}";
        }

        public override decimal Earnings()
        {
            //Override the parent classes Earnings() method that returns the weekly salary.
            return (decimal) WeeklySalary;
        }
    }
    #endregion
    #region HourlyEmployee
    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public decimal Hours { get; set; }


        public HourlyEmployee(string fName, string lName, string ssn, decimal hourlyWage, decimal hours) : base(fName, lName, ssn)
        {
            HourlyWage = hourlyWage;
            Hours = hours;
        }

        public override string ToString()
        {
            //return FirstName + " " + LastName + "\n SSN: " + SSN + "\nHourly Employee: \nHours Worked: " + Hours + "Hourly Rate: " + HourlyWage;
            return $"{FirstName} {LastName} \nSSN: {SSN} \nHourly Employee:\nHours Worked: {Hours}\nHourly Rate: {HourlyWage}";
        }

        public override decimal Earnings()
        {
            decimal grossPay;
            decimal regPay;
            decimal otPay;
            decimal regTime;
            decimal overtime;

            //Calculate REG vs OT Hours
            if(Hours<=40)
            {
                overtime = 0;
                regTime = Hours;
            }
            else
            {
                overtime = Hours - 40;
                regTime = 40;
            }

            //Calculate Paycheck

            regPay = regTime * HourlyWage;
            otPay = overtime * (HourlyWage * 1.5M);
            grossPay = regPay + otPay;

            return grossPay;
        }
    }
    #endregion
    #region CommissionEmployee
    public class CommissionEmployee : Employee
    {
        public decimal SalesAmount { get; }
        public decimal CommissionRate { get; }

        public CommissionEmployee(string fName, string lName, string ssn, decimal commissionRate, decimal salesAmount) : base(fName, lName, ssn)
        {
            SalesAmount = salesAmount;
            CommissionRate = commissionRate;
        }

        public override string ToString()
        {
            //return FirstName + " " + LastName + "\n SSN: " + SSN + "\nCommission Employee: \nWeekly Sales: " + SalesAmount + "\nCommission Rate: " + CommissionRate;
            return $"{FirstName} {LastName} \nSSN: {SSN} \nCommission Employee:\nWeekly Sales: {SalesAmount}\nCommission Rate: {CommissionRate}";
        }
        public override decimal Earnings()
        {
            decimal grossPay;
            //Account for percent conversion.
            grossPay = SalesAmount * (CommissionRate/100);
            return grossPay;
        }
    }
    #endregion
}
