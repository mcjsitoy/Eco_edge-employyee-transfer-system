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
    public partial class login_form : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public login_form()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root;");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (password.Text == "") { password.Text = "Password"; password.ForeColor = Color.Gray; }
                else if(password.Text != ""){ password.ForeColor = Color.Black; }
            if (username.Text == "") { username.Text = "Username"; username.ForeColor = Color.Gray; }
                else if (username.Text != "") { username.ForeColor = Color.Black; }
        }
       
        private void pictureBox1_Click(object sender, EventArgs e){ }
        private void textBox1_TextChanged(object sender, EventArgs e){ }
        private void login_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            string query = "SELECT * FROM users WHERE username = '" + user + "' AND password ='" + pass + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            if (tbl.Rows.Count == 1)
            {
                Main_menu main = new Main_menu();
                main.getUsername = tbl.Rows[0]["username"].ToString();
                main.getUsertype= tbl.Rows[0]["user_type"].ToString();
                main.getUid = tbl.Rows[0]["user_id"].ToString();
                main.getFname = tbl.Rows[0]["firstname"].ToString();
                main.getLname = tbl.Rows[0]["lastname"].ToString();
                main.prev = this;
                this.Hide();
                setNull();
                main.Show();
            }
            else if(username.ForeColor == Color.Gray || password.ForeColor == Color.Gray)
            {
                MessageBox.Show("You did not enter a username or password!");
            }
            else
            {
                MessageBox.Show("The username or password is incorrect.");
            }
        }
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text != "") { username.ForeColor = Color.Black; }
            if (username.Text == "Username") { username.Text = ""; }
            
        }
        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "") { password.Text = "Password"; password.ForeColor = Color.Gray; password.PasswordChar = '\0'; }
        }
        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "") { username.Text = "Username"; username.ForeColor = Color.Gray;  }
        }
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text != "") { password.ForeColor = Color.Black; password.PasswordChar = '*'; }
            if (password.Text == "Password") { password.Text = ""; }
        }
        public void setNull()
        {
            password.Text = "";
            username.Text = "";
            password.Text = "Password"; password.ForeColor = Color.Gray;
            username.Text = "Username"; username.ForeColor = Color.Gray;
        }
    }
}
