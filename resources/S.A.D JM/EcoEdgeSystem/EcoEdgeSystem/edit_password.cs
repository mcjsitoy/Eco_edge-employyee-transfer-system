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
    public partial class edit_password : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Main_menu main = new Main_menu();
        public edit_password()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root;");
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            if (oldPass.Text == "") { oldPass.Text = "Old Password"; oldPass.ForeColor = Color.Gray; }
            if (newPass.Text == "") { newPass.Text = "New Password"; newPass.ForeColor = Color.Gray; }
            if (confirmedPass.Text == "") { confirmedPass.Text = "Confirm Password"; confirmedPass.ForeColor = Color.Gray; }
        }
        public string getUid { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = newPass.Text;
            string oldPassword = oldPass.Text;
            string confirmedPassword = confirmedPass.Text;
            string uid = this.getUid;
            string select_query = "SELECT * FROM users WHERE user_id =" + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(select_query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            if (tbl.Rows[0]["password"].ToString() != oldPassword)
            {
                MessageBox.Show("Incorrect password! Please enter the correct old password!");
            }
            else if(tbl.Rows[0]["password"].ToString() == oldPassword)
            {
                if(newPassword != confirmedPassword)
                {
                    MessageBox.Show("Passwords did not match!");
                }
                else if(newPassword == confirmedPassword)
                {
                    conn.Open();
                    string update_query = "UPDATE users SET password ='" + newPassword + "' WHERE user_id =" + uid + ";";
                    MySqlCommand update = new MySqlCommand(update_query, conn);
                    update.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("password Updated!");
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e){ this.Close(); }
        private void oldPass_TextChanged(object sender, EventArgs e){ }
        private void oldPass_Enter(object sender, EventArgs e)
        {
            if (oldPass.Text != "") { oldPass.ForeColor = Color.Black; oldPass.PasswordChar = '*'; }
            if (oldPass.Text == "Old Password") { oldPass.Text = ""; }
        }
        private void oldPass_Leave_1(object sender, EventArgs e)
        {
            if (oldPass.Text == "") { oldPass.Text = "Old Password"; oldPass.ForeColor = Color.Gray; oldPass.PasswordChar = '\0'; }
        }
        private void newPass_Enter(object sender, EventArgs e)
        {
            if (newPass.Text != "") { newPass.ForeColor = Color.Black; newPass.PasswordChar = '*';  }
            if (newPass.Text == "New Password") { newPass.Text = ""; }
        }
        private void newPass_Leave(object sender, EventArgs e)
        {
            if (newPass.Text == "") { newPass.Text = "New Password"; newPass.ForeColor = Color.Gray; newPass.PasswordChar = '\0'; }
        }
        private void confirmedPass_Enter(object sender, EventArgs e)
        {
            if (confirmedPass.Text != "") { confirmedPass.ForeColor = Color.Black; confirmedPass.PasswordChar = '*'; }
            if (confirmedPass.Text == "Confirm Password") { confirmedPass.Text = ""; }
        }
        private void confirmedPass_Leave(object sender, EventArgs e)
        {
            if (confirmedPass.Text == "") { confirmedPass.Text = "Confirm Password"; confirmedPass.ForeColor = Color.Gray; confirmedPass.PasswordChar = '\0'; }
        }
    }
}
