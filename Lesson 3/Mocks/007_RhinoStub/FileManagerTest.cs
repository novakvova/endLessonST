using System;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace _007_RhinoStub
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void MockAndStubTest()
        {
            string fileName = "SomeFile.log";

            MockRepository rhinoEngine = new MockRepository();
            var logService = rhinoEngine.Stub<ILogService>();
            var mailService = rhinoEngine.DynamicMock<IMailService>();

            using (rhinoEngine.Record())
            {
                logService.LogError("Whatever");
                LastCall.Constraints(new Rhino.Mocks.Constraints.Anything());
                LastCall.Throw(new Exception("TestMessage"));

                mailService.SendMail("some@mail.mail", "TestMessage");
            }

            FileManager mgr = new FileManager(logService, mailService);

            mgr.Analize(fileName);

            rhinoEngine.VerifyAll();
        }
    }
}
