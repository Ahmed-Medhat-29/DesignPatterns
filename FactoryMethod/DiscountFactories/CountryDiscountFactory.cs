using FactoryMethod.DiscountServices;

namespace FactoryMethod.DiscountFactories;

class CountryDiscountFactory : IDiscountFactory
{
	private readonly string _countryIdentifier;

	public CountryDiscountFactory(string countryIdentifier)
	{
		_countryIdentifier = countryIdentifier;
	}

	public DiscountService CreateDiscountService()
	{
		return new CountryDiscountService(_countryIdentifier);
	}
}
