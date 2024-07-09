using System;

namespace EmployeeInvoiceCalculator
{
    public class MonthlyPayroll : Payroll
    {
        public decimal MonthlySalary { get; set; }
        public MonthlyPayroll(decimal monthlySalary)
        {
            MonthlySalary = monthlySalary;
        }

        public override void ShowPayroll()
        {
            Console.Write($"Das Gehalt beträgt: {MonthlySalary}€ \n");
        }
    }
}
