namespace State;

abstract class BankAccountState
{
    public BankAccount BankAccount { get; protected set; }

    public decimal Balance { get; protected set; }

    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}
