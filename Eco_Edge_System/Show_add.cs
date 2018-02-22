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
    public partial class Show_add : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Show_add()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public int getId { get; set; }

        private void Show_add_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM site WHERE site_id =" + this.getId + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl2 = new DataTable();
            adap.Fill(tbl2);

            
            addr.Text = tbl2.Rows[0]["site_description"].ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
