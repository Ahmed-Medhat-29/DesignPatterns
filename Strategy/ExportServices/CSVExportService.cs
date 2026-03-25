using System;

namespace Strategy.ExportServices;

class CSVExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to CSV.");
    }
}
