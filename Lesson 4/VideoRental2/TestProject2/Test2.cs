using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental;

namespace TestProject2
{
    [TestFixture]
    public class RentalTests
    {
        [Test]
        public static void Test2_RegularMovie()
        {
            Renatal rental = new Renatal(new RegularMovie("Film1"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 12);
        }

        [Test]
        public static void Test2_ChildrensMovie()
        {
            Renatal rental = new Renatal(new ChildrensMovie("Film1"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 6);
        }

        [Test]
        public static void Test2_NewReleaseMovie()
        {
            Renatal rental = new Renatal(new NewReleaseMovie("Film1"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 18);
        }
    }
}
