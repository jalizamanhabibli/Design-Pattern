using System;
using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    public class Database
    {
        private static Database _instance;
        private static readonly  object Lock = new object();
        private readonly string _connectionString;

        private Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static Database GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Database(connectionString);
                    }
                }
                
            }

            return _instance;
        }

        public string ConnectionString => _connectionString;
    }
}