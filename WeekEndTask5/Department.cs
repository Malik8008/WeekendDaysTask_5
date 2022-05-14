using System;
using System.Collections.Generic;
using System.Text;
using WeekEndTask5.Exceptoin;

namespace WeekEndTask5
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] employees = new Employee[0];

        public Department()
        {
            employees = new Employee[0];
           
        }
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }
        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                employees[index] = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            

            if (employees.Length<EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitException("Capacity-i kechmisiniz");
            }
        }
        
        
    }
}
