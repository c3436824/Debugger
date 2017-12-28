using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugger
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnBBT_Click(object sender, EventArgs e)    //Switch too black box tester form  
        {
            this.Hide();
            BlackBoxTester BBT = new BlackBoxTester();
            BBT.ShowDialog();
        }

        private void btnWBT_Click(object sender, EventArgs e)    //Switch too white box tester form
        {
            this.Hide();
            WhiteBoxTester WBT = new WhiteBoxTester();
            WBT.ShowDialog();
        }

        private void btnPro_Click(object sender, EventArgs e)     //Switch too Programmer form 
        {
            this.Hide();
            Programmer Pro = new Programmer();
            Pro.ShowDialog();

        }

        private void mainMenu_FormClosed(object sender, FormClosedEventArgs e)  // Closed the Application completely
        {
            Application.Exit();
        }
    }
}
