using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
  public partial class Authorization : Form
  {
    public Authorization()
    {
      InitializeComponent();
    }

    public static string currentLogin = "";
    public static string currentPassword = "";

    private void signInBtn_Click(object sender, EventArgs e)
    {
     
    }
    private void button1_Click(object sender, EventArgs e)
    {
      if (loginField.Text == "user" && passwordField.Text == "user")
      {
        UserConnection connection = new UserConnection(loginField.Text, passwordField.Text); // new window
        connection.Show();
        
      }
      else if (loginField.Text == "Deppa" && passwordField.Text == "Deppa2920")
      {
        AdminConnection connection = new AdminConnection(loginField.Text, passwordField.Text); // new window
        connection.Show();
        
      }
      else
      {
        MessageBox.Show("Wrong date", "Error", MessageBoxButtons.OK);
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
