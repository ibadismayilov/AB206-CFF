using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemConsoleApp;

class BankAccount
{
    public string customerName;
    public int balance;

    public void GetBalance()
    {
        Console.WriteLine($" balance: {balance}");
    }

    public void Deposit(int increment)
    {
        balance += increment;
        Console.WriteLine($"Yeni balance: {balance}");
    }

    public void Withdraw( int decrement)
    {
        balance -= decrement;
        Console.WriteLine($"Yeni balance: {balance}");
    }
}

