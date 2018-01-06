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
    /// Form class containaing the methods for a black box tester to report bugs
    /// </summary>
    public partial class BlackBoxTester : Form
    {

        public BlackBoxTester()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Load the main menu form and hide current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackBBT_Click(object sender, EventArgs e)       
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        /// <summary>
        /// Exit the entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlackBoxTester_FormClosed(object sender, FormClosedEventArgs e)    // close application 
        {
            Application.Exit();
        }
        /// <summary>
        /// Insert bug information the user has enetered into the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBug_Click(object sender, EventArgs e)
        {
            String appName = txtAppName.Text;
            String bugSym = txtBugSym.Text;
            String bugTrig = txtBugTrig.Text;

            if (appName != "" && bugSym != "" && bugTrig != "")
            {
                String SqlCon = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\vs\Debugger\BugDatabase.mdf; Integrated Security = True; Connect Timeout = 30");   // point to the locaton of the database
                String insert = "INSERT INTO BugTable (ApplicationName, BugSymptoms, BugTrigger)" + "Values('" + appName + "','" + bugSym + "','" + bugTrig + "')";

                using (SqlConnection insertConection = new SqlConnection(SqlCon))
                {
                    using (SqlCommand command = new SqlCommand(insert, insertConection))
                    {
                        insertConection.Open();
                        command.ExecuteNonQuery();
                        insertConection.Close();
                        MessageBox.Show("Bug Added");
                        txtAppName.Text = "";
                        txtBugSym.Text = "";
                        txtBugTrig.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fileds ");
            }
        }
    }
}
