using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Mocks
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportManager mgr = new ReportManager();

            if (mgr.ReportExists("testReport"))
            {
                Console.WriteLine("ReportExists");
            }
        }
    }
}
