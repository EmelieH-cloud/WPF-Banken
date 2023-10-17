using System.Windows;
using WPF_Banken.Classes;
using WPF_Banken.Windows;

namespace WPF_Banken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        Validator validator = new();
        public MainWindow()
        {


            InitializeComponent();

        }


        private void SearchUserDatabase(string user, string password)
        {
            foreach (User userObject in UserManager.usersDatabase)
            {
                // om det finns en användare med detta username och password 
                if (userObject.Username == user && userObject.Password == password)
                {

                    // öppna ett användarfönster 
                    AccountsWindow accountsWindow = new AccountsWindow(userObject);
                    accountsWindow.Show();
                    Close();
                }
            }

            lblPasswordFeedback.Content = "No user found";
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            // Hämta inputs från UI 
            string password = txtPassWord.Text;
            string username = txtUserName.Text;

            // Validera längden på inputs 
            bool u = validator.ValidateInputLength(username);
            bool p = validator.ValidateInputLength(password);
            bool numbersInUsername = validator.CountNumbers(username);
            bool numbersInPassword = validator.CountNumbers(password);

            // om längden på password och usernamn är minst 8 och innehåller minst 3 siffror vardera
            if (u && p && numbersInPassword && numbersInUsername)
            {
                SearchUserDatabase(username, password);
            }

        }

        private void BtnAdminView_Click(object sender, RoutedEventArgs e)
        {
            // öppna admin-fönstret 
            AdminWindow adminwindow = new();
            adminwindow.Show();
            Close();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }

    }
}
