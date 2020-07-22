using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingAccounts
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public SavingAccounts(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;

        }

        public string GetFullName()
        {
            string FullName = string.Format("{0} {1}", FirstName, LastName);

            return FullName;
        }

        public string GetBalance()
        {
            string balance = string.Format("Na koncie masz {0}zł", Balance);

            return balance;
        }
    }
}
