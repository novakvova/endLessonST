using System;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace _012_IsMatchingConstraint
{
    [TestFixture]
    class FileManagerTest
    {

        [Test]
        public static void FileManagerIsMatchingConstraintTest()
        {
            var excepetionToThrow = new Exception("TestMessage");

            MockRepository rhinoEngine = new MockRepository();

            var mailService = rhinoEngine.DynamicMock<IMailService>();
            var logService = rhinoEngine.Stub<ILogService>();
            FileManager mgr = new FileManager(logService, mailService);

            using (rhinoEngine.Record())
            {
                logService.LogError("Anything");
                LastCall.Constraints(new Anything());
                LastCall.Throw(excepetionToThrow);

                mailService.SendMail(null);
                LastCall.Constraints(Rhino.Mocks.Constraints.Is.Matching<MailMessage>(
                    message =>
                    {
                        if (message.Destination == "TechSupport@mail.com" && message.Theme == excepetionToThrow.GetType().Name && message.MessageText == excepetionToThrow.Message)
                            return true;

                        return false;
                    }));
            }

            mgr.Analize("file.exe");

            rhinoEngine.VerifyAll();
        }
    }
}
