using NUnit.Framework;
using System;
using VideoRental;

namespace TestProject
{
    [TestFixture]
    public class RentalTests
    {
        [Test]
        public static void Case1_RentalCalculateDebt() //5 - рифакторинг кода избавиться от дублтрования
        {
            double rentalPrice = 2;
            int days = 6;

            Movie movie = new Movie(rentalPrice: rentalPrice);

            Renatal rental = new Renatal(movie, days: days);

            Assert.AreEqual(rental.CalculateDebt(), days * rentalPrice);
        }

        [Test]
        public static void Case1_RentalAddRentalDays() //Прибавить дни проката
        {
            Renatal rental = new Renatal(new Movie(rentalPrice: 2), days: 6);

            rental.AddRentalDays(); //прибавить день проката
            Assert.AreEqual(rental.CalculateDebt(), 2 * 7);

            rental.AddRentalDays(2); //увеличить дни проката
            Assert.AreEqual(rental.CalculateDebt(), 2 * 9);
        }

        [Test]
        public static void Case1_RentalSubstractRentalDays() //отнимаем дни проката
        {
            Renatal rental = new Renatal(new Movie(rentalPrice: 2), days: 6);

            rental.SubstractRentalDays();
            Assert.AreEqual(rental.CalculateDebt(), 2 * 5);

            rental.SubstractRentalDays(2);
            Assert.AreEqual(rental.CalculateDebt(), 2 * 3);
        }

        [Test]
        public static void Case1_ExpectedRentalDaysException1() //Ошибки при ниправильной роботе програмы
        {
            try
            {
                Renatal rental = new Renatal(new Movie(rentalPrice: 2), days: 6);

                rental.SubstractRentalDays(7); //орицательное количество дней,будем в долгу

                Assert.Fail();
            }
            catch (RentalDaysException e) //исключение при орицательном колисетве дней
            {
                Assert.AreEqual(e.Days, -1);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public static void Case1_ExpectedRentalDaysException2()
        {
            try
            {
                Renatal rental = new Renatal(new Movie(rentalPrice: 2), days: -6); //орицательной количество дней

                Assert.Fail();
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
