namespace Observer;

interface ITicketChangeListener
{
	void ReceiveTicketChangeNotification(TicketChange ticketChange);
}
