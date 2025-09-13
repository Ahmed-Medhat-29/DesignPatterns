using System.Text.Json;

namespace Prototype;

class Manager : IPerson, ICloneable<Manager>
{
	public string Name { get; set; }

	public Manager(string name)
	{
		Name = name;
	}

	public Manager Clone(bool deepClone = false)
	{
		if (deepClone)
		{
			var objectAsJson = JsonSerializer.Serialize(this);
			return JsonSerializer.Deserialize<Manager>(objectAsJson);
		}

		return (Manager)MemberwiseClone();
	}
}
