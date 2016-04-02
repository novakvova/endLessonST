using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _012_IsMatchingConstraint
{
    public interface IMailService
    {
        void SendMail(MailMessage message);
    }
}
