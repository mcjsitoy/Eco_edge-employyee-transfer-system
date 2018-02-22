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

namespace Eco_Edge_System
{
    public partial class password_dialog : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public password_dialog()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
   

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int getId { get; set; }
        public string getPass { get; set; }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e) { }
        private void password_dialog_Load(object sender, EventArgs e)
        {
            
            if (bunifuMaterialTextbox1.Text == "") { bunifuMaterialTextbox1.Text = "Current Password"; bunifuMaterialTextbox1.ForeColor = Color.Gray; }
            if (bunifuMaterialTextbox2.Text == "") { bunifuMaterialTextbox2.Text = "New Password"; bunifuMaterialTextbox2.ForeColor = Color.Gray; }
            if (bunifuMaterialTextbox3.Text == "") { bunifuMaterialTextbox3.Text = "Confirm Password"; bunifuMaterialTextbox3.ForeColor = Color.Gray; }
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "") { bunifuMaterialTextbox1.ForeColor = Color.Black; bunifuMaterialTextbox1.isPassword = true; }
            if (bunifuMaterialTextbox1.Text == "Current Password") { bunifuMaterialTextbox1.Text = ""; }
        }
        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "") { bunifuMaterialTextbox1.Text = "Current Password"; bunifuMaterialTextbox1.ForeColor = Color.Gray; bunifuMaterialTextbox1.isPassword = false; }
        }
        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text != "") { bunifuMaterialTextbox2.ForeColor = Color.Black; bunifuMaterialTextbox2.isPassword = true; }
            if (bunifuMaterialTextbox2.Text == "New Password") { bunifuMaterialTextbox2.Text = ""; }
        }
        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "") { bunifuMaterialTextbox2.Text = "New Password"; bunifuMaterialTextbox2.ForeColor = Color.Gray; bunifuMaterialTextbox2.isPassword = false; }
        }
        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text != "") { bunifuMaterialTextbox3.ForeColor = Color.Black; bunifuMaterialTextbox3.isPassword = true; }
            if (bunifuMaterialTextbox3.Text == "Confirm Password") { bunifuMaterialTextbox3.Text = ""; }
        }
        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "") { bunifuMaterialTextbox3.Text = "Confirm Password"; bunifuMaterialTextbox3.ForeColor = Color.Gray; bunifuMaterialTextbox3.isPassword = false; }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string bunifuMaterialTextbox2word = bunifuMaterialTextbox2.Text;
            string bunifuMaterialTextbox1word = bunifuMaterialTextbox1.Text;
            string confirmedPassword = bunifuMaterialTextbox3.Text;
            int uid = this.getId;
            string select_query = "SELECT * FROM personnel WHERE id =" + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(select_query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            if (tbl.Rows[0]["pass"].ToString() != bunifuMaterialTextbox1word)
            {
                MessageBox.Show("Incorrect password! Please enter the correct old password!");
            }
            else if (tbl.Rows[0]["pass"].ToString() == bunifuMaterialTextbox1word)
            {
                if (bunifuMaterialTextbox2word != confirmedPassword)
                {
                    MessageBox.Show("Passwords did not match!");
                }
                else if (bunifuMaterialTextbox2word == confirmedPassword)
                {
                    conn.Open();
                    string update_query = "UPDATE personnel SET pass ='" + bunifuMaterialTextbox2word + "' WHERE id =" + uid + ";";
                    MySqlCommand update = new MySqlCommand(update_query, conn);
                    update.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("password Updated!");
                    this.Close();
                }
            }
        }
    }
}
