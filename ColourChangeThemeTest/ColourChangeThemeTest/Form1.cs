using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourChangeThemeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: 
                    this.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    break;
                case 1: 
                    this.BackColor = Color.Black;
                    label1.ForeColor = Color.White;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Form2 form2 = new Form2(Color.White, Color.Black);
                    form2.Show();
                    break;
                case 1:
                    Form2 formTwo = new Form2(Color.Black, Color.White);
                    formTwo.Show();
                    break;
            }
        }
    }
}
