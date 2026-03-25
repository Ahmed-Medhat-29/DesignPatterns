namespace Strategy;

class Order
{
    public string Customer { get; set; }
    public int Amount { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public IExportService ExportService { get; set; }

    public Order(string customer, int amount, string name)
    {
        Customer = customer;
        Amount = amount;
        Name = name;
    }

    public void Export()
    {
        ExportService?.Export(this);
    }
}
