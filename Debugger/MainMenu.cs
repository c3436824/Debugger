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
        /// <summary>
        /// Switch to black box tester form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBBT_Click(object sender, EventArgs e)      
        {
            this.Hide();
            BlackBoxTester BBT = new BlackBoxTester();
            BBT.ShowDialog();
        }
        /// <summary>
        ///  Switch to white box tester form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWBT_Click(object sender, EventArgs e)   
        {
            this.Hide();
            WhiteBoxTester WBT = new WhiteBoxTester();
            WBT.ShowDialog();
        }

        /// <summary>
        /// Switch to developer form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPro_Click(object sender, EventArgs e)     
        {
            this.Hide();
            Developer Pro = new Developer();
            Pro.ShowDialog();

        }
        /// <summary>
        /// Exit Application entirely
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenu_FormClosed(object sender, FormClosedEventArgs e)  
        {
            Application.Exit();
        }

        /// <summary>
        /// Switch to the devloper form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchivedBugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArchivedBugs archiveBugs = new ArchivedBugs();
            archiveBugs.Show();
        }
    }
}
