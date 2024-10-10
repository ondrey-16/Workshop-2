using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal abstract class Person
    {
        public string name;
        public int age;

        protected Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
    internal enum Position
    {
        ScrumMaster,
        SoftwareEngineer,
        ChiefExecutiveOfficer,
    }

    internal class Employee : Person
    {
        private static int sID;

        public int id;

        public Position position;

        public Employee(string name, int age, Position position)
            : base(name, age)
        {
            this.id = ++sID;
            this.position = position;
        }

        public void PromoteEmployee(Position newPosition)
        {
            position = newPosition;
        }
    }

    internal class Company
    {
        private string name;
        private List<Employee> Employees = new List<Employee>();

        public Company(string name)
        {
            this.name = name;
        }

        public void AddEmployee(Employee employee) => this.Employees.Add(employee);

        public List<Employee> GetEmployees() => Employees;
    }
}
