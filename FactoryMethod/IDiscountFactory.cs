namespace FactoryMethod;

interface IDiscountFactory
{
	DiscountService CreateDiscountService();
}
