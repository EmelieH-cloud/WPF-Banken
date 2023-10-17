namespace WPF_Banken
{
    // Detta interface skapar ett "kontrakt" där samtliga klasser som ärver IAccount måste implementera nedan
    // metoder och properties. 

    public interface IAccount
    {
        public double Balance { get; set; }
        public int AccountNbr { get; set; }
        void Withdraw();

        void Deposit();


    }
}
