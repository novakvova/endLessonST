using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DomainModal.Entity;
using DomainModal;

namespace TestMovie
{
    [TestFixture]
    public class ClassTest
    {
        [Test]
        public static void Test3_CustomerCalculateDebt()
        {
            double rentalPrice = 2;
            int days = 6;

            Movie movie = new Movie(rentalPrice: rentalPrice);

            Renatal rental = new Renatal(movie, days: days);

            Assert.AreEqual(rental.CalculateDebt(), days * rentalPrice);
        }
    }
}
