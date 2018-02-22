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
    public partial class user_dialog : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public user_dialog()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public int getId { get; set; }
        public string getUser { get; set; }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) {}
        private void user_dialog_FormClosing(object sender, FormClosingEventArgs e) { }
        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e) { }
        public prof prev = new prof();
        private void user_dialog_Load(object sender, EventArgs e)
        {
            edituser.Text = this.getUser;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string nUser = edituser.Text;
            int uid = this.getId;
            string update_query = "UPDATE personnel SET user = '" + nUser + "' WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand update = new MySqlCommand(update_query, conn);
            update.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Username Updated!");
            this.Close();
        }
    }
}
