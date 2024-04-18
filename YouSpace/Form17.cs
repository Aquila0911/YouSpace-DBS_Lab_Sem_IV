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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open form18
            Form18 form18 = new Form18();
            form18.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show message box about taylor swift
            MessageBox.Show("Taylor Swift is an American singer-songwriter. She is known for narrative songs about her personal life, which have received widespread media coverage. At age 14, Swift became the youngest artist signed by the Sony/ATV Music publishing house and, at 15, she signed her first record deal.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Open form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show upcoming events for taylor swift
            MessageBox.Show("Upcoming events for Taylor Swift: \n\n1. Lover Fest East - July 31, 2021\n2. Lover Fest West - August 1, 2021\n3. Lover Fest West - August 3, 2021\n4. Lover Fest East - August 4, 2021");
        }
    }
}
