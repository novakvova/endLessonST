using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental2;

namespace TestProject
{
    [TestFixture]
    public class RentalTests
    {
        static Movie movie;

        [SetUp]
        public static void SetUp()
        {
             movie = Movie.RegularMovie("Film Name");
        }

        [Test]
        public static void Test1_RentalCalculateDebt()
        {
            Renatal rental = new Renatal(movie, days: 6);

            Assert.AreEqual(rental.CalculateDebt(), 12);
        }

        [Test]
        public static void Test1_RentalAddRentalDays()
        {
            Renatal rental = new Renatal(movie, days: 6);

            rental.AddRentalDays();
            Assert.AreEqual(rental.CalculateDebt(), 2 * 7);

            rental.AddRentalDays(2);
            Assert.AreEqual(rental.CalculateDebt(), 2 * 9);
        }

        [Test]
        public static void Test1_RentalSubstractRentalDays()
        {
            Renatal rental = new Renatal(movie, days: 6);

            rental.SubstractRentalDays();
            Assert.AreEqual(rental.CalculateDebt(), 2 * 5);

            rental.SubstractRentalDays(2);
            Assert.AreEqual(rental.CalculateDebt(), 2 * 3);
        }

        [Test]
        public static void Test1_ExpectedRentalDaysException1()
        {
            try
            {
                Renatal rental = new Renatal(movie, days: 6);

                rental.SubstractRentalDays(7);
            }
            catch (RentalDaysException e)
            {
                Assert.AreEqual(e.Days, -1);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public static void Test1_ExpectedRentalDaysException2()
        {
            try
            {
                Renatal rental = new Renatal(movie, days: -6);
            }
            catch (RentalDaysException e)
            {
                Assert.AreEqual(e.Days, -6);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
