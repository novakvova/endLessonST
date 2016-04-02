using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Mocks
{
    public interface IMailService
    {
        void SendMail(string destination, string message);
    }
}
