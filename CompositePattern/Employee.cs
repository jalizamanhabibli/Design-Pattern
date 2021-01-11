using System;

namespace CompositePattern
{
    public class Employee: IEmployee
    {
        //Leaf Class
        private readonly string _name;
        private readonly int _salary;

        public string Name => _name;
        public int Salary => _salary;

        public Employee(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }

        public override string ToString()
        {
            return $"[{Name} - {Salary}]";
        }
    }
}