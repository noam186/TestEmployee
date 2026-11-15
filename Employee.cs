using System;

public class Employee
{
    private Passport passport;
    private string email;
    private string phone;
    private double salary;
    private double hours;

    public Employee(Passport passport, string email, string phone, double salary, double hours)
    {
        this.passport = passport;
        this.email = email;
        this.phone = phone;
        this.salary = salary;
        this.hours = hours;
    }

    public Employee(Passport passport)
    {
        this.passport = passport;
        this.email = "";
        this.phone = "";
        this.salary = 0;
        this.hours = 0;
    }

    public Passport GetPassport() 
    { 
        return this.passport; 
    }
    public string GetEmail() 
    { 
        return this.email; 
    }
    public string GetPhone() 
    {
        return this.phone; 
    }
    public double GetSalary() 
    { 
        return this.salary; 
    }
    public double GetHours() 
    { 
        return this.hours; 
    }

    public void SetPassport(Passport passport) 
    { 
        this.passport = passport; 
    }
    public void SetEmail(string email) 
    { 
        this.email = email; 
    }
    public void SetPhone(string phone) 
    { 
        this.phone = phone; 
    }
    public void SetSalary(double salary) 
    { 
        this.salary = salary; 
    }
    public void SetHours(double hours) 
    { 
        this.hours = hours; 
    }

    public double BrutoSalary()
    {
        return this.salary * this.hours;
    }

    public double NettoSallary()
    {
        double bruto = BrutoSalary();
        double incomeTax = bruto * 0.25;
        double healthTax = bruto * 0.031;
        double nationalInsurance = bruto * 0.05;

        return bruto - (incomeTax + healthTax + nationalInsurance);
    }

    public override string ToString()
    {
        return "Employee Detals:\n" +
               "Employee Name : " + this.passport.GetFirstName() + " " + this.passport.GetLastName() + "\n" +
               "Employee Neto salary: " + NettoSallary();
    }
}
