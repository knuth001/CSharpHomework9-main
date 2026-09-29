namespace CSharpHomework9.Models.Bank_Account;

public class BusinessAccount:BankAccount
{
    public BusinessAccount(string accountNumber, string ownerName, decimal balance) : base(accountNumber, ownerName, balance)
    {
    }
    
}