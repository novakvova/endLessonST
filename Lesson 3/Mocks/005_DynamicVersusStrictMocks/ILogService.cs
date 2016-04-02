using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_DynamicVersusStrictMocks
{
    public interface ILogService
    {
        void LogError(string error);

        void OtherMethod();
    }
}
