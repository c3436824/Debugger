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
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
        }

        private void btnBackPro_Click(object sender, EventArgs e)         // switch back too main menu
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }

        private void Programmer_FormClosed(object sender, FormClosedEventArgs e)  // switch back to the main menu
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)                                 //display the bug in formation in the list view when selected
        {
            lsBug.Items.Clear();
            if (e.RowIndex != -1)
            {
                txtBugID.Text = dataGridViewDeveloper.Rows[e.RowIndex].Cells[0].Value.ToString();
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[0].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[1].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[2].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[3].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[4].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[5].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[6].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[7].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[8].Value.ToString());
                lsBug.Items.Add(dataGridViewDeveloper.Rows[e.RowIndex].Cells[9].Value.ToString());
            }
            else
            {
                return;
            }
        }

        private void btnDisplayBugs_Click(object sender, EventArgs e)
        {
            lsBug.Items.Add("");
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");   // display all data in the datbase in a data grid view when the displayed button is pressed 

            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM BugTable", con);
            adapt.Fill(dt);
            dataGridViewDeveloper.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand selcmd = new SqlCommand("SELECT BugID, ApplicationName, BugSymptoms,BugTrigger,ProjectName,SourceFile,ClassName,LineNumber,Mehtod FROM BugTable WHERE BugID ='" + txtBugID.Text + "'", con);
            SqlDataReader mySqlDataReader = selcmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                lsBug.Items.Clear();
                lsBug.Items.Add(mySqlDataReader["BugID"].ToString());
                lsBug.Items.Add(mySqlDataReader["ApplicationName"].ToString());
                lsBug.Items.Add(mySqlDataReader["BugSymptoms"].ToString());
                lsBug.Items.Add(mySqlDataReader["BugTrigger"].ToString());
                lsBug.Items.Add(mySqlDataReader["ProjectName"].ToString());
                lsBug.Items.Add(mySqlDataReader["SourceFile"].ToString());
                lsBug.Items.Add(mySqlDataReader["ClassName"].ToString());
                lsBug.Items.Add(mySqlDataReader["LineNumber"].ToString());
                lsBug.Items.Add(mySqlDataReader["Mehtod"].ToString());
            }
            con.Close();
        }

        private void btnFixAndArchive_Click(object sender, EventArgs e)
        {

            String name = txtName.Text;
            String date = txtDate.Text;
            String coment = txtComent.Text;
            String bugID = txtBugID.Text;

            String sqlCon = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vs\Debugger\BugDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(sqlCon);
            SqlCommand upadate = new SqlCommand("UPDATE ArchivedBugsTable SET Name ='" + name + "', Date ='" + date + "', coment ='" + coment + "' WHERE (BugID ='" + bugID + "')", con);
            SqlCommand archive = new SqlCommand("INSERT INTO ArchivedBugsTable (ApplicationName, BugSymptoms, BugTrigger, ProjectName) SELECT ApplicationName, BugSymptoms, BugTrigger, ProjectName FROM BugTable WHERE BugID ='" + txtBugID.Text+ "'", con);
       
            con.Open();
            upadate.ExecuteNonQuery();
            archive.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Archive");
        }
    }
}
