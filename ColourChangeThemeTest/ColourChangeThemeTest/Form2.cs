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
    public partial class Form2 : Form
    {
        public Form2(Color colorToPass, Color secondaryColor)
        {
            InitializeComponent();
            this.BackColor = colorToPass;
            label1.ForeColor = secondaryColor;
            numericUpDown1.ForeColor = secondaryColor;
            numericUpDown1.BackColor = colorToPass;
            textBox1.BackColor = colorToPass;
            textBox1.ForeColor = secondaryColor;
        }
    }
}
