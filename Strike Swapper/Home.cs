using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strike_Swapper
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
          
        }

        private void NewMethod()
        {
            Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            swap f2 = new swap();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            swap f2 = new swap();
            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            swap f2 = new swap();
            f2.Show();
        }
    }
}
