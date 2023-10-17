using System;

namespace WPF_Banken.Classes
{
    public class SavingsAccount : IAccount
    {
        // En ny User ska få 0-1000 kronor automatiskt på sitt sparkonto när det skapas

        public double Balance { get; set; } = 1000;
        public int AccountNbr { get; set; }


        public SavingsAccount(double balance, int nbr)
        {
            Balance = balance;
            AccountNbr = nbr;

        }
        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public void Withdraw()
        {
            throw new NotImplementedException();
        }


    }
}
