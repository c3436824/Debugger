using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Debugger
{
    /// <summary>
    /// Methods to create and login to the bug
    /// tracker application
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Compare the username and password to those in the database 
        /// if they esist they can enter the application displays the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sel = new SqlDataAdapter("select count(*) from login where UserName = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sel.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")                                                         //If username and password exists in the table notify the user
            {
                this.Hide();                                                                             // Display the main menu
                mainMenu main = new mainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// Allow the user to create an account to login to the bug tracker application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            String userName = txtUserName.Text;
            String password = txtPassword.Text;

            if (userName != "" && password != "")                                                       // check if username and password have been entered
            {

                SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sel = new SqlDataAdapter("select count(*) from login where UserName = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'", sqlCon);
                DataTable dt = new DataTable();
                sel.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")                                                     //if username and password exists in the table                                         
                {
                    MessageBox.Show("Username and Pasword exsits ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else                                                                                    //if the username and password don't exist insert the username and password into the table
                {
                    String con = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    String insert = "INSERT INTO Login (UserName,Password)" + "Values('" + userName + "','" + password + "')";

                    using (SqlConnection insertConection = new SqlConnection(con))
                    {
                        using (SqlCommand command = new SqlCommand(insert, insertConection))
                        {
                            insertConection.Open();
                            command.ExecuteNonQuery();
                            insertConection.Close();
                            MessageBox.Show("Acount created", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Text = "";
                            txtUserName.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the correct Username and Password ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exit the entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
    

