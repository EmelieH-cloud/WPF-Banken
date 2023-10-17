namespace WPF_Banken.Classes

{
    class Client : User
    {



        public Client(string username, string password, SavingsAccount a, SalaryAccount b) : base(username, password, a, b)
        {


        }


    }
}