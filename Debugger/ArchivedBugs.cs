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
        public ArchivedBugs()
        {
            InitializeComponent();
            displayBugs();
        }
        /// <summary>
        /// display data from the database to the White box tester in the form of a Data Grid View
        /// </summary>
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
        /// <summary>
        /// Display information of the bug the developer when clicked in the corresponding fileds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvArchivedBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBugID.Text = ("");
            lbBlackBoxTester.Items.Clear();
            lbWhiteBoxTester.Items.Clear();
            lbDeveloper.Items.Clear();
            dgvArchivedBugs.ReadOnly = true;

            if (e.RowIndex != -1)
            {
                String colour = dgvArchivedBugs.Rows[e.RowIndex].Cells[11].Value.ToString();
                string colorSourceCode = new CodeColorizer().Colorize(colour, Languages.CSharp);
                string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colorSourceCode + "</body></html>");

                txtBugID.Text = dgvArchivedBugs.Rows[e.RowIndex].Cells[0].Value.ToString();
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
        /// Allow the user to delete bugs in the archive table buy there bug id
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
            MessageBox.Show("Bug: " + bugID + " has been deleted");
            displayBugs();
        }

     
        private void txtBugID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }    }
    
