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
    public partial class WhiteBoxTester : Form
    {
        public WhiteBoxTester()
        {
            InitializeComponent();
            displayData();
           
        }

        private void btnBackWBT_Click(object sender, EventArgs e)                        //Switch back to main menu form
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        public void displayData()
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   // display all data in the datbase in a data grid view when the displayed button is pressed 

            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM BugTable", con);
            adapt.Fill(dt);
            dgvBugsWBT.DataSource = dt;
            this.dgvBugsWBT.Columns["Name"].Visible = false;                                                                                                       // hide the three columns that the white box doesnt need to see
            this.dgvBugsWBT.Columns["Date "].Visible = false;
            this.dgvBugsWBT.Columns["Comment"].Visible = false;
            con.Close();
        }

      

        private void dgvBugsWBT_CellClick(object sender, DataGridViewCellEventArgs e)                                                                                           // place selected data on the data grid view into the corisponding text boxes
        {
            lbSymptoms.Items.Clear();
            lbTrigger.Items.Clear();

            if (e.RowIndex != -1)
            {
                txtBugIdWBT.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblAppName.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbSymptoms.Items.Add(dgvBugsWBT.Rows[e.RowIndex].Cells[2].Value.ToString());
                lbTrigger.Items.Add(dgvBugsWBT.Rows[e.RowIndex].Cells[3].Value.ToString());
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBugIdWBT.Text != "")
            {
                String bugID = txtBugIdWBT.Text;
                String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");

                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();
                SqlCommand delcmd = new SqlCommand("DELETE FROM BugTable WHERE BugID ='" + bugID + "'", con);                                                                   // Delete for bug form the bug database by id
                delcmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("BUG: " + bugID + " HAS BEEN DELETED");
                displayData();
            }
            else
            {
                MessageBox.Show("PLEASE ENTER OR SELECT THE BUG ID THAT YOU WISH TO DELETE");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)                                                                                                                       // Allow the WBT to browse bugs and selcet bugs through a data grid view 
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");                     
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT BugID, ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Method,CodeBlock, CodeAuthor, SourceCode FROM BugTable WHERE BugID ='" + txtBugIdWBT.Text + "'", con);
            SqlDataReader mySqlDataReader = selcmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                lbSymptoms.Items.Clear();
                lbTrigger.Items.Clear();
                txtBugIdWBT.Text = mySqlDataReader["BugID"].ToString();
                lblAppName.Text = mySqlDataReader["ApplicationName"].ToString();
                lbSymptoms.Items.Add(mySqlDataReader["BugSymptoms"].ToString());
                lbTrigger.Items.Add(mySqlDataReader["BugTrigger"].ToString());
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


        private void addWBT_Click(object sender, EventArgs e)                                                                                                                          // Allows white box teseter add aditional information to the bug
        {
            if (txtBugIdWBT.Text != "" )
            {
                String projectName = txtProjectName.Text;
                String sourceFile = txtSourceFile.Text;
                String className = txtClassName.Text;
                String lineNumber = txtLineNumber.Text;
                String codeBlock = txtCodeBlock.Text;
                String method = txtMethod.Text;
                String bugID = txtBugIdWBT.Text;
                String codeAuthor = txtCodeAuthor.Text;
                String sourceCode = txtCodeSnipet.Text;
              

                SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                sqlCon.Open();
                SqlCommand addInfo = new SqlCommand("UPDATE BugTable SET ProjectName ='" + projectName + "', SourceFile = '" + sourceFile + "', ClassName = '" + className + "' ,LineNumber = '" + lineNumber + "', Method = '" + method + "',  CodeBlock = '" + codeBlock + "', CodeAuthor = '" + codeAuthor + "', SourceCode = '" + sourceCode + "' WHERE (BugID ='" + bugID + "')", sqlCon);
                addInfo.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Aditional information has been added to BUG "+ bugID);
                displayData();
            }
            else
            {
                MessageBox.Show("PLEASE ENTER OR SELECT THE BUG ID THAT YOU WISH TO EDIT ");
            }




        }
        
        private void WhiteBoxTester_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtLineNumber_KeyPress(object sender, KeyPressEventArgs e)                        // only allow didgits  to be entered into the line textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtBugIdWBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
