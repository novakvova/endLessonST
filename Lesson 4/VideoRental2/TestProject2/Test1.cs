using NUnit.Framework;
using System;
using VideoRental;

namespace TestProject
{
    [TestFixture]
    public class RentalTests
    {
        static RegularMovie movie;

        [SetUp]
        public static void SetUp()
        {
            movie = new RegularMovie(name: "TestMovie");
        }

        [Test]
        public static void Case1_RentalCalculateDebt()
        {
            Renatal rental = new Renatal(movie, 6);

            Assert.AreEqual(rental.CalculateDebt(), rental.Movie.RentalPrice * rental.Days);
        }

        [Test]
        public static void Case1_RentalAddRentalDays()
        {
            Renatal rental = new Renatal(movie, 6);

            rental.AddRentalDays();
            Assert.AreEqual(rental.CalculateDebt(), rental.Movie.RentalPrice * (6 + 1));

            rental.AddRentalDays(2);
            Assert.AreEqual(rental.CalculateDebt(), rental.Movie.RentalPrice * (6 + 3));
        }

        [Test]
        public static void Case1_RentalSubstractRentalDays()
        {
            Renatal rental = new Renatal(movie, 6);

            rental.SubstractRentalDays();
            Assert.AreEqual(rental.CalculateDebt(), rental.Movie.RentalPrice * (6 - 1));

            rental.SubstractRentalDays(2);
            Assert.AreEqual(rental.CalculateDebt(), rental.Movie.RentalPrice * (6 - 3));
        }

        [Test]
        public static void Case1_ExpectedRentalDaysException1()
        {
            try
            {
                Renatal rental = new Renatal(movie, days: 6);

                rental.SubstractRentalDays(7);

                Assert.Fail();
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

        //[Test]
        //public static void Case1_ExpectedRentalDaysException2()
        //{
        //    try
        //    {
        //        Renatal rental = new Renatal(movie, days: -6);

        //        Assert.Fail();
        //    }
        //    catch (RentalDaysException e)
        //    {
        //        Assert.AreEqual(e.Days, -6);
        //    }
        //    catch (Exception)
        //    {
        //        Assert.Fail();
        //    }
        //}
    }
}
