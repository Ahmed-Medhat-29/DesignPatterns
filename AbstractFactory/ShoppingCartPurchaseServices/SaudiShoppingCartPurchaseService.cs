using AbstractFactory.DiscountServices;
using AbstractFactory.ShippingCostsServices;

namespace AbstractFactory.ShoppingCartPurchaseServices;

class SaudiShoppingCartPurchaseService : IShoppingCartPurchaseService
{
	public IDiscountService CreateDiscountService()
	{
		return new SaudiDiscountService();
	}

	public IShippingCostsService CreateShippingCostsService()
	{
		return new SaudiShippingCostsService();
	}
}