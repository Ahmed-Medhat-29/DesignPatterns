using System;

namespace Observer.Listeners;

class TicketResellerService : ITicketChangeListener
{
	public void ReceiveTicketChangeNotification(TicketChange ticketChange)
	{
		Console.WriteLine($"{nameof(TicketResellerService)} notified " +
			$"of ticket change: artist {ticketChange.ArtistId}, amount " +
			$"{ticketChange.Amount}");
	}
}