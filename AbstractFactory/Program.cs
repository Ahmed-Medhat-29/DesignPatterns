using AbstractFactory.ShoppingCartPurchaseServices;
using System;

namespace AbstractFactory;

class Program
{
	static void Main()
	{
		Console.Title = "Abstract Factory";

		var egyptShoppingCartPurchaseFactory = new EgyptShoppingCartPurchaseService();
		var shoppingCartForEgypt = new ShoppingCart(egyptShoppingCartPurchaseFactory);
		shoppingCartForEgypt.CalculateCosts();

		var saudiShoppingCartPurchaseFactory = new SaudiShoppingCartPurchaseService();
		var shoppingCartForSaudi = new ShoppingCart(saudiShoppingCartPurchaseFactory);
		shoppingCartForSaudi.CalculateCosts();
	}
}
