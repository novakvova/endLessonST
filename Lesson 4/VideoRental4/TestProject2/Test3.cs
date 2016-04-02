using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental2;

namespace TestProject2
{
    [TestFixture]
    public class RentalTests2
    {
        [Test]
        public static void Test3_CustomerCalculateDebt()
        {
            Customer customer = new Customer("Alex");
            customer.Rentals.Add(new Renatal(Movie.RegularMovie("Movie 1"), 6));
            customer.Rentals.Add(new Renatal(Movie.NewReleaseMovie("Movie 2"), 2));

            Assert.AreEqual(customer.CalculateDebt(), 12 + 6);
        }
    }
}
