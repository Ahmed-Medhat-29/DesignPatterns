using AbstractFactory.DiscountServices;
using AbstractFactory.ShippingCostsServices;

namespace AbstractFactory.ShoppingCartPurchaseServices;

class EgyptShoppingCartPurchaseService : IShoppingCartPurchaseService
{
	public IDiscountService CreateDiscountService()
	{
		return new EgyptDiscountService();
	}

	public IShippingCostsService CreateShippingCostsService()
	{
		return new EgyptShippingCostsService();
	}
}
