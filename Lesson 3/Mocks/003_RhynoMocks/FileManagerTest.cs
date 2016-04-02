using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace _003_RhynoMocks
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void FileManagerTest3()
        {
            MockRepository rhinoEngine = new MockRepository();

            // Создание динамического Mock-объекта
            ILogService logService = rhinoEngine.DynamicMock<ILogService>();
            
            // Создание сценария
            using (rhinoEngine.Record())
            {
                logService.LogError("TestErrorMessage");
            }

            logService.LogError("TestErrorMessage");

            // Проверка сценария
            rhinoEngine.Verify(logService);
        }
    }
}
