using System;
using NUnit.Framework;

namespace _002_Mocks
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void FileManagerTest2()
        {
            var logService = new StubLogService();
            var mailService = new MockMailService();

            FileManager mgr = new FileManager(logService, mailService);

            string fileName = "SomeFile.log";

            mgr.Analize(fileName);

            Assert.AreEqual("FileExtension error: " + fileName, mailService.message);
        }
    }
}
