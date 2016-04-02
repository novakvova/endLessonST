using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace _004_RhinoMocks
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void FileManagerTest4()
        {
            string fileName = "TestFileName.exe";

            MockRepository rhinoEngine = new MockRepository();

            ILogService logService = rhinoEngine.DynamicMock<ILogService>();

            using (rhinoEngine.Record())
            {
                logService.LogError("FileExtension error: TestFileName.exe");
            }

            FileManager fileManager = new FileManager(logService);
            fileManager.Analize(fileName);

            rhinoEngine.Verify(logService);
        }
    }
}
