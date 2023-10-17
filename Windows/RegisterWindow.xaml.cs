using System;
using System.Windows;
using WPF_Banken.Classes;

namespace WPF_Banken.Windows
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Validator v = new();
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnRegisterNew_Click(object sender, RoutedEventArgs e)
        {
            string username = txtChosenName.Text;
            string password = txtChosenpassword.Text;
            bool u = v.ValidateInputLength(username);
            bool p = v.ValidateInputLength(password);
            bool containsNumbers = v.CountNumbers(username);
            bool alsoContainsNumbers = v.CountNumbers(password);

            if (u && p && alsoContainsNumbers && containsNumbers)
            {
                // Skapa två nya konton
                int nbr1 = Guid.NewGuid().GetHashCode();
                int nbr2 = Guid.NewGuid().GetHashCode();

                SavingsAccount saving = new(0, nbr1);
                SalaryAccount salary = new(0, nbr2);

                // lägg in i vår databas över konton
                AccountManager.savingAccounts.Add(saving);
                AccountManager.salaryAccounts.Add(salary);

                //skapa ny användare
                Client client = new(username, password, saving, salary);

                // lägg in i vår databas över användare 
                UserManager.usersDatabase.Add(client);

                // meddela att ny user skapats. 
                MessageBox.Show("Success!");

            }

            else
            {
                MessageBox.Show("Username and password must contain at least 3 numbers and 8 characters in total.");
            }

        }

        private void btnReturnToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
