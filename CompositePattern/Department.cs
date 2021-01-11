using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Department : IEmployee
    {
        //Composite Class
        private readonly string _name;

        public string Name => _name;

        public Department(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}