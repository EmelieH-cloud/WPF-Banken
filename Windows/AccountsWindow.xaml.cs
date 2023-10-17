using System.Windows;
using System.Windows.Controls;
using WPF_Banken.Classes;

namespace WPF_Banken.Windows
{
    /// <summary>
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    public partial class AccountsWindow : Window
    {
        public AccountsWindow(User user)
        {
            InitializeComponent();


            // label som visar vilken användare som är inloggad 
            Client client = (Client)user;
            lbluser.Content = "Username: " + client.Username + "\nPassword:" + client.Password;


            /* Listview kan inte motta objekt direkt som exempelvis listbox och combobox, 
             * istället behöver man skapa listViewItems där man manuellt lägger in objektetet
             * i en tag property. */

            ListViewItem item = new ListViewItem();
            item.Content = "Salary account:  " + client.SalAccount.AccountNbr.ToString() + "  |      Balance: " + client.SalAccount.Balance.ToString();
            item.Tag = client.SalAccount;
            accountslistview.Items.Add(item);


            ListViewItem savItem = new ListViewItem();
            savItem.Content = "Savings account:  " + client.SavAccount.AccountNbr.ToString() + "   |      Balance: " + client.SavAccount.Balance.ToString();
            savItem.Tag = client.SavAccount;
            accountslistview.Items.Add(savItem);
        }

        private void btnreturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void btnwithdraw_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
