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
        }

        private void btnBackWBT_Click(object sender, EventArgs e)                        //Switch back to main menu form
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

      
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   // display all data in the datbase in a data grid view when the displayed button is pressed 

            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM BugTable", con);
            adapt.Fill(dt);
            dgvBugsWBT.DataSource = dt;
            con.Close();
        }

        private void dgvBugsWBT_CellClick(object sender, DataGridViewCellEventArgs e)                                                                                           // place selected data on the data grid view into the corisponding text boxes
        {
            lbSymptoms.Items.Clear();
            lbTrigger.Items.Clear();
            txtBugIdWBT.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[0].Value.ToString();                                   
            lblAppName.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbSymptoms.Items.Add( dgvBugsWBT.Rows[e.RowIndex].Cells[2].Value.ToString());
            lbTrigger.Items.Add( dgvBugsWBT.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtProjectName.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSourceFile.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtClassName.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLineNumber.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtMethod.Text = dgvBugsWBT.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);

            con.Open();
            SqlCommand delcmd = new SqlCommand("DELETE FROM BugTable WHERE BugID ='" + txtBugIdWBT.Text + "'", con);                                                                   // Delete for bug form the bug database by id
            delcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bug: "+txtBugIdWBT.Text+ " has been deleted");
        }

        private void btnSearch_Click(object sender, EventArgs e)                                                                                                                       // Allow the WBT to browse bugs and selcet bugs through a data grid view 
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");                     
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT BugID, ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Mehtod FROM BugTable WHERE BugID ='" + txtBugIdWBT.Text + "'", con);
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
                txtMethod.Text = mySqlDataReader["Mehtod"].ToString();        
            }
            con.Close();

        }


        private void addWBT_Click(object sender, EventArgs e)                                                                                                                          // Allows white box teseter add aditional information to the bug
        {
            if (txtBugIdWBT.Text != "")
            {
                String projectName = txtProjectName.Text;
                String sourceFile = txtSourceFile.Text;
                String className = txtClassName.Text;
                String lineNumber = txtLineNumber.Text;
                String method = txtMethod.Text;
                String bugID = txtBugIdWBT.Text;

                SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                sqlCon.Open();
                SqlCommand addInfo = new SqlCommand("UPDATE BugTable SET ProjectName ='" + projectName + "', SourceFile = '" + sourceFile + "', ClassName = '" + className + "' ,LineNumber = '" + lineNumber + "', Mehtod = '" + method + "' WHERE (BugID ='" + bugID + "')", sqlCon);
                addInfo.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Adition information has been added");
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
    }
}
