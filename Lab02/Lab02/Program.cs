using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee("Mike", 27, Position.ScrumMaster);
            Employee employee_2 = new Employee("Johnny", 34, Position.ScrumMaster);
            Employee employee_3 = new Employee("Adam", 47, Position.SoftwareEngineer);

            Person employee_4 = new Employee("Stephan", 34, Position.SoftwareEngineer);


            Company company = new Company("MyCompany");

            company.AddEmployee(employee_1);
            company.AddEmployee(employee_2);
            company.AddEmployee(employee_3);

            foreach(Employee employee in company.GetEmployees())
            {
                Console.WriteLine(employee);
            }

            employee_2.PromoteEmployee(Position.SoftwareEngineer);
        }
    }
}
