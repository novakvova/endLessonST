using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_DynamicVersusStrictMocks
{

    class FileManager
    {
        ILogService service;

        public FileManager(ILogService service)
        {
            this.service = service;
        }

        public void Analize(string fileName)
        {
            service.OtherMethod();

            if (fileName.Length < 8)
                service.LogError("Filename too short:" + fileName);

            if (Path.GetExtension(fileName) != ".txt")
                service.LogError("FileExtension error: " + fileName);
        }
    }
}
