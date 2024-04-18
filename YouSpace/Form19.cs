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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open form20
            Form20 form20 = new Form20();
            form20.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Open form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show message box about drake only 2-3 lines
            MessageBox.Show("Drake is a Canadian rapper, singer, songwriter, actor, and entrepreneur. He is considered one of the most successful and influential artists of the 21st century.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show a message with no upcoming events
            MessageBox.Show("No upcoming events for Drake.");
        }
    }
}
