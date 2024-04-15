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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if the email matches with the email in the database then update old password to new password also check if confirm passwod is same as new password
            if (textBox2.Text == textBox3.Text)
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=password;USER ID=SYSTEM");
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update users set password = '" + textBox2.Text + "' where email = '" + textBox1.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Updated");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }
    }
}
