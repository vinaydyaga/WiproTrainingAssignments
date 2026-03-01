using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiproSolidAssignment.Reports;

namespace SolidPrinciplesDemo.Reports
{
    public class SalesReport : Report
    {
        public override string GetContent()
        {
            return "Sales Report Data";
        }
    }
}