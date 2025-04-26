using ConsoleApp1.scr.OOP.Encapsulation;

BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(150);
System.Console.WriteLine(bankAccount.GetBalance());