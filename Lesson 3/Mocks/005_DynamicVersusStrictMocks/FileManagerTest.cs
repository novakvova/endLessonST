using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace _005_DynamicVersusStrictMocks
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void FileManagerStrictMockTest()
        {
            string fileName = "TestFileName.exe";

            MockRepository rhinoEngine = new MockRepository();

            ILogService logService = rhinoEngine.StrictMock<ILogService>();

            using (rhinoEngine.Record())
            {
                logService.LogError("FileExtension error: " + fileName);
            }

            FileManager fileManager = new FileManager(logService);
            fileManager.Analize(fileName);

            rhinoEngine.Verify(logService);
        }

        [Test]
        public static void FileManagerDynamicMockTest()
        {
            string fileName = "TestFileName.exe";

            MockRepository rhinoEngine = new MockRepository();

            ILogService logService = rhinoEngine.DynamicMock<ILogService>();

            using (rhinoEngine.Record())
            {
                logService.LogError("FileExtension error: " + fileName);
            }

            FileManager fileManager = new FileManager(logService);
            fileManager.Analize(fileName);

            rhinoEngine.Verify(logService);
        }
    }
}
