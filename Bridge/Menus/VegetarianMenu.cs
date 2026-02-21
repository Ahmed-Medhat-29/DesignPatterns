namespace Bridge.Menus;

class VegetarianMenu : MenuBase
{
	public VegetarianMenu(ICoupon coupon) : base(coupon)
	{

	}

	public override int CalculatePrice()
	{
		return 20 - _coupon.CouponValue;
	}
}
