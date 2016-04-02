using System;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace _009_Constraints
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public static void ContainsConstraint()
        {
            MockRepository rhinoEngine = new MockRepository();

            var testClass = rhinoEngine.DynamicMock<IUnderTest>();

            using (rhinoEngine.Record())
            {
                testClass.MethodToTest("WhatEver");
                LastCall.Constraints(new Rhino.Mocks.Constraints.Contains("test"));
            }

            testClass.MethodToTest("Expected test");

            rhinoEngine.VerifyAll();
        }
    }
}
