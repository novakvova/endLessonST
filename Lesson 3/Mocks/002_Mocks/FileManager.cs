using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Mocks
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
                if (fileName.Length < 8)
                    logService.LogError("Filename too short: " + fileName);

                if (Path.GetExtension(fileName) != ".txt")
                    logService.LogError("FileExtension error: " + fileName);
            }
            catch (Exception ex)
            {
                mailService.SendMail("some@mail.mail", ex.Message);
            }
           
        }
    }
}
