namespace FactoryMethod.DiscountServices;

class CountryDiscountService : DiscountService
{
	private readonly string _countryIdentifier;

	public CountryDiscountService(string countryIdentifier)
	{
		_countryIdentifier = countryIdentifier;
	}

	public override int DiscountPercentage
	{
		get
		{
			return _countryIdentifier switch
			{
				"EG" => 20,
				"SA" => 30,
				_ => 10,
			};
		}
	}
}
