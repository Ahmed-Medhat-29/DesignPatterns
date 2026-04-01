namespace Memento;

interface ICommand
{
    void Execute();
    bool CanExecute();
    void Undo();
}
