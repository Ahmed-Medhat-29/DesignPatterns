using System;

namespace Strategy.ExportServices;

class XMLExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to XML.");
    }
}
