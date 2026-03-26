using System.Collections.Generic;

namespace Command;

class Manager : Employee
{
    public List<Employee> Employees = [];

    public Manager(int id, string name) : base(id, name)
    {

    }
}
