namespace Accounts;

public class SavingAccount: BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingAccount(): base()
    {
        
    }

    public SavingAccount(string owner, decimal initialBalance ): base(owner, initialBalance)
    {
        
    }
    public void AddMonthlyInterest()
    {
        Balance += Balance * InterestRate;
    }
}