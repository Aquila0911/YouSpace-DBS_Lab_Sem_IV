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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open form16
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Open form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show a message box about Hozier
            MessageBox.Show("Hozier is an Irish musician and singer-songwriter known for his soulful voice and powerful lyrics. Hozier's music often explores themes of love, religion, and social justice, and he is praised for his emotive performances and thought-provoking songwriting.", "About Hozier");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // List some upcoming events of Hozier
            MessageBox.Show("Hozier has a number of upcoming events, including a concert in Dublin, Ireland on August 30th, 2021, and a performance at the Bonnaroo Music & Arts Festival in Manchester, Tennessee on September 2nd, 2021. For a full list of Hozier's upcoming events, visit his official website or check local concert listings.", "Upcoming Events");
        }
    }
}
