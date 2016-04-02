using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Impl;
using Rhino.Mocks.Interfaces;

namespace _014_EventRaiser
{
    [TestFixture]
    class EventRelatedTests
    {
        [Test]
        public static void EventRaiseTest()
        {
            MockRepository rhinoEngine = new MockRepository();

            var view = rhinoEngine.Stub<IView>();
            var model = rhinoEngine.DynamicMock<IModel>();

            using (rhinoEngine.Record())
            {
                model.DoSomeWork();
            }

            Presenter presenter = new Presenter(view, model);

            IEventRaiser raiser = EventRaiser.Create(view, "Load");
            raiser.Raise(null, null);

            rhinoEngine.Verify(model);
        }
    }
}
