using NUnit.Framework;
using TeamAgile.NUnitExtensions.EventsTesting;

namespace _015_EventTriggeredTest
{
    [TestFixture]
    class EventRelatedTests
    {
        [Test]
        public static void EventTriggeredTest1()
        {
            bool triggerFlag = false;

            TestView view = new TestView();

            view.Load += delegate { triggerFlag = true; };

            view.LoadEventTrigger(null, null);

            Assert.IsTrue(triggerFlag);
        }

        [Test]
        public static void EventTriggeredTest2()
        {
            EventsVerifier eventsVerifier = new EventsVerifier();

            TestView view = new TestView();

            eventsVerifier.Expect(view, "Load", null, null);

            view.LoadEventTrigger(null, null);

            eventsVerifier.Verify();
        }
    }
}
