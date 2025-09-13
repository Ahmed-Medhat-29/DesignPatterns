using System;

namespace Prototype;

class Program
{
	static void Main()
	{
		Console.Title = "Prototype";

		var manager = new Manager("Hamed");
		var managerClone = manager.Clone();

		Console.WriteLine("Manager was cloned: {0}", manager.Name);

		var employee = new Employee("Ahmed", managerClone);
		var employeeClone = employee.Clone();

		Console.WriteLine("Employee was cloned: {0} with manager {1}", employeeClone.Name, employeeClone.Manager.Name);

		managerClone.Name = "Muhammad";
		Console.WriteLine("Employee was cloned: {0} with manager {1}", employeeClone.Name, employeeClone.Manager.Name);
	}
}
