using System;
using System.Collections.Generic;

namespace EmployeeInvoiceCalculator
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();


        //employees.Add(secondEmployee);
        //    employees.Add(thirdEmployee);
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var firstEmployee = new Employee("Heinz", "Muster", 1);
            var secondEmployee = new Employee("Heinz", "Montag", 2);
            var thirdEmployee = new Employee("Fred", "Feuerstein", 3);

            employees.Add(firstEmployee);
            employees.Add(secondEmployee);
            employees.Add(thirdEmployee);



            while (true)
            {
                Console.WriteLine();
                Console.Write("Wählen Sie eine Option: \n\n");
                Console.Write("1: Zuweisung der Abrechnung\n");
                Console.Write("2. Alle Mitarbeiter anzeigen\n");
                Console.Write("3. Einen Mitarbeiter anzeigen\n");
                Console.Write("4. Exit\n\n");
                Console.WriteLine();
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (input)
                {
                    case 1:
                        Console.Write("Zuweisung der Abrechnung\n");
                        Console.Write("\nGeben Sie die ID des Mitarbeiters ein: ");
                        int userId = Convert.ToInt32(Console.ReadLine());
                        bool matchOne = false;

                        foreach (var employee in employees)
                        {
                            if (employee.MatchingId(userId))
                            {

                                employee.ShowEmployee();
                                Console.WriteLine();

                                matchOne = true;
                                Console.Write("Wählen Sie eine Abrechnung\n");
                                Console.Write("\n1: Monatliche Gehaltsabrechnung\n");
                                Console.Write("2: Monatliche Lohnabrechnung\n");
                                int payrollInput = Convert.ToInt32(Console.ReadLine());

                                if (payrollInput == 1)
                                {
                                    Console.Write("\nMonatliches Gehalt: ");
                                    decimal monthlySalary = decimal.Parse(Console.ReadLine());
                                    employee.Payroll = new MonthlyPayroll(monthlySalary);
                                    employee.Payroll.ShowPayroll();
                                    bool payrollMonth = true;

                                }
                                else if (payrollInput == 2)
                                {
                                    Console.Write("Stundenlohn: ");
                                    decimal hourlyWage = Convert.ToDecimal(Console.ReadLine());
                                    Console.Write("Arbeitszeit in Stunden: ");
                                    int hoursWorked = Convert.ToInt32((Console.ReadLine()));
                                    employee.Payroll = new HourlyPayroll(hourlyWage, hoursWorked);
                                    employee.Payroll.ShowPayroll();
                                }
                                else
                                {
                                    Console.Write("Ungültige Auswahl");
                                }
                            }

                        }
                        if (!matchOne)
                        {
                            Console.Write("Mitarbeiter existiert nicht\n");
                            Console.WriteLine();
                            break;
                        }

                        break;

                    case 2:

                        foreach (var employeeShow in employees)
                        {
                            employeeShow.ShowEmployee();

                        }
                        break;

                    case 3:
                        Console.Write("ID des Mitarbeiters: ");
                        int userInputId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        bool match = false;

                        foreach (var employeeShow in employees)
                        {
                            if (employeeShow.MatchingId(userInputId))
                            {
                                employeeShow.ShowEmployee();
                                Console.WriteLine();

                                match = true;
                            }

                        }
                        if (!match)
                        {
                            Console.Write("Mitarbeiter existiert nicht\n");
                            Console.WriteLine();
                            break;
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.Write("Ungültige Auswahl");
                        break;









                }
            }
        }
    }
}
