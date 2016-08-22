using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace QL_DatVeXemPhim
{
    /// <summary>
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        string _ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                erUser.Text = "Enter an User";
                txtUserName.Focus();
            }
            else
            {
                string user = txtUserName.Text;
                string pass = txtPassword.Password;

                SqlConnection strCon = new SqlConnection(_ConnectionString);
                strCon.Open();
                SqlCommand cmd = new SqlCommand("Select * from UserTable where username='" + user + "'  and password='" + pass + "'", strCon);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong ");
                }
                else
                {
                    erPass.Text = "Sorry! Please enter existing emailid/password.";
                }
                strCon.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
