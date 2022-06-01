// See https://aka.ms/new-console-template for more information


using Accounts; 


BankAccount account = new BankAccount();

Console.WriteLine($"This is my account number {account.AccountNumber} and my bal {account.Balance}. Plus my name is {account.Owner}");

BankAccount account2  = new BankAccount("Nerissa", decimal.MinValue);

Console.WriteLine($"This is my account number 2 {account2.AccountNumber} and my bal {account2.Balance}. Plus my name is {account2.Owner}");

SavingAccount savings = new SavingAccount();
savings.InterestRate = 0.05m;
savings.Balance = 2000.0m;

savings.AddMonthlyInterest();

Console.WriteLine($"What is the balance {savings.Balance}");