using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_IsMatchingConstraint
{

    class FileManager
    {
        ILogService logService;
        IMailService mailService;

        public FileManager(ILogService logService, IMailService mailService)
        {
            this.logService = logService;
            this.mailService = mailService;
        }

        public void Analize(string fileName)
        {
            try
            {
                if (Path.GetExtension(fileName) != ".txt")
                    logService.LogError("FileExtension error: " + fileName);
            }
            catch (Exception ex)
            {
                mailService.SendMail(new MailMessage("TechSupport@mail.com", ex.GetType().Name, ex.Message));
            }
           
        }
    }
}
