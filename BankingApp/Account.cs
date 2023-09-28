using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    using System;

    public class Account
    {
        private decimal balance;

        public delegate void BalanceChangedEventHandler(decimal newBalance);

        public event BalanceChangedEventHandler BalanceChanged;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                OnBalanceChanged(balance);
            }
        }

        protected virtual void OnBalanceChanged(decimal newBalance)
        {
            if (BalanceChanged != null)
            {
                BalanceChanged(newBalance);
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Account account = new Account();

            account.BalanceChanged += Account_BalanceChanged;

            account.Balance += 1000;

            account.Balance -= 50;
        }

        private static void Account_BalanceChanged(decimal newBalance)
        {
            Console.WriteLine($"New account balance: {newBalance}");
        }
    }
}
