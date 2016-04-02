using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Mocks
{
    public class ReportManager
    {

        internal bool ReportExists(string name)
        {
           Report reports =  ServiceFactory.GetReportService().FindReports(name);

           if (reports.Length != 0)
               return true;

            return false;
        }
    }
}
