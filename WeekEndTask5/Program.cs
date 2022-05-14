using System;

namespace WeekEndTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Islam", 1000);
            Employee employee2 = new Employee("Baxsheli", 900);
            Employee employee3 = new Employee("Malik", 800);
            Employee employee4 = new Employee("Kamal", 700);
            
            Department department = new Department("Khalitov", 5);

            department.AddEmployee(employee);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
            department.AddEmployee(employee4);

            foreach (var item in department.employees)
            {
                Console.WriteLine(item.ShowInfo());
            }
            Console.WriteLine("\n");

            Console.WriteLine(department[0].ShowInfo());
        }
    }
}
