using System;

namespace WPF_Banken.Classes
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get; set; }
        public int AccountNbr { get; set; }


        public SalaryAccount(double balance, int nbr)
        {
            Balance = balance;
            AccountNbr = nbr;

        }
        public void Deposit() // sätta in pengar på balance 
        {
            throw new NotImplementedException();
        }

        public int RandomAccountNumber()
        {

            int i = Guid.NewGuid().GetHashCode();
            return i;


        }

        public void Withdraw() // ta ut pengar från balance 
        {
            throw new NotImplementedException();
        }

    }
}
