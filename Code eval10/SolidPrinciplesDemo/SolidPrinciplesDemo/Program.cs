using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiproSolidAssignment;
using WiproSolidAssignment.Formatters;
using WiproSolidAssignment.Generators;
using WiproSolidAssignment.Savers;
using WiproSolidAssignment.Services;

class Program
{
    static void Main()
    {
        // Generate Report
        var generator = new ReportGenerator();
        string content = generator.Generate();

        // Format Report (Dependency Injection)
        var formatter = new PdfFormatter();
        var service = new ReportService(formatter);
        service.Process(content);

        // Save Report
        var saver = new ReportSaver();
        saver.Save(content);

        var logger = Logger.Instance;
        logger.Log("Application Started");

        Console.WriteLine("Report processing completed.");
    }
}