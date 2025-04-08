using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemConsoleApp;

static class BankAccountManager
{
    static BankAccount[] bankAccount = new BankAccount[0];

    public static void CreateAccount(BankAccount account)
    {
        if (bankAccount.Length ==0)
        {
            Array.Resize(ref bankAccount, 1);
            bankAccount[0] = account;
            Console.WriteLine("Account yaradildi");
        } else
        {
            Array.Resize(ref bankAccount, bankAccount.Length + 1);
            bankAccount[bankAccount.Length - 1] = account;
            Console.WriteLine("Account yaradildi");
        }
    }
}
