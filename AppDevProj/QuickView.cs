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
    public partial class QuickView : Form
    {
        public QuickView()
        {
            InitializeComponent();
        }

        private void QuickviewBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
        }
    }
}
