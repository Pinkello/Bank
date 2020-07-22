using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Printer printer = new Printer();

            SavingAccounts savingsAccount = new SavingAccounts("940000000001", 0.0M, "Piotr", "Pindel", 97100712345);


            SavingAccounts savingsAccount2 = new SavingAccounts("940000000002", 0.0M, "Piotr2", "Pindel2", 97100712346);


            BillingAccounts billingAccount = new BillingAccounts("940000000003", 0.0M, savingsAccount.FirstName, savingsAccount.LastName, savingsAccount.Pesel);
           
            Console.WriteLine("Pierwsze konto zostało założone przez: {0}", savingsAccount.GetFullName());
            
            Console.WriteLine("Dane konta 1:");
            printer.Print(savingsAccount);
            Console.WriteLine("Dane konta 2:");
            printer.Print(savingsAccount2);
            Console.WriteLine("Dane konta 3:");
            printer.Print(billingAccount);
            Console.WriteLine(billingAccount.GetBalance());
            Console.ReadKey();

           
        }
    }
}
