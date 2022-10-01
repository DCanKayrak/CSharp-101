using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cM = new CustomerManager();
            cM.logger = new DatabaseLogger(); // veya fileLogger kullanılabilir.!
            cM.Add("Danyal Can KAYRAK");

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger logger { get; set; }
        public void Add(string first_name)
        {
            //ILogger logger = new DatabaseLogger();
            //ILogger logger = new FileLogger();
            logger.Log();
            Console.WriteLine("Customer eklendi! : {0}",first_name);
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Loglandı!");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Db loglandı!");
        }
    }
    interface ILogger
    {
        void Log();
    }

    // böyle olmamalı.İnterface üzerinden gelmeli.
    //class Logger
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Loglandı!");
    //    }
    //}
}
