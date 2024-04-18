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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Go back to form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        Dictionary<string, int> merchandiseCounts = new Dictionary<string, int>();
        Form21 countForm;
        private void button1_Click(object sender, EventArgs e)
        {
            string merchandiseName = "Lana-Hoodie-White"; // Replace with actual merchandise name

            // Update merchandise count
            if (merchandiseCounts.ContainsKey(merchandiseName))
            {
                merchandiseCounts[merchandiseName]++;
            }
            else
            {
                merchandiseCounts.Add(merchandiseName, 1);
            }

            // Show merchandise count form
            if (countForm == null || countForm.IsDisposed)
            {
                countForm = new Form21();
            }
            countForm.UpdateCounts(merchandiseCounts);
            countForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Open form21
            Form21 form21 = new Form21();
            form21.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string merchandiseName = "Lana-Hoodie-Pink"; // Replace with actual merchandise name

            // Update merchandise count
            if (merchandiseCounts.ContainsKey(merchandiseName))
            {
                merchandiseCounts[merchandiseName]++;
            }
            else
            {
                merchandiseCounts.Add(merchandiseName, 1);
            }

            // Show merchandise count form
            if (countForm == null || countForm.IsDisposed)
            {
                countForm = new Form21();
            }
            countForm.UpdateCounts(merchandiseCounts);
            countForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string merchandiseName = "Lana-Hoodie-Black";

            // Update merchandise count
            if (merchandiseCounts.ContainsKey(merchandiseName))
            {
                merchandiseCounts[merchandiseName]++;
            }
            else
            {
                merchandiseCounts.Add(merchandiseName, 1);
            }

            // Show merchandise count form
            if (countForm == null || countForm.IsDisposed)
            {
                countForm = new Form21();
            }
            countForm.UpdateCounts(merchandiseCounts);
            countForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string merchandiseName = "Lana-Tshirt-White";

            // Update merchandise count
            if (merchandiseCounts.ContainsKey(merchandiseName))
            {
                merchandiseCounts[merchandiseName]++;
            }
            else
            {
                merchandiseCounts.Add(merchandiseName, 1);
            }

            // Show merchandise count form
            if (countForm == null || countForm.IsDisposed)
            {
                countForm = new Form21();
            }
            countForm.UpdateCounts(merchandiseCounts);
            countForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string merchandiseName = "Lana-Tshirt-Black";

            // Update merchandise count
            if (merchandiseCounts.ContainsKey(merchandiseName))
            {
                merchandiseCounts[merchandiseName]++;
            }
            else
            {
                merchandiseCounts.Add(merchandiseName, 1);
            }

            // Show merchandise count form
            if (countForm == null || countForm.IsDisposed)
            {
                countForm = new Form21();
            }
            countForm.UpdateCounts(merchandiseCounts);
            countForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string merchandiseName = "Lana-Tshirt-Grey";

            // Update merchandise count
            if (merchandiseCounts.ContainsKey(merchandiseName))
            {
                merchandiseCounts[merchandiseName]++;
            }
            else
            {
                merchandiseCounts.Add(merchandiseName, 1);
            }

            // Show merchandise count form
            if (countForm == null || countForm.IsDisposed)
            {
                countForm = new Form21();
            }
            countForm.UpdateCounts(merchandiseCounts);
            countForm.Show();
        }
    }
}
