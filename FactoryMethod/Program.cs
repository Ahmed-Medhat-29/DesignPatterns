using FactoryMethod.DiscountFactories;
using System;
using System.Collections.Generic;

namespace FactoryMethod;

class Program
{
	static void Main()
	{
		Console.Title = "Factory Method";

		var discountFactories = new List<IDiscountFactory>
		{
			new CountryDiscountFactory("SA"),
			new CodeDiscountFactory(Guid.NewGuid())
		};

		foreach (var factory in discountFactories)
		{
			var discountService = factory.CreateDiscountService();

			Console.WriteLine($"Percentage {discountService.DiscountPercentage} from {discountService}");
		}
	}
}
