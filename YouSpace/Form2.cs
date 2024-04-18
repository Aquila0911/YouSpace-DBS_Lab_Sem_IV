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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write a sql query to check if user entered correct username and password from users table
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=password;USER ID=SYSTEM");
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users where user_id='" + textBox1.Text + "' and password='" + textBox2.Text + "'";    
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }   
            if (count == 1)
            {
                MessageBox.Show("Login Successful");
                Form5 f5 = new Form5();
                f5.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // open form 4
            Form4 f4 = new Form4();
            f4.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
