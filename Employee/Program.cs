using System;

namespace Employee
{
    class Program
    {
        public string employeeName;
        public int employeeSalary;


        public void EmployeeDetails(string name, int salary)
        {

            employeeName = name;
            employeeSalary = salary;

        }
        public void DesplayDetails()
        {
            Console.WriteLine("Employee Name: " + employeeName);
            
            Console.WriteLine("Salary: " + employeeSalary);
           
        }

        static void Main(string[] args)
        {
            Program employee1 = new Program();

            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Salary");
           int salary = Console.Read();

            employee1.EmployeeDetails(name, salary);
            employee1.DesplayDetails();
            
        }
    }
}
