using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental2;
using UsingVideoRental;
using Rhino.Mocks;
using System.IO;
using Rhino.Mocks.Constraints;

namespace TestProject2
{
    [TestFixture]
    public class RentalTests4
    {
        [Test]
        public static void Test4_ReportManagerCreateSimpleReport()
        {
            MockRepository rhinoEngine = new MockRepository();
            var mockWriter = rhinoEngine.DynamicMock<TextWriter>();
            //Внедряем завимость с помощью фабрики Сохраняем простой интерфейс
            TextWriterFactory.SetTextWriter(mockWriter);

            using (rhinoEngine.Record())
            {
                mockWriter.Write("Nothing"); //что нужно писать 

                LastCall.Constraints(new Rhino.Mocks.Constraints.Contains("TestCustomer") &
                                     new Rhino.Mocks.Constraints.Contains("TestMovie") &
                                     new Rhino.Mocks.Constraints.Contains("6 days") &
                                     new Rhino.Mocks.Constraints.Contains(12.ToString("C")) &
                                     new Rhino.Mocks.Constraints.Contains("(Regular)"));

                mockWriter.Flush(); //очистить буфер и записать у файл
            }

            Customer customer = new Customer("TestCustomer");
            customer.Rentals.Add(new Renatal(Movie.RegularMovie("TestMovie"), 6));

           ReportManager.CreateSimpleReport("SomePath", customer); //Зависит от внешнего объекта файловой системе усложняет процес проверки

            rhinoEngine.VerifyAll();
        }
    }
}
