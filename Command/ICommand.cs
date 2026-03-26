namespace Command;

interface ICommand
{
    void Execute();
    bool CanExecute();
    void Undo();
}
