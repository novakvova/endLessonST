using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental2;

namespace UsingVideoRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Alex");
            customer.Rentals.Add(new Renatal(Movie.RegularMovie("Movie1"), 6));
            customer.Rentals.Add(new Renatal(Movie.NewReleaseMovie("Movie2"), 2));
            Console.WriteLine("Клиент с именем {0} должен нам ${1}", customer.Name, customer.CalculateDebt());
            //Console.WriteLine("Клиент с именем {0} ", customer.Name);
            ReportManager.CreateSimpleReport(@"D:\\VideoRentalTest\\TestReport.txt", customer);

            Customer customerTest = new Customer("TestCustomer");
            customerTest.Rentals.Add(new Renatal(Movie.RegularMovie("TestMovie"), 6));
            ReportManager.CreateSimpleReport(@"D:\\VideoRentalTest\\customerTest.txt", customerTest);
        }
    }
}
