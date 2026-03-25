using System;

namespace Strategy.ExportServices;

class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to Json.");
    }
}
