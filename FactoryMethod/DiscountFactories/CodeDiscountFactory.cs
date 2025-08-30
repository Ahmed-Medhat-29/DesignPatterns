using FactoryMethod.DiscountServices;
using System;

namespace FactoryMethod.DiscountFactories;

class CodeDiscountFactory : IDiscountFactory
{
	private readonly Guid _code;

	public CodeDiscountFactory(Guid code)
	{
		_code = code;
	}

	public DiscountService CreateDiscountService()
	{
		return new CodeDiscountService(_code);
	}
}
