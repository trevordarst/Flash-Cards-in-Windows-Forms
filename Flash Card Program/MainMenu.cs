using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flash_Card_Program
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void createNewSetButton_Click(object sender, EventArgs e)
        {
            //Opens the Set Creation Form.

            using (SetCreator form1 = new SetCreator())
                form1.ShowDialog();
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            //Exits the application completely closing all forms.

            Application.Exit();
        }

        private void viewExistingSetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
