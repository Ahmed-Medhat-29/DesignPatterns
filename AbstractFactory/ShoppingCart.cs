using System;

namespace AbstractFactory;

class ShoppingCart
{
	private readonly IDiscountService _discountService;
	private readonly IShippingCostsService _shippingCostsService;
	private int _orderCosts;

	public ShoppingCart(IShoppingCartPurchaseService factory)
	{
		_discountService = factory.CreateDiscountService();
		_shippingCostsService = factory.CreateShippingCostsService();

		// Assume the total cost of all items we ordered are 200
		_orderCosts = 200;
	}

	public void CalculateCosts()
	{
		Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts * _discountService.DiscountPercentage / 100) + _shippingCostsService.ShippingCosts}");
	}
}
