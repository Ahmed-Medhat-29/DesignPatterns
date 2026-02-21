namespace Bridge;

abstract class MenuBase
{
	public readonly ICoupon _coupon;
	public abstract int CalculatePrice();

	public MenuBase(ICoupon coupon)
	{
		_coupon = coupon;
	}
}
