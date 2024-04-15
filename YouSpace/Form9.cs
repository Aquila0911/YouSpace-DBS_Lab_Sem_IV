using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace YouSpace
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show a message box
            MessageBox.Show("American Singer-Songwriter (our favorite)");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Show a message box with upcoming events
            MessageBox.Show("Upcoming Events: \n\n1. 2021-09-01: Concert at the Madison Square Garden, New York\n2. 2021-09-05: Concert at the Hollywood Bowl, Los Angeles\n3. 2021-09-10: Concert at the O2 Arena, London\n4. 2021-09-15: Concert at the AccorHotels Arena, Paris\n5. 2021-09-20: Concert at the Mercedes-Benz Arena, Berlin");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string soundPath = @"D:\Studies\Colig\Semester 4\DBMS\Lab Project\resources\lana1.wav";
            SoundPlayer player = new SoundPlayer(soundPath);
            player.Play();

            // Pause on pressing the picturebox again
            pictureBox2.Click += (s, ev) =>
            {
                player.Stop();
            };

        }

        

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Open form 5
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open form10
            Form10 f10 = new Form10();
            f10.Show();
        }
    }
}
