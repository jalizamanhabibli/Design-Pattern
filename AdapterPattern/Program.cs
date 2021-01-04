using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HRSystem hrSystem = new HRSystem();
            ITarget target = new EmployeeAdapter(hrSystem);

            foreach (var employee in target.GetEmployeeList())
            {
                Console.Write(employee);
            }

            Console.ReadKey();
        }
    }
}
