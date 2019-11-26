using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // for sql connection

namespace database
{
    
  public partial class AdminConnection : Form
  {
    
    string login = "";
    string password = "";
    MySqlConnection myConnection;
    MySqlDataAdapter adt;
    MySqlCommand cmd;
    MySqlDataReader reader;
    DataTable table;

    public AdminConnection(string login, string password)
    {
      this.login = login;
      this.password = password;
      InitializeComponent();
      this.openConnectionToDB(login, password);
      this.FormClosing += AdminConnection_Closing; // Adding window closing event 

    }

    private void AdminConnection_Closing(object sender, CancelEventArgs e)
    {
      this.closeConnectionToDB();
      e.Cancel = false; // Window will be closed
    }

    private void AdminConnection_Load(object sender, EventArgs e)
    {
    }

    private bool openConnectionToDB(string login, string password)
    {
      string connect = String.Format("Server=127.0.0.1;Port=3306;Database=mydb;Uid={0};Pwd={1};", "Deppa", "Deppa2920");
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

    private void Disconnect_Click(object sender, EventArgs e)
    {
      /*Authorization authorization = new Authorization();
      authorization.Show();*/
      this.Close();
    }

        private void openTable(object sender, EventArgs e)
        {
            table = new DataTable();
            //cmd = new MySqlCommand(, myConnection);

            
        }

        /* private void sendBtn_Click(object sender, EventArgs e)
         {
           try
           {
             string CommandText = String.Format("INSERT INTO client (id, full_name, contacts, address) VALUES({0}, '{1}', '{2}', '{3}');",
             //idinput.Text, nameInput.Text, phoneInput.Text, cityInput.Text);
             myConnection.Open(); //Устанавливаем соединение с базой данных.
             MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

             MySqlDataReader MyDataReader;
             MyDataReader = myCommand.ExecuteReader();
             while (MyDataReader.Read())
             {
               int id = MyDataReader.GetInt32(0); //Получаем целое число
               string result = MyDataReader.GetString(1); //Получаем строку
               result += " " + MyDataReader.GetString(2); //Получаем строку
               result += " " + MyDataReader.GetString(3); //Получаем строку
               MessageBox.Show("res: " + result + " id: " + id.ToString());
             }
             MyDataReader.Close();

             // myConnection.Close(); //Обязательно закрываем соединение!
           }
           catch (Exception ex)
           {
             MessageBox.Show(ex.Message);
           }
         }*/
    }
}
