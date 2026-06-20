using System;

namespace Visitor;

class Program
{
    static void Main()
    {
        Console.Title = "Visitor";

        var container = new Container();

        container.Customers.Add(new Customer("Sophie", 500));
        container.Customers.Add(new Customer("Karen", 1000));
        container.Customers.Add(new Customer("Sven", 800));
        container.Employees.Add(new Employee("Kevin", 18));
        container.Employees.Add(new Employee("Tom", 5));

        DiscountVisitor discountVisitor = new();

        container.Accept(discountVisitor);

        Console.WriteLine($"Total discount: {discountVisitor.TotalDiscountGiven}");
    }
}
