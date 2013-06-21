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
        public Account(float k)
        {
            bal = k;
            Console.WriteLine("Enter name, account number and account type (saving or current) ");
            name =  Console.ReadLine();
            ano = long.Parse(Console.ReadLine());
            type = Console.ReadLine();
        }
    }
    class SavAcct : Account
    {
        float f;
        public SavAcct(float r, float s)
            : base(r)
        {
            f = s;
        }
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
            if (a > bal)
                Console.WriteLine("ERROR : Not enough balance in account. ");
            bal = bal - a;
        }
        
    }
    class CurrAcct : Account
    {
        public CurrAcct(float b) : base (b)
        {
            bal = b;
        }
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

