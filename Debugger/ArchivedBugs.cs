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
    public partial class ArchivedBugs : Form
    {
        public ArchivedBugs()
        {
            InitializeComponent();
            displayBugs();
        }

        
        public void displayBugs()
        {

            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   // display all data in the datbase in a data grid view when the displayed button is pressed 
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM ArchivedBugsTable", con);
            adapt.Fill(dt);
            dgvArchivedBugs.DataSource = dt;
           
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        private void ArchivedBugs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String bugID = txtBugID.Text;
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT , ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Method,CodeAuthor, Name, Date, Comment FROM ArchivedBugsTable WHERE BugID ='" + bugID  + "'", con);   // select all bug information on the row form bug id
            SqlDataReader mySqlDataReader = selcmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                lbWhiteBoxTester.Items.Clear();
                lbBlackBoxTester.Items.Clear();
                lbDeveloper.Items.Clear();

                lbBlackBoxTester.Items.Add(("Bug ID:          ") + mySqlDataReader["BugID"].ToString());
                lbBlackBoxTester.Items.Add(("ApplicationName: ") + mySqlDataReader["ApplicationName"].ToString());
                lbBlackBoxTester.Items.Add(("Bug Stmptoms:    ") + mySqlDataReader["BugSymptoms"].ToString());
                lbBlackBoxTester.Items.Add(("Bug Trigger:     ") + mySqlDataReader["BugTrigger"].ToString());

                lbWhiteBoxTester.Items.Add(("Project Name:    ") + mySqlDataReader["ProjectName"].ToString());
                lbWhiteBoxTester.Items.Add(("Source File:     ") + mySqlDataReader["SourceFile"].ToString());
                lbWhiteBoxTester.Items.Add(("Class Name:      ") + mySqlDataReader["ClassName"].ToString());
                lbWhiteBoxTester.Items.Add(("Line Number:     ") + mySqlDataReader["LineNumber"].ToString());
                lbWhiteBoxTester.Items.Add(("Method:          ") + mySqlDataReader["Method"].ToString());
                lbWhiteBoxTester.Items.Add(("Code Author:     ") + mySqlDataReader["CodeAuthor"].ToString());

                lbDeveloper.Items.Add(("Name:   ") + mySqlDataReader["Name"].ToString());
                lbDeveloper.Items.Add(("Date:   ") + mySqlDataReader["Date"].ToString());
                lbDeveloper.Items.Add(("Comment ")+ mySqlDataReader["Comment"].ToString());

            }
            con.Close();
        }

        private void dgvArchivedBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBugID.Text = ("");
            lbBlackBoxTester.Items.Clear();
            lbWhiteBoxTester.Items.Clear();
            lbDeveloper.Items.Clear();



            if (e.RowIndex != -1)
            {

                txtBugID.Text = dgvArchivedBugs.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbBlackBoxTester.Items.Add(("Bug ID:          ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[0].Value.ToString());
                lbBlackBoxTester.Items.Add(("ApplicationName: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[1].Value.ToString());
                lbBlackBoxTester.Items.Add(("Bug Stmptoms:    ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[2].Value.ToString());
                lbBlackBoxTester.Items.Add(("Bug Trigger:     ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[3].Value.ToString());

                lbWhiteBoxTester.Items.Add(("Project Name:    ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[4].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Source File:     ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[5].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Class Name:      ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[6].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Line Number:     ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[7].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Method:          ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[8].Value.ToString());
                lbWhiteBoxTester.Items.Add(("Code Author:     ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[9].Value.ToString());

                lbDeveloper.Items.Add(("Name: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[10].Value.ToString());
                lbDeveloper.Items.Add(("Date: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[11].Value.ToString());
                lbDeveloper.Items.Add(("Comment: ") + dgvArchivedBugs.Rows[e.RowIndex].Cells[12].Value.ToString());
            }
            else
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String bugID = txtBugID.Text;
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            SqlCommand delcmd = new SqlCommand("DELETE FROM ArchivedBugsTable WHERE BugID ='" + bugID + "'", con);                                                                   // Delete for bug form the bug database by id
            con.Open();
            
            delcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bug: " + bugID + " has been deleted");
            displayBugs();
        }
    }    }
    
