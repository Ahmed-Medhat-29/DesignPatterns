using System.Collections.Generic;

namespace Command;

class CommandManager
{
    private readonly Stack<ICommand> _commands = [];

    public void Invoke(ICommand command)
    {
        if (command.CanExecute())
        {
            command.Execute();
            _commands.Push(command);
        }
    }

    public void Undo()
    {
        if (_commands.Count != 0)
        {
            _commands.Pop()?.Undo();
        }
    }

    public void UndoAll()
    {
        while (_commands.Count != 0)
        {
            _commands.Pop()?.Undo();
        }
    }
}
