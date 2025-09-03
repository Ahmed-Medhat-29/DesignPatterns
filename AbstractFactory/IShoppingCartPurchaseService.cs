namespace AbstractFactory;

interface IShoppingCartPurchaseService
{
	IDiscountService CreateDiscountService();
	IShippingCostsService CreateShippingCostsService();
}
