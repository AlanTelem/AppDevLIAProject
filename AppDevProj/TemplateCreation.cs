using LIA_model;
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
    public partial class TemplateCreation : Form
    {
        public TemplateCreation()
        {
            InitializeComponent();
        }
        
        private LIA_model.appDevEntities dbcontext = new LIA_model.appDevEntities();
        private void TemplateCreationBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template template = new Template();
            template.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CollectionUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void NewValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDetailsButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template template = new Template();
            template.Show();
        }
    }
}
