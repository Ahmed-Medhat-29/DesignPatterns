using System;
using System.Collections.Generic;
using System.Linq;

namespace Command;

class EmployeeManagerRepository : IEmployeeManagerRepository
{
    private readonly List<Manager> _managers = [new Manager(1, "Katie"), new Manager(2, "Geoff")];

    public void AddEmployee(int managerId, Employee employee)
    {
        // in real-life, add additional input & error checks
        _managers.First(m => m.Id == managerId).Employees.Add(employee);
    }

    public void RemoveEmployee(int managerId, Employee employee)
    {
        // in real-life, add additional input & error checks
        _managers.First(m => m.Id == managerId).Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, int employeeId)
    {
        // in real-life, add additional input & error checks
        return _managers.First(m => m.Id == managerId)
            .Employees.Any(e => e.Id == employeeId);
    }

    /// <summary>
    /// For demo purposes, write out the data store to the console window
    /// </summary>
    public void WriteDataStore()
    {
        foreach (var manager in _managers)
        {
            Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
            if (manager.Employees.Count != 0)
            {
                foreach (var employee in manager.Employees)
                {
                    Console.WriteLine($"\t Employee {employee.Id}, {employee.Name}");
                }
            }
            else
            {
                Console.WriteLine($"\t No employees.");
            }
        }
    }
}
