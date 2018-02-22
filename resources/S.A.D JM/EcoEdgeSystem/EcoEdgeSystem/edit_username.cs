using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EcoEdgeSystem
{
    public partial class edit_username : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Main_menu main = new Main_menu();
        public edit_username()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root;");
        }
        public string getUid { get; set; }
        public string getUsername { get; set; }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (newUser.Text == "") { newUser.Text = "Username"; newUser.ForeColor = Color.Gray; }
            string uid = this.getUid;
            string select_query = "SELECT * FROM users WHERE user_id =" + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(select_query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            currentUser.Text = tbl.Rows[0]["username"].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newUsername = newUser.Text;
            string uid = this.getUid;
            string select_query = "SELECT * FROM users WHERE user_id =" + uid + ";";
            string select_check_query = "SELECT * FROM users WHERE user_id !=" + uid + " AND username ='"+ newUsername +"';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(select_query, conn);
                MySqlDataAdapter adap= new MySqlDataAdapter(comm);
            MySqlCommand comm_check = new MySqlCommand(select_check_query, conn);
                MySqlDataAdapter adap_check = new MySqlDataAdapter(comm_check);
            conn.Close();
            DataTable tbl = new DataTable();
            DataTable tbl_check = new DataTable();
            adap.Fill(tbl);
            adap_check.Fill(tbl_check);

            if (newUsername == "")
            {
                MessageBox.Show("Please enter your new username");
            }
            else if(tbl_check.Rows.Count == 1)
            {
                MessageBox.Show("Sorry that username is taken!");
            }
            else
            { 
                if(tbl.Rows[0]["username"].ToString() == newUsername)
                {
                    MessageBox.Show("No Changes made");
                }
                else
                {
                    conn.Open();
                    string update_query = "UPDATE users SET username ='" + newUsername + "' WHERE user_id =" + uid + ";";
                    MySqlCommand update = new MySqlCommand(update_query, conn);
                    update.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Username Updated!");
                    this.Close();
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e){ }
        private void button2_Click_1(object sender, EventArgs e){ this.Close(); }

        private void newUser_Enter(object sender, EventArgs e)
        {
            if (newUser.Text != "") { newUser.ForeColor = Color.Black; }
            if (newUser.Text == "Username") { newUser.Text = ""; }
        }

        private void newUser_Leave(object sender, EventArgs e)
        {
            if (newUser.Text == "") { newUser.Text = "Username"; newUser.ForeColor = Color.Gray; }
        }
    }
}
