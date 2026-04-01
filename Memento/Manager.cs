using System.Collections.Generic;

namespace Memento;

class Manager : Employee
{
    public List<Employee> Employees = [];

    public Manager(int id, string name) : base(id, name)
    {

    }
}
