using System;
using System.Collections.Generic;
// added by lightbulb suggestion (from previous error)

namespace Classes
{
    public class Company
    {

        // Some read-only properties (get) -set would allow it to be changed
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string EmployeeName, DateTime Date)
        {
            Name = EmployeeName;
            CreatedOn = Date;
            Employees = new List<Employee>();
            //created as an empty list within the constructor
        }
        public void AddEmployee(Employee NewEmployee/*taco- added employee is set as NewEmployee*/)
        {
            Employees.Add(NewEmployee);
        }
    }
}