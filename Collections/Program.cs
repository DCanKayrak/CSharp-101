using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("book", "kitap");
            dict.Add("table", "tablo");

            //Console.WriteLine(dict["book"]);
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            //TypeSecurityList();
            //ArrayListDemo();
            Console.ReadLine();
        }

        private static void TypeSecurityList()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>()
            {
                new Customer{ID = 1, FirstName = "Danyal"},
                new Customer{ID = 2,FirstName = "Ömer"}
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        static void ArrayListDemo()
        {
            ArrayList citiesList = new ArrayList();
            citiesList.Add("İstanbul");
            citiesList.Add("Anakara");

            foreach (var city in citiesList)
            {
                Console.WriteLine(city);
            }
            
        }
    }
    class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
