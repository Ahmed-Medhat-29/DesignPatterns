using Strategy.ExportServices;
using System;

namespace Strategy;

internal class Program
{
    static void Main()
    {
        Console.Title = "Strategy";

        var order = new Order("Marvin Software", 5, "Visual Studio License");
        order.ExportService = new CSVExportService();
        order.Export();

        order.ExportService = new JsonExportService();
        order.Export();
    }
}
