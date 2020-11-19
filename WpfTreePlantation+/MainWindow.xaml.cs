using System;
using System.Collections.Generic;
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
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.Data;
using System.Data.SqlClient;

namespace WpfTreePlantation_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //OpenPage(pages.login);
            frame.Navigate(new loginPage(this));
        }
        public DataTable Select(string selectSQL,int check)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection();
            if (check ==1) 
             sqlConnection = new SqlConnection("server=(LocalDb)\\MSSQLLocalDB;Trusted_Connection=Yes;DataBase=AccountContex;");
            if (check == 2)
             sqlConnection = new SqlConnection("server=(LocalDb)\\MSSQLLocalDB;Trusted_Connection=Yes;DataBase=ProcessInfoContext;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}