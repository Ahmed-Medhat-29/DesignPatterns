namespace Builder;

class Garage
{
	private CarBuilder _builder;

	public void Construct(CarBuilder builder)
	{
		_builder = builder;

		_builder.BuildEngine();
		_builder.BuildFrame();
	}
}
