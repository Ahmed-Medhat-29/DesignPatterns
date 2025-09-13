namespace Adapter.ClassAdapter;

class CityAdapter : ExternalSystem, ICityAdapter
{
	public new City GetCity()
	{
		var cityFromExternalSystem = base.GetCity();

		return new City(
			$"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
			cityFromExternalSystem.Inhabitants);
	}
}
