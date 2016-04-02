using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_PropertyConstraints
{
    public class MailMessage
    {
        string destination;
        string theme;
        string messageText;

        public string Destination { get { return destination; } }
        public string Theme { get { return theme; } }
        public string MessageText { get { return messageText; } }

        public MailMessage(string destination, string theme, string messageText)
        {
            this.destination = destination;
            this.theme = theme;
            this.messageText = messageText;
        }

        public MailMessage()
        {

        }
    }
}
