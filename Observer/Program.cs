using Observer.Listeners;
using System;

namespace Observer;

class Program
{
	static void Main()
	{
		Console.Title = "Observer";

		var ticketStockService = new TicketStockService();
		var ticketResellerService = new TicketResellerService();
		var orderService = new OrderService();

		orderService.AddObserver(ticketStockService);
		orderService.AddObserver(ticketResellerService);

		orderService.CompleteTicketSale(1, 2);

		Console.WriteLine();

		orderService.RemoveObserver(ticketResellerService);

		orderService.CompleteTicketSale(2, 4);
	}
}
