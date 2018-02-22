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
    public partial class prof : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public prof()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public int getId { get; set; }
        int uid;
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void prof_Load(object sender, EventArgs e)
        {
            uid = this.getId;
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            bunifuCustomLabel1.Text = tbl.Rows[0]["fname"].ToString() + " " + tbl.Rows[0]["lname"].ToString();
            bunifuCustomLabel2.Text = tbl.Rows[0]["email"].ToString();
            bunifuCustomLabel3.Text = tbl.Rows[0]["cnum"].ToString();
            bunifuCustomLabel4.Text = tbl.Rows[0]["bdate"].ToString();
            bunifuCustomLabel5.Text = tbl.Rows[0]["type"].ToString();
            bunifuCustomLabel6.Text = tbl.Rows[0]["user"].ToString();
            bunifuCustomLabel7.Text = tbl.Rows[0]["pass"].ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            user_dialog ud = new user_dialog();
            ud.getId = this.getId;
            ud.getUser = tbl.Rows[0]["user"].ToString();
            ud.ShowDialog(this);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            password_dialog pd = new password_dialog();
            pd.getId = this.getId;
            pd.getPass = tbl.Rows[0]["pass"].ToString();
            pd.ShowDialog(this);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            bunifuCustomLabel1.Text = tbl.Rows[0]["fname"].ToString() + " " + tbl.Rows[0]["lname"].ToString();
            bunifuCustomLabel2.Text = tbl.Rows[0]["email"].ToString();
            bunifuCustomLabel3.Text = tbl.Rows[0]["cnum"].ToString();
            bunifuCustomLabel4.Text = tbl.Rows[0]["bdate"].ToString();
            bunifuCustomLabel5.Text = tbl.Rows[0]["type"].ToString();
            bunifuCustomLabel6.Text = tbl.Rows[0]["user"].ToString();
            bunifuCustomLabel7.Text = tbl.Rows[0]["pass"].ToString();
        }
    }
}
