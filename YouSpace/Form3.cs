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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Read full name, email, username, password and store it in the database
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=password;USER ID=SYSTEM");
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO USERS (USERID, NAME, EMAIL, PASSWORD) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User registered successfully!");
        }
    }
}
