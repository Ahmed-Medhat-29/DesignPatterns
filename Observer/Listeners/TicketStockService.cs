using System;

namespace Observer.Listeners;

class TicketStockService : ITicketChangeListener
{
	public void ReceiveTicketChangeNotification(TicketChange ticketChange)
	{
		Console.WriteLine($"{nameof(TicketStockService)} notified " +
			$"of ticket change: artist {ticketChange.ArtistId}, amount " +
			$"{ticketChange.Amount}");
	}
}
