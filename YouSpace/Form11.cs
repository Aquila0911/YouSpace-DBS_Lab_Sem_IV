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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open form12
            Form12 form12 = new Form12();
            form12.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Open form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show a message box with details on Kanye West
            MessageBox.Show("Kanye West is a rapper, singer, songwriter, record producer, and fashion designer. He has been influential in the 21st-century development of mainstream hip hop and popular music in general.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // List a few upcoming events Kanye West is performing at
            MessageBox.Show("Kanye West is performing at the following events:\n\n1. Coachella Valley Music and Arts Festival\n2. Bonnaroo Music and Arts Festival\n3. Lollapalooza Music Festival\n4. Austin City Limits Music Festival\n5. Glastonbury Festival");
        }
    }
}
