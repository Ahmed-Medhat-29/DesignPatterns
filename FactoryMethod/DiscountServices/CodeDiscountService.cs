using System;

namespace FactoryMethod.DiscountServices;

class CodeDiscountService : DiscountService
{
	private readonly Guid _code;

	public CodeDiscountService(Guid code)
	{
		_code = code;
	}

	public override int DiscountPercentage
	{
		// Valid once - include a check the code was not used before
		get => 15;
	}
}
