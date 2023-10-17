using System.Windows;
using WPF_Banken.Classes;

namespace WPF_Banken.Windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {


        public AdminWindow()
        {
            InitializeComponent();

            foreach (SavingsAccount account in AccountManager.savingAccounts)
            {
                int number = account.AccountNbr;
                MyListView.Items.Add("Saving account: " + number);
            }

            foreach (SalaryAccount account in AccountManager.salaryAccounts)
            {
                int number = account.AccountNbr;
                MyListView.Items.Add("Salary account: " + number);
            }
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();

        }


    }
}
