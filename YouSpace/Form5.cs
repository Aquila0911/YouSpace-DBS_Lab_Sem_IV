using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouSpace
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to open form 9
            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open form11
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open form13
            Form13 form13 = new Form13();
            form13.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Open form15
            Form15 form15 = new Form15();
            form15.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open form17
            Form17 form17 = new Form17();
            form17.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open form19
            Form19 form19 = new Form19();
            form19.Show();
            this.Close();
        }
    }
}
