using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiproSolidAssignment.Reports;
namespace SolidPrinciplesDemo.Reports
{
    public class InventoryReport : Report
    {
        public override string GetContent()
        {
            return "Inventory Report Data";
        }
    }
}