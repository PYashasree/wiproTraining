

using System;
using System.Threading;

public class Account
{
    public int AccountId1 { get; set; }        
    public decimal AccountBalance { get; set; } 
}

public class AccountManager
{
    private static readonly object LockObject = new object(); 
    public void Transfer(Account from, Account to, decimal amount)
    {
        lock (LockObject) 
        {
            if (from.AccountBalance < amount)
            {
                Console.WriteLine($"Insufficient balance in Account {from.AccountId1}. Transfer failed.");
            }
            else
            {
                from.AccountBalance -= amount;
                to.AccountBalance += amount;
                Console.WriteLine($"Transferred {amount} from Account {from.AccountId1} to Account {to.AccountId1}");
            }
        }
    }
}

class Lock
{
    static void Main()
    {
        var accountA = new Account { AccountId1 = 1, AccountBalance = 1000m };
        var accountB = new Account { AccountId1 = 2, AccountBalance = 500m };

        var accountManager = new AccountManager();

        var transferThreadA = new Thread(() => accountManager.Transfer(accountA, accountB, 200m));
        var transferThreadB = new Thread(() => accountManager.Transfer(accountB, accountA, 150m));

        transferThreadA.Start();
        transferThreadB.Start();

        transferThreadA.Join();
        transferThreadB.Join();

        Console.WriteLine($"Account A balance: {accountA.AccountBalance}");
        Console.WriteLine($"Account B balance: {accountB.AccountBalance}");
    }
}
