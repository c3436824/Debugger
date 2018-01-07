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
    /// <summary>
    ///  Contains methods for viewing, deleting, editing source code
    ///  and archiving them.
    /// </summary>
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
            txtDate.ReadOnly = true;                                    
            txtDate.Text = DateTime.Now.ToString("dd-mm-yyyy");          // Automaticly genarate the date
            displayBugs();
        }

        /// <summary>
        /// Display the data in the BugTable to the develop in a data grid view
        /// </summary>
        public void displayBugs()
        {

            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   // display all data in the datbase in a data grid view when the displayed method is called 
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM BugTable", con);
            adapt.Fill(dt);
            dataGridViewDeveloper.DataSource = dt;

            this.dataGridViewDeveloper.Columns["Name"].Visible = false;                                                                                                       // Hide the three columns that the white box tester doesnt need to see
            this.dataGridViewDeveloper.Columns["Date "].Visible = false;
            this.dataGridViewDeveloper.Columns["Comment"].Visible = false;
            con.Close();
        }

        /// <summary>
        /// Take the user back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackPro_Click(object sender, EventArgs e)        
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        /// <summary>
        /// Exit the entire aplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Programmer_FormClosed(object sender, FormClosedEventArgs e)  
        {
            Application.Exit();
        }
        /// <summary>
        ///  Display information of the bug the developer when clicked in the corresponding fileds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)                 
        {
            lsBug.Items.Clear();
            if (e.RowIndex != -1)                                                                                                                           // Stop the user form selecting the menu bar.
            {
               dataGridViewDeveloper.ReadOnly = true;                                                                                                       // // Stop  the user entering data to the data grid view.

                String sourceCode = dataGridViewDeveloper.Rows[e.RowIndex].Cells[11].Value.ToString();
                string colourSourceCode = new CodeColorizer().Colorize(sourceCode, Languages.CSharp);
                string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourSourceCode + "</body></html>");
                webColourCode.DocumentText = html;

                txtBugID.Text = dataGridViewDeveloper.Rows[e.RowIndex].Cells[0].Value.ToString();                                                          // Display information about the bug from the clicked cell. 

                lsBug.Items.Add(("Bug ID:                 ")+dataGridViewDeveloper.Rows[e.RowIndex].Cells[0].Value.ToString());
                lsBug.Items.Add(("ApplicationName: ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[1].Value.ToString());
                lsBug.Items.Add(("Bug Stmptoms:     ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[2].Value.ToString());
                lsBug.Items.Add(("Bug Trigger:         ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[3].Value.ToString());
                lsBug.Items.Add(("Project Name:      ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[4].Value.ToString());
                lsBug.Items.Add(("Source File:         ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[5].Value.ToString());
                lsBug.Items.Add(("Class Name:        ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[6].Value.ToString());
                lsBug.Items.Add(("Line Number:      ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[7].Value.ToString());
                lsBug.Items.Add(("Method:               ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[8].Value.ToString());
                lsBug.Items.Add(("Code Block:        ") + dataGridViewDeveloper.Rows[e.RowIndex].Cells[9].Value.ToString());
                lsBug.Items.Add(("Code Author:       ") +dataGridViewDeveloper.Rows[e.RowIndex].Cells[10].Value.ToString());

                txtSourceCode.Text= dataGridViewDeveloper.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            else
            {
                return;
            }
        }

      
        /// <summary>
        ///  Search and return bug information from the table to 
        ///  the developer display the information in the corresponding feilds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT BugID, ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Method,CodeBlock, CodeAuthor, SourceCode, Name, Date, Comment FROM BugTable WHERE BugID ='" + txtBugID.Text + "'", con);   // select all bug information on the row form bug id
            SqlDataReader mySqlDataReader = selcmd.ExecuteReader();

            while (mySqlDataReader.Read())                                                                                                                                               // While there is data in the row display the data to the user
            {
                lsBug.Items.Clear();

                lsBug.Items.Add(("Bug ID:                   ") + mySqlDataReader["BugID"].ToString());
                lsBug.Items.Add(("ApplicationName:   ") + mySqlDataReader["ApplicationName"].ToString());
                lsBug.Items.Add(("Bug Stmptoms:       ") + mySqlDataReader["BugSymptoms"].ToString());
                lsBug.Items.Add(("Bug Trigger:           ") + mySqlDataReader["BugTrigger"].ToString());
                lsBug.Items.Add(("Project Name:        ") + mySqlDataReader["ProjectName"].ToString());
                lsBug.Items.Add(("Source File:            ") + mySqlDataReader["SourceFile"].ToString());
                lsBug.Items.Add(("Class Name:           ") + mySqlDataReader["ClassName"].ToString());
                lsBug.Items.Add(("Line Number:          ") + mySqlDataReader["LineNumber"].ToString());
                lsBug.Items.Add(("Method:                  ") + mySqlDataReader["Method"].ToString());
                lsBug.Items.Add(("CodeBlock:            ") + mySqlDataReader["CodeBlock"].ToString());
                lsBug.Items.Add(("Code Author:          ") + mySqlDataReader["CodeAuthor"].ToString());

                txtSourceCode.Text = mySqlDataReader["SourceCode"].ToString();                                                                                    
                String sourceCode = mySqlDataReader["SourceCode"].ToString();
                string colourSourceCode = new CodeColorizer().Colorize(sourceCode, Languages.CSharp);                                                                                   // Format Source code with colour for c# code with the colour code libary
                string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourSourceCode + "</body></html>");
                webColourCode.DocumentText = html;
            }
            con.Close();
        }

        /// <summary>
        /// Use parameters to update the table when called
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="comment"></param>
        /// <param name="sourceCode"></param>
        /// <param name="commandString"></param>
        public void UpdateBug(String name, String date, String comment, String sourceCode,  String commandString)
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand updateCommand = new SqlCommand(commandString, con);

            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.Parameters.AddWithValue("@date", date);
            updateCommand.Parameters.AddWithValue("@comment", comment);
            updateCommand.Parameters.AddWithValue("@sourceCode", sourceCode);
            updateCommand.ExecuteNonQuery();
            con.Close();
           
        }
        /// <summary>
        /// The developer can archive bugs when they are fixed to store 
        /// them in a new table and delete them form the bug table  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFixAndArchive_Click(object sender, EventArgs e)
        {

            String name = txtName.Text;
            String date = txtDate.Text;
            String comment = txtComent.Text;
            String bugID = txtBugID.Text;
            String sourceCode = txtSourceCode.Text;
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");

            if (bugID != "" && name !=""&& comment!="")                                                                                                                  //Check if all fields have been filled if not notify user
            {
                SqlConnection con = new SqlConnection(sqlCon);
                String commandString = ("UPDATE BugTable SET Name = @name, Date =@date, comment =@comment, SourceCode = @sourceCode WHERE (BugID ='" + bugID + "')");    // Give the conecetion string the update query 
                UpdateBug(txtName.Text,txtDate.Text,txtComent.Text,txtSourceCode.Text,commandString);                                                                    // Pass the update method the values to be updated from the user                   
                SqlCommand archive = new SqlCommand("INSERT INTO ArchivedBugsTable (ApplicationName, BugSymptoms, BugTrigger, ProjectName, SourceFile, ClassName, LineNumber, Method, CodeBlock, CodeAuthor, SourceCode, Name, Date, Comment)"      // Bug has been updated now take the updated data from bug table and 
                    + " SELECT ApplicationName, BugSymptoms, BugTrigger, ProjectName, SourceFile, ClassName, LineNumber, Method, CodeBlock, CodeAuthor, SourceCode, Name, Date, Comment FROM BugTable WHERE BugID ='" + txtBugID.Text + "'", con);  // place it into the archive table then delete the bug form bug table. 
                SqlCommand delete = new SqlCommand("DELETE FROM BugTable WHERE BugID = '" + bugID +"'" , con);

                con.Open();
                archive.ExecuteNonQuery();
                delete.ExecuteNonQuery();
                con.Close();
                displayBugs();
                MessageBox.Show("Bug ID: "+bugID + " has been archive", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Please enter or select the bug ID you wish to archive and fill in all fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Dsiplay the ArchivedBugs to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewArchivedBugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArchivedBugs archived = new ArchivedBugs();
            archived.Show(); 
        }

      
        /// <summary>
        /// The Developer can enter only numbers for the bug id 
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
        ///  Display the users editable source code
        ///  formatted and colour coded in a web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSourceCode_Click(object sender, EventArgs e)
        {
            String editedSourceCode = txtSourceCode.Text;                                                    
            string colourSourceCode = new CodeColorizer().Colorize(editedSourceCode, Languages.CSharp);          // Format source code with colour for c# code with the colour code libary
            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourSourceCode + "</body></html>");
            webColourCode.DocumentText = html;

        }
    }
}
