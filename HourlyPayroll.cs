using System;

namespace EmployeeInvoiceCalculator
{
    public class HourlyPayroll : Payroll
    {
        public decimal HourlyWage { get; set; }
        public int HoursWorked { get; set; }

        public HourlyPayroll(decimal hourlyWage, int hoursWorked)
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }
        public override void ShowPayroll()
        {
            Console.Write($"Der Lohn beträgt: {HourlyWage * HoursWorked}€\n");
        }
    }

}
