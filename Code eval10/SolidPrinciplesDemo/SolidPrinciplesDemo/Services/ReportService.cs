using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiproSolidAssignment.Interfaces;

namespace WiproSolidAssignment.Services
{
    public class ReportService
    {
        private readonly IReportFormatter _formatter;

        public ReportService(IReportFormatter formatter)
        {
            _formatter = formatter;
        }

        public void Process(string content)
        {
            string formatted = _formatter.Format(content);
            Console.WriteLine(formatted);
        }
    }
}
