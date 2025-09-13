using System;

namespace Adapter;

class Program
{
	static void Main()
	{
		Console.Title = "Adapter";

		ICityAdapter cityAdapter = new ObjectAdapter.CityAdapter(new ExternalSystem());
		//ICityAdapter cityAdapter = new ClassAdapter.CityAdapter();
		var city = cityAdapter.GetCity();

		Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
	}
}
