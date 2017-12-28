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

        private void WhiteBoxTester_FormClosed(object sender, FormClosedEventArgs e)    // 
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.ShowDialog();
        }
    }
}
