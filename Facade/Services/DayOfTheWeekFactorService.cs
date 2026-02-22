using System;

namespace Facade.Services;

public class DayOfTheWeekFactorService
{
	public double CalculateDayOfTheWeekFactor()
	{
		// fake calculation for demo purposes
		switch (DateTime.UtcNow.DayOfWeek)
		{
			case DayOfWeek.Friday:
			case DayOfWeek.Saturday:
				return 0.8;
			default:
				return 1.2;
		}
	}
}