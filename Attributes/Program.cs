using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            Customer customer = new Customer
            {
                Id = 1,LastName = "KAYRAK",Age = 35
            };
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew!")] // hazır attribute!
        public void Add(Customer customer)
        {
            Console.WriteLine("Added! {0},{1},{2},{3}",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("Added! {0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)] // allow multiple birden fazla attribute kulanımına izin verir!
    class RequiredPropertyAttribute : Attribute
    {
        
    }
}
