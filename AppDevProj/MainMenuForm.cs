using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevProj
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ExitButtonMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TemplateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template temp = new Template();
            temp.Show();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuickView qv = new QuickView();
            qv.Show();
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no friends!");

        }
    }
}
