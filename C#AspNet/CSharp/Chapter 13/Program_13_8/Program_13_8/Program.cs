using System;

namespace Program_13_8
{
    class Account
    {
        protected string name;
        protected long ano;
        protected string type;
        protected float bal;
        public void Dispay()
        {
            Console.WriteLine("Balance : " + bal);
        }
        public void Deposit(float a)
        {
            bal += a;
        }
        public void SetValues()
        {
            Console.WriteLine("Enter name, account number and account type (saving or current) ");
            Console.ReadLine(name);
            ano = long.Parse(Console.ReadLine());
            Console.ReadLine(type);
        }
    }
    class SavAcct : Account
    {
        public void Interest()
        {
            Console.WriteLine("Enter the number of conversion periods ");
            short n = short.Parse(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                bal = bal * ((100 + f) / 100);
            }
        }
        public void Withdraw(float a)
        {
            if(a>bal)
                Console.WriteLine("ERROR : Not enough balance in account. ");
            bal = bal - a;
        }
        public void SetSave()
        {
            Console.WriteLine("Enter rate of interest ");
            float f = float.Parse(Console.ReadLine());
        }
    }
    class CurrAcct : Account
    {
        float MinBal, penalty;
        public void Withdraw(float f)
        {
            if (f > bal)
                Console.WriteLine("ERROR : Not enough balance in account. ");
            bal -= f;
            if (bal < MinBal)
            {
                Console.WriteLine("WARNING : The balance has gone below the minimum required balance.Penalty charges will be deducted.");
                bal = bal - penalty;
            }
        }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
