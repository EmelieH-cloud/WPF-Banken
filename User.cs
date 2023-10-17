using WPF_Banken.Classes;

namespace WPF_Banken
{
    // obs, abstrakt klass. En metod som har nyckelordet abstract MÅSTE overridas. 
    // precis som med interfaces så går det inte att göra en instans av en abstrakt klass.
    // Den abstrakta klassen är helt enkelt ett mellanting mellan vanlig klass och interface. 
    // Vissa metoder kan förskrivas på förhand i en abstrakt klass, men i ett interface är ingen
    // kod tillåten. 
    public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public SavingsAccount SavAccount { get; set; }
        public SalaryAccount SalAccount { get; set; }



        protected User(string username, string password, SavingsAccount a, SalaryAccount b)
        {
            Username = username;
            Password = password;
            SavAccount = a;
            SalAccount = b;
        }

        public override string ToString()
        {
            return $" Username: {Username}, password: {Password}\n";
        }



    }
}
