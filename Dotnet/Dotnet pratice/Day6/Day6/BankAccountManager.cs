

using System;
using System.Threading;

class BankAccount
{
    public int Id { get; set; }
    public double CurrentBalance { get; set; }

    public override string ToString()
    {
        return $"Account ID: {Id}, Balance: {CurrentBalance}";
    }
}

class BankAccountManager
{
    public BankAccount SourceAccount { get; set; }
    public BankAccount DestinationAccount { get; set; }
    public double AmountToTransfer { get; set; }

    public void ExecuteTransfer()
    {
        if (AmountToTransfer > SourceAccount.CurrentBalance)
        {
            Console.WriteLine($"Insufficient funds in account {SourceAccount.Id}");
        }
        else
        {
            SourceAccount.CurrentBalance -= AmountToTransfer;
            DestinationAccount.CurrentBalance += AmountToTransfer;
            Console.WriteLine($"Transferred {AmountToTransfer} from account {SourceAccount.Id} to account {DestinationAccount.Id}");
        }
    }

    static void PerformTransfer(BankAccountManager manager)
    {
        manager.ExecuteTransfer();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Source Account ID: ");
        int sourceAccountId = int.Parse(Console.ReadLine());

        Console.Write("Enter Destination Account ID: ");
        int destinationAccountId = int.Parse(Console.ReadLine());

        Console.Write("Enter Amount to Transfer: ");
        double amount = double.Parse(Console.ReadLine());

        BankAccount sourceAccount = new BankAccount { Id = sourceAccountId, CurrentBalance = 10000 }; // Set initial balance
        BankAccount destinationAccount = new BankAccount { Id = destinationAccountId, CurrentBalance = 3000 }; // Set initial balance

        BankAccountManager manager = new BankAccountManager
        {
            SourceAccount = sourceAccount,
            DestinationAccount = destinationAccount,
            AmountToTransfer = amount
        };

        Thread transferThread = new Thread(() => PerformTransfer(manager));
        transferThread.Start();
        transferThread.Join();

        Console.WriteLine("Accounts after transfer:");
        Console.WriteLine(sourceAccount);
        Console.WriteLine(destinationAccount);
    }
}
