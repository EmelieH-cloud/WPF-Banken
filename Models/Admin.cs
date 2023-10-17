namespace WPF_Banken.Classes
{
    public class Admin : User
    {
        // Konstruktor 
        public Admin(string username, string password, SavingsAccount a, SalaryAccount b) : base(username, password, a, b) { }
    }
}
