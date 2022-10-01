using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch(RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
        static void Find()
        {
            List<string> students = new List<string>()
            {
                "Ahmet","Mehmet","Ali","Veli"
            };

            if(!students.Contains("Mehmet Can"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
        }
    }
}
