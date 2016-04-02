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
    public class RentalTests
    {
        [Test]
        public static void Test2_MoviesTypes()
        {
            Renatal rental = new Renatal(Movie.RegularMovie("Movie Name"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 12);
        }

        [Test]
        public static void Test2_RegularMovie()
        {
            Renatal rental = new Renatal(Movie.RegularMovie("Movie Name"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 12);
        }

        [Test]
        public static void Test2_ChildrensMovie()
        {
            Renatal rental = new Renatal(Movie.ChildrensMovie("Movie Name"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 6);
        }

        [Test]
        public static void Test2_NewReleaseMovie()
        {
            Renatal rental = new Renatal(Movie.NewReleaseMovie("Movie Name"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 18);
        }
    }
}
