using System;
using NUnit.Framework;
using Rhino.Mocks;
using _007_RhinoStubs;
using System.Collections.Generic;

namespace _007_RhinoStub
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void RhinoStubTest()
        {
            MockRepository rhinoEngine = new MockRepository();
            var stub = rhinoEngine.Stub<IDataAccessObject>();

            using (rhinoEngine.Record())
            {
                stub.GetFiles();
                LastCall.Return<List<string>>(new List<string> {"file1.txt", "file2.log", "file3.exe" });
            }

            FileManager mgr = new FileManager(stub);
            
            Assert.IsTrue(mgr.FindLogFile("file2.log"));

            rhinoEngine.VerifyAll();
        }
    }
}
