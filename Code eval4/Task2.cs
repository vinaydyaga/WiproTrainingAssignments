using System;

class Account
{
    // Define properties
    // Complete Step 1:............
    public string AccountNumber{get; private set;}
    public string OwnerName{get;  set;}
    public decimal Balance{get; private set;}

    public Account (string accountNumber, string ownerName)
    {
        AccountNumber=accountNumber;
        OwnerName=ownerName;
        Balance=0;
    }
    public void Deposit(decimal amount)
    {
        Balance+=amount;
        Console.WriteLine("Deposited: $"+amount.ToString("F2"));
        Console.WriteLine("Account Balance: $"+Balance.ToString("F2"));
    }
    public void Withdraw(decimal amount)
    {
        Balance-=amount;
        Console.WriteLine("Withdrew: $"+amount.ToString("F2"));
        Console.WriteLine("Account Balance: $"+Balance.ToString("F2"));
        
    }

    // Define methods
    // Complete Step 2:............
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        string accNumber=Console.ReadLine();
        // Complete Step 3:............

        Console.WriteLine("Enter owner name:");
        string ownerName=Console.ReadLine();
        // Complete Step 4:............

        // Create an instance of the Account class
        Account account=new Account(accNumber,ownerName);
        // Complete Step 5:............
        account.Deposit(100);
        account.Withdraw(50);
        

        // Complete Step 6:............
    }
}