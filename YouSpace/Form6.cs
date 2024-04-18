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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YouSpace
{
    public partial class Form6 : Form
    {
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Connect to database and fetch the first tuple data from table playlists
            string oradb = "Data Source=localhost;User Id=SYSTEM;Password=password;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM playlists";
            cmd.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(cmd.CommandText, conn);
            da.Fill(ds, "playlists");
            dt = ds.Tables["playlists"];
            
            dr = dt.Rows[i];
            textBox1.Text = dr["name"].ToString();

            // From table playlist_details, display songs column if the playlist name matches the name in textbox1
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT * FROM playlist_details WHERE name = '" + textBox1.Text + "'";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBox2.Text = dr2["songs"].ToString();
            }
            dr = dt.Rows[i];
            textBox1.Text = dr["name"].ToString();
            
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // displays the next tuple in the database. And repeats in a loop once it reaches the last tuple.
            string oradb = "Data Source=localhost;User Id=SYSTEM;Password=password;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM playlists";
            cmd.CommandType = CommandType.Text;
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["name"].ToString();
            
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Open form5
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open form7
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=SYSTEM;Password=password;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM playlists";
            cmd.CommandType = CommandType.Text;
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox1.Text = dr["name"].ToString();

        }
    }
}
