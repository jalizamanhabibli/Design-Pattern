using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var CEO = new CompositeClass<IEmployee>(new Department("CEO"));

            var ceoEmployee = CEO.AddCompositeClass(new Employee("Alizama", 5000));

            var headSales = CEO.AddCompositeClass(new Department("Head Sales"));

            var salesEmployee1 = headSales.AddCompositeClass(new Employee("Samir", 1000));
            var salesEmployee2 = headSales.AddCompositeClass(new Employee("Orxan", 1150));

            var headMarketing = CEO.AddCompositeClass(new Department("Head Marketing"));

            var marketingEmployee1 = headMarketing.AddCompositeClass(new Employee("Subhan",2400));
            var marketingEmployee2 = headMarketing.AddCompositeClass(new Employee("Huseyn",1750));

            CEO.ToList(1);

            Console.ReadKey();


        }
    }
}
