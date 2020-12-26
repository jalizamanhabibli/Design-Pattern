using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() =>
            {
                CreateDatabase("MsSql");
            });

            Thread thread2 = new Thread(() =>
            {
                CreateDatabase("MySql");
            });

            thread1.Start();
            thread1.Join();

            thread2.Start();
            thread2.Join();

            Console.ReadKey();
        }
        static void CreateDatabase(string connectionString)
        {
            
            Database database = Database.GetInstance(connectionString);
            Console.WriteLine(database.ConnectionString);
        }
    }
}
