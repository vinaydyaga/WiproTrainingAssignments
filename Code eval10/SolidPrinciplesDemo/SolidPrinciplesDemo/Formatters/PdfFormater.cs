using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WiproSolidAssignment.Interfaces;

namespace WiproSolidAssignment.Formatters
{
    public class PdfFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return "PDF Format: " + content;
        }
    }
}
