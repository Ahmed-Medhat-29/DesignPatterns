using Builder.Builders;
using System;

namespace Builder;

class Program
{
	static void Main()
	{
		Console.Title = "Builder Pattern";

		var garage = new Garage();

		var miniBuilder = new MiniBuilder();
		var bmwBuilder = new BMWBuilder();

		garage.Construct(miniBuilder);
		Console.WriteLine(miniBuilder.Car);

		garage.Construct(bmwBuilder);
		Console.WriteLine(bmwBuilder.Car);
	}
}
