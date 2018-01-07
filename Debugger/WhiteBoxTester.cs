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
   /// Contains methods for deleting, adding source code
   /// and location of he bug 
   /// </summary>
    public partial class WhiteBoxTester : Form
    {
        public WhiteBoxTester()
        {
            InitializeComponent();
            displayData();    
        }
        /// <summary>
        /// Return back to the main menu form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackWBT_Click(object sender, EventArgs e)                        
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }
        /// <summary>
        /// display data from the database to the White box tester in the form of a Data Grid View
        /// </summary>
        public void displayData()
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   // Display all data in the datbase in a data grid view when the displayed button is pressed 
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM BugTable", con);
            adapt.Fill(dt);
            dgvBugsWBT.DataSource = dt;
            this.dgvBugsWBT.Columns["Name"].Visible = false;                                                                                                       // Hide the three columns that the white box doesn't need to see
            this.dgvBugsWBT.Columns["Date "].Visible = false;
            this.dgvBugsWBT.Columns["Comment"].Visible = false;
            con.Close();
        }
        /// <summary>
        /// claer all field on the form
        /// </summary>
        public void clear()
        {
            txtCodeSnipet.Text = "";
            txtProjectName.Text = "";
            txtSourceFile.Text = "";
            txtClassName.Text = "";
            txtLineNumber.Text = "";
            txtCodeBlock.Text = "";
            txtMethod.Text = "";
            txtBugIdWBT.Text = "";
            txtCodeAuthor.Text = "";
            txtCodeSnipet.Text = "";
            lbBlackBox.Items.Clear();
        }

    

      
        /// <summary>
        /// When the user selects a cell within the data grid view it is then displayed within the corrisponding text boxs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBugsWBT_CellClick(object sender, DataGridViewCellEventArgs e)                                                                                          
        {
            dgvBugsWBT.ReadOnly = true;
            clear();

            if (e.RowIndex != -1)                                                                                                     // Stop the user selecting the menu bar
            { 
                txtBugIdWBT.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[0].Value.ToString();                                             // Place selected data on the data grid view into the corisponding text boxes
                lbBlackBox.Items.Add(("Application Name: ")+dgvBugsWBT.Rows[e.RowIndex].Cells[1].Value.ToString());
                lbBlackBox.Items.Add(("Bug Symptoms:      ")+dgvBugsWBT.Rows[e.RowIndex].Cells[2].Value.ToString());
                lbBlackBox.Items.Add(("Bug Trigger:           ")+dgvBugsWBT.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtProjectName.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSourceFile.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtClassName.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[6].Value.ToString();   
                txtLineNumber.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMethod.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtCodeBlock.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtCodeAuthor.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtCodeSnipet.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Delete bug via the bug id the white box tester has enetered 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBugIdWBT.Text != "")                                            // test if the user has enterd the id to be deleted if not notify the user
            {
                String bugID = txtBugIdWBT.Text;
                String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                String del = ("DELETE FROM BugTable WHERE BugID ='" + bugID + "'");                                           

                using (SqlConnection deleteConection = new SqlConnection(sqlCon))
                {
                    using (SqlCommand delcmd = new SqlCommand(del, deleteConection))
                    {
                        deleteConection.Open();
                        delcmd.ExecuteNonQuery();
                        deleteConection.Close();
                        MessageBox.Show("Bug: " + bugID + " has been deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayData();
                    }
                }                                                                          
            }
            else
            {
                MessageBox.Show("Please enter or select the bug id you wish to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Search for a bug via bug id and selecting the data
        /// form the require columns in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)                                                                                                                     
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");                     
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT BugID, ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Method,CodeBlock, CodeAuthor, SourceCode FROM BugTable WHERE BugID ='" + txtBugIdWBT.Text + "'", con);
            SqlDataReader mySqlDataReader = selcmd.ExecuteReader();

            while (mySqlDataReader.Read())                                                                             // While there is data on that row display it in the corresponding feilds 
            {
                clear();
                txtBugIdWBT.Text = mySqlDataReader["BugID"].ToString();
                lbBlackBox.Items.Add (("Application Name: ")+ mySqlDataReader["ApplicationName"].ToString());
                lbBlackBox.Items.Add(("Bug Symptoms:      ")+ mySqlDataReader["BugSymptoms"].ToString());
                lbBlackBox.Items.Add(("Bug Trigger:           ") + mySqlDataReader["BugTrigger"].ToString());
                txtProjectName.Text = mySqlDataReader["ProjectName"].ToString();
                txtSourceFile.Text = mySqlDataReader["SourceFile"].ToString();
                txtClassName.Text = mySqlDataReader["ClassName"].ToString();
                txtLineNumber.Text = mySqlDataReader["LineNumber"].ToString();
                txtMethod.Text = mySqlDataReader["Method"].ToString();
                txtCodeBlock.Text = mySqlDataReader["CodeBlock"].ToString();
                txtCodeAuthor.Text= mySqlDataReader["CodeAuthor"].ToString();
                txtCodeSnipet.Text = mySqlDataReader["SourceCode"].ToString();
            }
            con.Close();

        }

        /// <summary>
        /// Use parameters to update the table when called
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="sourceFile"></param>
        /// <param name="className"></param>
        /// <param name="lineNumber"></param>
        /// <param name="method"></param>
        /// <param name="codeBlock"></param>
        /// <param name="codeAuthor"></param>
        /// <param name="sourceCode"></param>
        /// <param name="commandString"></param>
        public void UpdateBug(String projectName, String sourceFile, String className, int lineNumber, String method, String codeBlock, String codeAuthor, String sourceCode, String commandString )
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand updateCommand = new SqlCommand(commandString, con);

            updateCommand.Parameters.AddWithValue("@projectName", projectName);
            updateCommand.Parameters.AddWithValue("@sourceFile", sourceFile);
            updateCommand.Parameters.AddWithValue("@className", className);
            updateCommand.Parameters.AddWithValue("@lineNumber", lineNumber);
            updateCommand.Parameters.AddWithValue("@method", method);
            updateCommand.Parameters.AddWithValue("@codeBlock", codeBlock);
            updateCommand.Parameters.AddWithValue("@codeAuthor", codeAuthor);
            updateCommand.Parameters.AddWithValue("@sourceCode", sourceCode);
            updateCommand.ExecuteNonQuery();
            con.Close();
            clear();
            displayData();
        }

        /// <summary>
        /// Add aditional information into to the bug by updtaing the table
        /// adding or changing data about the bug. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addWBT_Click(object sender, EventArgs e)                                                                                                                          
        {
            String bugID = txtBugIdWBT.Text;
            
            if (txtBugIdWBT.Text != "" && txtProjectName.Text !=""&& txtSourceFile.Text!="" && txtClassName.Text !=""|| txtLineNumber.Text != ""&& txtMethod.Text != ""&& txtCodeBlock.Text !="" && txtCodeAuthor.Text !="" && txtCodeSnipet.Text != "") //check if all fields have been filled in.
            {        
                String commandString = ("UPDATE BugTable SET ProjectName = @projectName , SourceFile = @sourceFile, ClassName = @className ,LineNumber = @lineNumber, Method = @method, CodeBlock = @codeBlock, CodeAuthor = @codeAuthor, SourceCode =@sourceCode  WHERE (BugID ='" + bugID + "')");
                UpdateBug(txtProjectName.Text, txtSourceFile.Text, txtClassName.Text, Int32.Parse(txtLineNumber.Text), txtMethod.Text,txtCodeBlock.Text, txtCodeAuthor.Text, txtCodeSnipet.Text, commandString);
                MessageBox.Show("Aditional information has been added to BUG " + bugID, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);                                       
            }
            else
            {
                MessageBox.Show("Please enter or select the bug id and fill in all feilds to edit.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Exit the entire aplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WhiteBoxTester_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// only allow numbers to be entered for the line number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLineNumber_KeyPress(object sender, KeyPressEventArgs e)                        
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        /// <summary>
        /// Only allow numbers to be entered in the bug id text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBugIdWBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

     
        }
}
