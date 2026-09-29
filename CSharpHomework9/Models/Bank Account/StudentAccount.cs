namespace CSharpHomework9.Models.Bank_Account;

public class StudentAccount:BankAccount
{
    public StudentAccount(string accountNumber, string ownerName, decimal balance) : base(accountNumber, ownerName, balance)
    {
    }
    
    
}