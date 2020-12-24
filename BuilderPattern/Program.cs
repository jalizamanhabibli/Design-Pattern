using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new CarBuilder();
            Car car1 = builder.Brand("Opel").Model("Astra").Km(1500).Gear(true).build();
            Car car2 = builder.Brand("Toyota").Model("Sante").Km(1700).build();
            Car car3 = builder.Brand("BMW").Model("X5").build();
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);
            Console.ReadKey();
        }
    }
}
