using System;
// Define the Employee interface
interface IEmployee
{
    string GetEmployeeName();
    int GetEmployeeID();
    decimal GetSalary();
}
// Define the EyeDepartment interface
interface IEyeDepartment
{
    string GetDepartmentName();
    string GetHOP();
}
// Implement the interfaces in the Employee class
class Employee : IEmployee, IEyeDepartment
{
    private string employeeName;
    private int employeeID;
    private decimal salary;
    private string departmentName;
    private string HOP;
    public Employee(string name, int id, decimal salary, string department, string hop)
    {
        this.employeeName = name;
        this.employeeID = id;
        this.salary = salary;
        this.departmentName = department;
        this.HOP = hop;
    }
    public string GetEmployeeName()
    {
        return employeeName;
    }
    public int GetEmployeeID()
    {
        return employeeID;
    }
    public decimal GetSalary()
    {
        return salary;
    }
    public string GetDepartmentName()
    {
        return departmentName;
    }
    public string GetHOP()
    {
        return HOP;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(" Erence Ncongwane", 12345, 150000, "IT", "Michelle Jordaan");
        Console.WriteLine("Employee Name: " + emp.GetEmployeeName()); 
        Console.WriteLine("Head of Department: " + emp.GetHOP());
        Console.WriteLine("Department: " + emp.GetDepartmentName());
        Console.WriteLine("Employee ID: " + emp.GetEmployeeID());
        Console.WriteLine("Salary: " + emp.GetSalary());
        
    }
}