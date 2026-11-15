using System;

public class TestEmployee
{
    public static void RunTest()
    {
        Employee[] employees = new Employee[3];

        double totalNetoToEmployees = 0;
        double totalNationalInsurance = 0;
        double totalIncomeTax = 0;

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Enter details for employee {i + 1}:");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine()!;

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine()!;

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine()!;

            Console.Write("Enter birth day: ");
            int day = int.Parse(Console.ReadLine()!);

            Console.Write("Enter birth month: ");
            int month = int.Parse(Console.ReadLine()!);

            Console.Write("Enter birth year: ");
            int year = int.Parse(Console.ReadLine()!);

            Date birthDate = new Date(day, month, year);

            Console.Write("Enter homeland: ");
            string homeland = Console.ReadLine()!;

            Console.Write("Enter nation: ");
            string nation = Console.ReadLine()!;

            Console.Write("Enter marital status: ");
            string maritalStatus = Console.ReadLine()!;

            Console.Write("Enter residential address: ");
            string residentialAddress = Console.ReadLine()!;

            Passport p = new Passport(id, firstName, lastName, birthDate, homeland, nation, maritalStatus, residentialAddress);

            Console.Write("Enter email: ");
            string email = Console.ReadLine()!;

            Console.Write("Enter phone: ");
            string phone = Console.ReadLine()!;

            Console.Write("Enter hourly salary: ");
            double salary = double.Parse(Console.ReadLine()!);

            Console.Write("Enter working hours: ");
            double hours = double.Parse(Console.ReadLine()!);

            employees[i] = new Employee(p, email, phone, salary, hours);
            Console.WriteLine();
        }

        Console.WriteLine("Employees Details:");

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i].ToString());
            Console.WriteLine();

            double bruto = employees[i].BrutoSalary();
            totalNetoToEmployees += employees[i].NettoSallary();
            totalIncomeTax += bruto * 0.25;
            totalNationalInsurance += bruto * 0.05;
        }

        Console.WriteLine("Employer Summary Report:");
        Console.WriteLine($"Total net payment to employees: {totalNetoToEmployees:F2}");
        Console.WriteLine($"Total National Insurance: {totalNationalInsurance:F2}");
        Console.WriteLine($"Total Income Tax: {totalIncomeTax:F2}");
    }

    public static void Main(string[] args)
    {
        RunTest();
    }
}