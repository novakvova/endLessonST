﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Mocks
{
    class StubLogService : ILogService
    {
        public void LogError(string error)
        {
            throw new Exception(error);
        }
    }
}
