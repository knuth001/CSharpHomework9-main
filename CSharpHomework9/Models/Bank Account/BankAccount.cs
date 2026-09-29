namespace CSharpHomework9.Models.Bank_Account;

public class BankAccount
{
    //გადავწყვიტე სტრინგი ყოფილიყო რადგან ამ შემთხვევაში მათემატიკური ოპერაციები არ გვჭირდება ამ ფროფერთიზე
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }
    
    public BankAccount(string accountNumber, string ownerName, decimal balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }

     
    public  virtual  decimal CalculateInterest(decimal percent)
    {
        decimal NewBalance = Balance * (percent / 100); 
        return NewBalance;
    }

}