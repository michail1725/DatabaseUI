using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace database
{
  public partial class UserConnection : Form
  {
    string login = "";
    string password = "";
    MySqlConnection myConnection;
    public UserConnection(string login, string password)
    {
      this.login = login;
      this.password = password;
      InitializeComponent();
      this.openConnectionToDB(login, password);
      this.FormClosing += UserConnection_Closing; // Adding window closing event 
    }

    private void UserConnection_Closing(object sender, CancelEventArgs e)
    {
      this.closeConnectionToDB();
      e.Cancel = false; // Window will be closed
    }

    private void UserConnection_Load(object sender, EventArgs e)
    {

    }
    private bool openConnectionToDB(string login, string password)
    {
      string connect = String.Format("Server=127.0.0.1;Port=3306;Database=mydb;Uid={0};Pwd={1};", "user", "user");
      try
      {
        myConnection = new MySqlConnection(connect);
        MessageBox.Show("You are successfully conected to data base");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        return false;
      }
      return true;
    }
    private bool closeConnectionToDB()
    {
      try
      {
        myConnection.Close(); //Обязательно закрываем соединение!
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        return false;
      }
      return true;
    }

    private void Disconnect_Click_1(object sender, EventArgs e)
    {
      /*Authorization authorization = new Authorization();
     authorization.Show();*/
      this.Close();
    }
  }
}
