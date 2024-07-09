using System;

namespace EmployeeInvoiceCalculator
{
    public class Employee
    {
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public int UserId { get; set; }
        public Payroll Payroll { get; set; }

        public Employee(string foreName, string surName, int userId)
        {
            ForeName = foreName;
            SurName = surName;
            UserId = userId;
        }
        public void ShowEmployee()
        {
            Console.Write($"\n{UserId}: {ForeName} {SurName}\n");

            if (Payroll != null)
            {
                Payroll.ShowPayroll();
            }
            else
            {
                Console.Write("Diese Mitarbeiter hat noch keine Gehaltsabrechnung\n");
            }
        }

        public bool MatchingId(int inputId)
        {
            return UserId == inputId;
        }
    }
}
