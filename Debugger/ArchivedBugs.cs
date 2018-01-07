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
using ColorCode;

namespace Debugger
{
    public partial class ArchivedBugs : Form
    {
        /// <summary>
        ///  Displays all archived bugs and contains methods
        ///  to delete and report them as not fixed
        /// </summary>
        public ArchivedBugs()
        {
            InitializeComponent();
            displayBugs();
        }
        /// <summary>
        /// Display data from the database to the White box tester in the form of a Data Grid View.
        /// </summary>
        public void displayBugs()
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM ArchivedBugsTable", con);                                                               
            adapt.Fill(dt);
            dgvArchivedBugs.DataSource = dt; 
            con.Close();
        }
        /// <summary>
        /// Return to main menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }
        /// <summary>
        ///  Exit the entire application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArchivedBugs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Display information of the archived bugs to the user in the corresponding fileds when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvArchivedBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBugID.Text = ("");
            lbBlackBoxTester.Items.Clear();
            lbWhiteBoxTester.Items.Clear();
            lbDeveloper.Items.Clear();
            dgvArchivedBugs.ReadOnly = true;                                                                                                                     // Stop  the user entering data to the data grid view.

            if (e.RowIndex != -1)                                                                                                                                // Stop the user form selecting the menu bar
            {
                String colour = dgvArchivedBugs.Rows[e.RowIndex].Cells[11].Value.ToString();
                string colorSourceCode = new CodeColorizer().Colorize(colour, Languages.CSharp);                                                                 // Format source code with colour for c# code with the colour code libary
                string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colorSourceCode + "</body></html>");

                txtBugID.Text = dgvArchivedBugs.Rows[e.RowIndex].Cells[0].Value.ToString();                                                                       // Display information about the bug from the clicked cell
                lbBlackBoxTester.Items.Add(("Bug ID:                ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[0].Value.ToString());
                lbBlackBoxTester.Items.Add(("ApplicationName: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[1].Value.ToString());
                lbBlackBoxTester.Items.Add(("Bug Stmptoms:     ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[2].Value.ToString());
                lbBlackBoxTester.Items.Add(("Bug Trigger:         ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[3].Value.ToString());

                lbWhiteBoxTester.Items.Add(("Project Name: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[4].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Source File:     ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[5].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Class Name:    ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[6].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Line Number:   ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[7].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Method:           ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[8].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Code Block:    ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[9].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Code Author:   ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[10].Value.ToString());
                webSourceCode.DocumentText = html;

                lbDeveloper.Items.Add(("Name:      ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[12].Value.ToString());
                lbDeveloper.Items.Add(("Date:        ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[13].Value.ToString());
                lbDeveloper.Items.Add(("Comment: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[14].Value.ToString());
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Allow the user to delete bugs from the archive table via bug id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String bugID = txtBugID.Text;
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            SqlCommand delcmd = new SqlCommand("DELETE FROM ArchivedBugsTable WHERE BugID ='" + bugID + "'", con);                                                                               

            con.Open(); 
            delcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bug: " + bugID + " has been deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayBugs();
            lbBlackBoxTester.Items.Clear();
            lbWhiteBoxTester.Items.Clear();
            lbDeveloper.Items.Clear();
            webSourceCode.DocumentText = ("");
        }

     /// <summary>
     /// Only allow the user to enter numbers for the Bug ID.
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void txtBugID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Display the information about the bug in the corresponding fields when bug id is enetered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String bugID = txtBugID.Text;
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Method,CodeAuthor, SourceCode, Name, Date, Comment FROM ArchivedBugsTable WHERE BugID ='" + bugID + "'", con); // select the relevent information from archived bugs table  
            SqlDataReader mySqlDataReader = selcmd.ExecuteReader();
            while (mySqlDataReader.Read())                                                                                                                                                                               //While there is data in the row display the data to the user
            {             
                lbWhiteBoxTester.Items.Clear();
                lbBlackBoxTester.Items.Clear();
                lbDeveloper.Items.Clear();

                lbBlackBoxTester.Items.Add(("Bug ID:                 ") + mySqlDataReader["BugID"].ToString());
                lbBlackBoxTester.Items.Add(("ApplicationName: ") + mySqlDataReader["ApplicationName"].ToString());
                lbBlackBoxTester.Items.Add(("Bug Stmptoms:     ") + mySqlDataReader["BugSymptoms"].ToString());
                lbBlackBoxTester.Items.Add(("Bug Trigger:          ") + mySqlDataReader["BugTrigger"].ToString());

                lbWhiteBoxTester.Items.Add(("Project Name:    ") + mySqlDataReader["ProjectName"].ToString());
                lbWhiteBoxTester.Items.Add(("Source File:       ") + mySqlDataReader["SourceFile"].ToString());
                lbWhiteBoxTester.Items.Add(("Class Name:      ") + mySqlDataReader["ClassName"].ToString());
                lbWhiteBoxTester.Items.Add(("Line Number:     ") + mySqlDataReader["LineNumber"].ToString());
                lbWhiteBoxTester.Items.Add(("Method:             ") + mySqlDataReader["Method"].ToString());
                lbWhiteBoxTester.Items.Add(("Code Author:     ") + mySqlDataReader["CodeAuthor"].ToString());

                lbDeveloper.Items.Add(("Name:      ") + mySqlDataReader["Name"].ToString());
                lbDeveloper.Items.Add(("Date:        ") + mySqlDataReader["Date"].ToString());
                lbDeveloper.Items.Add(("Comment  ") + mySqlDataReader["Comment"].ToString());

                String sourceCode = mySqlDataReader["SourceCode"].ToString();
                string colourSourceCode = new CodeColorizer().Colorize(sourceCode, Languages.CSharp);
                string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourSourceCode + "</body></html>");
                webSourceCode.DocumentText = html;

            }
            con.Close();
        }
        /// <summary>
        /// Allow the user to remove a bug that has not been fixed from 
        /// the archived bugs table back into the bugs table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNotFixed_Click(object sender, EventArgs e)
        {
            String bugID = txtBugID.Text;

            if (bugID != "")                                   // Check if bug id is entered if not notify the user
            {
                String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlConnection con = new SqlConnection(sqlCon);
                SqlCommand notFixed = new SqlCommand("INSERT INTO BugTable (ApplicationName, BugSymptoms, BugTrigger, ProjectName, SourceFile, ClassName, LineNumber, Method, CodeBlock, CodeAuthor, SourceCode, Name, Date, Comment)"                    // Take all bug information apart from bug id and place into BugID table
                          + " SELECT ApplicationName, BugSymptoms, BugTrigger, ProjectName, SourceFile, ClassName, LineNumber, Method, CodeBlock, CodeAuthor, SourceCode, Name, Date, Comment FROM ArchivedBugsTable WHERE BugID ='" + bugID + "'", con);
                SqlCommand delete = new SqlCommand("DELETE FROM ArchivedBugsTable WHERE BugID = '" + bugID + "'", con);

                con.Open();
                notFixed.ExecuteNonQuery();                                                                             //Insert and select first before deleting from archived bug table                                                                                                                      
                delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bug has been removed from the archived bugs table and placed back into the bugs table.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayBugs();
            }
            else
            {
                MessageBox.Show(" Please enter or select the bug ID you wish to report as not fixed.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }


    }    
    
