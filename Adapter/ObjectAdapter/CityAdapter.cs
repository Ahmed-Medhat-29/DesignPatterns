namespace Adapter.ObjectAdapter;

class CityAdapter : ICityAdapter
{
	private readonly ExternalSystem _externalSystem;

	public CityAdapter(ExternalSystem externalSystem)
	{
		_externalSystem = externalSystem;
	}

	public City GetCity()
	{
		var cityFromExternalSystem = _externalSystem.GetCity();

		return new City(
			$"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
			cityFromExternalSystem.Inhabitants);
	}
}
