//Encapsulations

using Encapsulation;

BankAccount bankAccount = new BankAccount(200);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100);
System.Console.WriteLine(bankAccount.GetBalance());