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
    public partial class BlackBoxTester : Form
    {
       
        public BlackBoxTester()
        {
            InitializeComponent();
            
        }

        private void btnBackBBT_Click(object sender, EventArgs e)        // Go back to the home page
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        private void BlackBoxTester_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        private void btnAddBug_Click(object sender, EventArgs e)
        {
                  
            String bugId = txtBugID.Text;
            String appName = txtAppName.Text;
            String bugSym = txtBugSym.Text;
            String bugTrig = txtBugTrig.Text;

            if (bugId != "" && appName != "" && bugSym != "" && bugTrig != "")
            { 
                String SqlCon = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\vs\Debugger\BugDatabase.mdf; Integrated Security = True; Connect Timeout = 30");   // point to the locaton of the database
                String insert = "INSERT INTO BugTable (BugID, ApplicationName, BugSymptoms, BugTrigger)" + "Values('" + bugId + "','" + appName + "','" + bugSym + "','" + bugTrig + "')";
              
                using (SqlConnection insertConection = new SqlConnection(SqlCon))
                {

                    using (SqlCommand command = new SqlCommand(insert, insertConection))
                    {
                        insertConection.Open();
                        command.ExecuteNonQuery();
                        insertConection.Close();
                        MessageBox.Show("Bug Added");
                        txtAppName.Text = "";
                        txtBugID.Text = "";
                        txtBugSym.Text = "";
                        txtBugTrig.Text = "";


                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields (*)");
            }
        }

    }
}
