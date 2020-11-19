using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTreePlantation_
{
    /// <summary>
    /// Interaction logic for loginPage.xaml
    /// </summary>
    public partial class loginPage : Page
    {
        public MainWindow mainWindow;
        int clientcode;

        public loginPage(MainWindow _mainWindow, int code)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            clientcode = code;
        }
        public loginPage(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {

            //using (AccountContext context = new AccountContext())
            //{
            //    Account User;
            //    User = new Account("", "");
            //    context.Accounts.Add(User);
            //    context.SaveChanges();
            //}
            if (LOG.Text.Length > 0)
            {
                if (PASSWORD.Password.Length > 0) 
                {

                    DataTable client = mainWindow.Select("SELECT[AccountID] FROM [AccountContex].[dbo].[Accounts] WHERE [Login] = '" + LOG.Text + "' AND [Password] = '" + PASSWORD.Password + "'",1);
                    if (client.Rows.Count > 0)
                    {
                        int highestcode = Convert.ToInt32("" + client.Rows[0][0]);
                        clientcode = highestcode;
                        mainWindow.frame.Navigate(new USMenu(mainWindow, clientcode));
                        MessageBox.Show("Authorized");
                    }
                    else MessageBox.Show("User not found");
                }
                else MessageBox.Show("Enter the password");
            }
            else MessageBox.Show("Enter the login");
        }
        private void register_Click(object sender, RoutedEventArgs e)
        {
            //mainWindow.OpenPage(MainWindow.pages.register);
            mainWindow.frame.Navigate(new Register_page(mainWindow));
        }
        public loginPage()
        {
            InitializeComponent();
        }
    }
}
