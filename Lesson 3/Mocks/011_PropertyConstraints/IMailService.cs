using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_PropertyConstraints
{
    public interface IMailService
    {
        void SendMail(MailMessage message);
    }
}
