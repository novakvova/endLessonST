using System;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace _011_PropertyConstraints
{
    [TestFixture]
    class FileManagerTest
    {

        [Test]
        public static void FileManagerComparingMailMessages()
        {
            MockRepository rhinoEngine = new MockRepository();

            var mailService = rhinoEngine.DynamicMock<IMailService>();

            using (rhinoEngine.Record())
            {
                mailService.SendMail(new MailMessage("testDestination", "testTheme", "TestMessageText"));
            }

            mailService.SendMail(new MailMessage("testDestination", "testTheme", "TestMessageText"));

            rhinoEngine.Verify(mailService);
        }

        [Test]
        public static void FileManagerPropertyConstraintTest()
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

                mailService.SendMail(new MailMessage());
                LastCall.Constraints(Property.Value("Destination", "TechSupport@mail.com") &&
                                     Property.Value("Theme", excepetionToThrow.GetType().Name) && 
                                     Property.Value("MessageText", excepetionToThrow.Message));
            }

            mgr.Analize("file.exe");

            rhinoEngine.VerifyAll();
        }

        [Test]
        public static void PropertyConstraintTestUsingAnd()
        {
            var excepetionToThrow = new Exception("TestMessage");

            MockRepository rhinoEngine = new MockRepository();

            var mailService = rhinoEngine.DynamicMock<IMailService>();
            var logService = rhinoEngine.Stub<ILogService>();
            FileManager mgr = new FileManager(logService, mailService);

            And addStatement = new And(Property.Value("Destination", "TechSupport@mail.com"),
                                     Property.Value("Theme", excepetionToThrow.GetType().Name));

            And combinedAnd = new And(addStatement, Property.Value("MessageText", excepetionToThrow.Message));

            using (rhinoEngine.Record())
            {
                logService.LogError("Anything");
                LastCall.Constraints(new Anything());
                LastCall.Throw(excepetionToThrow);

                mailService.SendMail(null);
                LastCall.Constraints(combinedAnd);
            }

            mgr.Analize("file.exe");

            rhinoEngine.VerifyAll();
        }
    }
}
