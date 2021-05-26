using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Company NewCompanyObj = new Company("NewCompanyCo", DateTime.Now); 
            // Assign the employees to the company

            Employee Meg= new Employee("Meg", "McGregor", "Owner", DateTime.Now);
            Employee Autumn = new Employee("Autumn", "Fotopolous", "CEO", DateTime.Now);
            Employee Taryn = new Employee("Taryn", "Lytle", "Boss", DateTime.Now);
            NewCompanyObj.AddEmployee(Meg);
            NewCompanyObj.AddEmployee(Autumn);
            NewCompanyObj.AddEmployee(Taryn);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
            
       
    }
}