using System.Text.Json;

namespace Prototype;

class Employee : IPerson, ICloneable<Employee>
{
	public string Name { get; set; }
	public Manager Manager { get; private set; }

	public Employee(string name, Manager manager)
	{
		Name = name;
		Manager = manager;
	}

	public Employee Clone(bool deepClone = false)
	{
		if (deepClone)
		{
			var objectAsJson = JsonSerializer.Serialize(this);
			return JsonSerializer.Deserialize<Employee>(objectAsJson);
		}

		return (Employee)MemberwiseClone();
	}
}
