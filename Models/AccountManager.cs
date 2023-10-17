using System.Collections.Generic;

namespace WPF_Banken.Classes
{
    public class AccountManager
    {
        public static List<SavingsAccount> savingAccounts { get; set; } = new();
        public static List<SalaryAccount> salaryAccounts { get; set; } = new();



    }
}
