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
    public partial class Programmer : Form
    {
        public Programmer()
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
    }
}
