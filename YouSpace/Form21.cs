using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace YouSpace
{
    public partial class Form21 : Form
    {
        public void UpdateCounts(Dictionary<string, int> counts)
        {
            // Clear previous labels
            ClearLabels();

            // Display merchandise names and counts
            int xPosition = 1100;
            int yPosition = 250; 

            try
            {
                foreach (var entry in counts)
                {
                    // Create and configure the label for merchandise name
                    Label nameLabel = new Label();
                    nameLabel.Text = entry.Key;
                    nameLabel.Name = $"nameLabel_{entry.Key}";
                    nameLabel.Location = new Point(xPosition, yPosition);
                    Controls.Add(nameLabel);

                    // Create and configure the label for merchandise count
                    Label countLabel = new Label();
                    countLabel.Text = entry.Value.ToString();
                    countLabel.Name = $"countLabel_{entry.Key}";
                    countLabel.Location = new Point(xPosition+150, yPosition);
                    Controls.Add(countLabel);

                    // Update the Y position for the next labels
                    yPosition += 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearLabels()
        {
            // Remove previous labels by name
            foreach (Control control in Controls)
            {
                if (control is Label && (control.Name.StartsWith("nameLabel_") || control.Name.StartsWith("countLabel_")))
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
        }
        public Form21()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open a connection and insert order id and no. of items into the database in orders table
            string oradb = "Data Source=localhost:1521/XE;User Id=system;Password=password;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // Before inserting new order, read last inserted order_id from orders table and increment it by 1
            cmd.CommandText = "SELECT MAX(order_id) FROM orders";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int order_id = dr.GetInt32(0) + 1;
            dr.Close();

            // No. of items will be sum of all countLabels
            int items_number = 0;
            foreach (Control control in Controls)
            {
                if (control is Label && control.Name.StartsWith("countLabel_"))
                {
                    items_number += int.Parse(control.Text);
                }
            }

            cmd.CommandText = "INSERT INTO orders VALUES(:order_id, :items_number)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("order_id", OracleDbType.Int32).Value = order_id;
            cmd.Parameters.Add("items_number", OracleDbType.Int32).Value = items_number;
            cmd.ExecuteNonQuery();
            conn.Close();

            // Show a message saying that order has been placed
            MessageBox.Show("Order has been placed");
            this.Close();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }
    }
}
