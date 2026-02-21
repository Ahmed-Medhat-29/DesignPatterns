namespace Bridge.Menus;

class MeatBasedMenu : MenuBase
{
	public MeatBasedMenu(ICoupon coupon) : base(coupon)
	{
		
	}

	public override int CalculatePrice()
	{
		return 30 - _coupon.CouponValue;
	}
}
