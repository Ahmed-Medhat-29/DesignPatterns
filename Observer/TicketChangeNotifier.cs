using System.Collections.Generic;

namespace Observer;

abstract class TicketChangeNotifier
{
	private readonly List<ITicketChangeListener> _observers = [];

	public void AddObserver(ITicketChangeListener observer)
	{
		_observers.Add(observer);
	}

	public void RemoveObserver(ITicketChangeListener observer)
	{
		_observers.Remove(observer);
	}

	public void Notify(TicketChange ticketChange)
	{
		foreach (var observer in _observers)
		{
			observer.ReceiveTicketChangeNotification(ticketChange);
		}
	}
}
