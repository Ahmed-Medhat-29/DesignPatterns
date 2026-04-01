using Memento.Commands;
using Memento.Mementos;
using System.Collections.Generic;

namespace Memento;

class CommandManager
{
    private readonly Stack<AddEmployeeToManagerListMemento> _mementos = [];
    private AddEmployeeToManagerList _command;

    public void Invoke(ICommand command)
    {
        if (_command == null)
        {
            _command = (AddEmployeeToManagerList)command;
        }

        if (command.CanExecute())
        {
            command.Execute();
            _mementos.Push(((AddEmployeeToManagerList)command).CreateMemento());
        }
    }

    public void Undo()
    {
        if (_mementos.Count != 0)
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }

    public void UndoAll()
    {
        while (_mementos.Count != 0)
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }
}
