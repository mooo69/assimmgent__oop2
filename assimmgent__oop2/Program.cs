using System;

enum SecurityLevel
{
    Guest,
    Developer,
    Secretary,
    DBA,
    SecurityOfficer
}

class HiringDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HiringDate(int day, int month, int year)
    {
        Day = (day > 0 && day <= 31) ? day : 1;
        Month = (month > 0 && month <= 12) ? month : 1;
        Year = (year > 1900) ? year : 2000;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }

    private char gender;
    public char Gender
    {
        get { return gender; }
        set { gender = (value == 'M' || value == 'F') ? value : 'M'; }
    }

    public SecurityLevel SecurityLevel { get; set; }

    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set { salary = (value >= 0) ? value : 0; }
    }

    public HiringDate HireDate { get; set; }

    public Employee(int id, string name, char gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
    {
        ID = id;
        Name = name;
        Gender = gender;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security: {SecurityLevel}, Salary: {string.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
    }
}

class Program
{
    static void Main()
    {
        Employee[] EmpArr = new Employee[3];
        EmpArr[0] = new Employee(1, "Ali", 'M', SecurityLevel.DBA, 15000, new HiringDate(5, 3, 2020));
        EmpArr[1] = new Employee(2, "Sara", 'F', SecurityLevel.Guest, 5000, new HiringDate(10, 6, 2021));
        EmpArr[2] = new Employee(3, "Omar", 'M', SecurityLevel.SecurityOfficer, 20000, new HiringDate(1, 1, 2019));

        foreach (var emp in EmpArr)
        {
            Console.WriteLine(emp);
        }
    }
}
