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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void BackButtonTemplates_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
        }

        private void CreateTemplateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemplateCreation tc = new TemplateCreation();
            tc.Show();
        }
    }
}
