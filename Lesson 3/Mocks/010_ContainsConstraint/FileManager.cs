using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_ContainsConstraint
{

    class FileManager
    {
        ILogService logService;

        public FileManager(ILogService logService)
        {
            this.logService = logService;
        }

        public void Analize(string fileName)
        {
                if (fileName.Length < 8)
                    logService.LogError("Filename too short: " + fileName);

                if (Path.GetExtension(fileName) != ".txt")
                    logService.LogError("FileExtension error: " + fileName);
        }
    }
}
