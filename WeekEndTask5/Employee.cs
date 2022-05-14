using System;
using System.Collections.Generic;
using System.Text;

namespace WeekEndTask5
{
    class Employee : IPerson
    {
        public static int _id=0;
        public int Id { get; }
        public int Salary { get; set; }

        public string Name { get; set; }
        public int Age { get ; set; }
        public Employee(string name, int age)
        {
            Id = ++_id;
            Name = name;
            Age = age;
        }
        public string ShowInfo()
        {
            return $"Id : {Id}, Name : {Name}, Age : {Age}";
        }
    }
}
