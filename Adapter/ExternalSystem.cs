namespace Adapter;

class ExternalSystem
{
	public CityFromExternalSystem GetCity()
	{
		return new CityFromExternalSystem("El-Mahalla El-Kubra", "El-Mahalla", 1_500_000);
	}
}
