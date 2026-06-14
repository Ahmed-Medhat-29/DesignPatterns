using State.States;

namespace State;

class BankAccount
{
    public BankAccountState BankAccountState { get; set; }
    public decimal Balance { get { return BankAccountState.Balance; } }

    public BankAccount()
    {
        BankAccountState = new RegularState(200, this);
    }

    public void Deposit(decimal amount)
    {
        BankAccountState.Deposit(amount);
    }

    public void Withdraw(decimal amount)
    {
        BankAccountState.Withdraw(amount);
    }
}
