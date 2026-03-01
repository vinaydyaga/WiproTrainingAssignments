using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WiproSolidAssignment.Savers
{
    public class ReportSaver
    {
        public void Save(string content)
        {
            File.WriteAllText("report.txt", content);
        }
    }
}
