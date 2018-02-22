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
    public partial class main : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Form prev = new Form();
        public main()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public int getId { get; set; }
       
        private void main_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            panel3.Hide();
            panel6.Hide();
            int uid = this.getId;
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            name.Text = tbl.Rows[0]["fname"].ToString() + " " + tbl.Rows[0]["lname"].ToString(); 
            email.Text = tbl.Rows[0]["email"].ToString(); ;
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            prev.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int uid = this.getId;
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            prof pf = new prof();
            pf.getId = (Int32)tbl.Rows[0]["id"]; 
            pf.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel4.Hide();
            panel7.Hide();
            panel3.Show();
            string query = "SELECT * FROM personnel;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            bunifuCustomDataGrid1.ClearSelection();
            bunifuCustomDataGrid1.DataSource = tbl;
            bunifuCustomDataGrid1.Columns["id"].Visible = false;
            bunifuCustomDataGrid1.Columns["address"].Visible = false;
            bunifuCustomDataGrid1.Columns["user"].Visible = false;
            bunifuCustomDataGrid1.Columns["pass"].Visible = false;
            bunifuCustomDataGrid1.Columns["email"].Visible = false;
            bunifuCustomDataGrid1.Columns["bdate"].Visible = false;
            bunifuCustomDataGrid1.Columns["cnum"].Visible = false;
            bunifuCustomDataGrid1.Columns["fname"].HeaderText = "Firstname ";
            bunifuCustomDataGrid1.Columns["lname"].HeaderText = "Lastname ";
            bunifuCustomDataGrid1.Columns["status"].HeaderText = "Status ";
            bunifuCustomDataGrid1.Columns["type"].HeaderText = "Type ";
            bunifuCustomDataGrid1.Columns["specialization"].HeaderText = "Specialization ";

        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Hide();
            panel7.Hide();
            panel6.Show();
            string query = "SELECT * FROM site;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            
            bunifuCustomDataGrid3.ClearSelection();
            bunifuCustomDataGrid3.DataSource = tbl;
            bunifuCustomDataGrid3.Columns["site_id"].Visible = false;
            bunifuCustomDataGrid3.Columns["site_name"].Visible = true;
            bunifuCustomDataGrid3.Columns["site_location"].Visible = true;
            bunifuCustomDataGrid3.Columns["site_description"].Visible = true;
            bunifuCustomDataGrid3.Columns["site_manager"].Visible = true;
            bunifuCustomDataGrid3.Columns["site_projectclass"].Visible = true;
            
            bunifuCustomDataGrid3.Columns["site_id"].HeaderText = "Id ";
            bunifuCustomDataGrid3.Columns["site_name"].HeaderText = "Name ";
            bunifuCustomDataGrid3.Columns["site_location"].HeaderText = "Location ";
            bunifuCustomDataGrid3.Columns["site_description"].HeaderText = "Description ";
            bunifuCustomDataGrid3.Columns["site_manager"].HeaderText = "Site Manager ";
            bunifuCustomDataGrid3.Columns["site_projectclass"].HeaderText = "Project Class ";
            
            
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            add_new_user adn = new add_new_user();
            adn.ShowDialog(this);

            string query = "SELECT * FROM personnel;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            bunifuCustomDataGrid1.DataSource = tbl;
            loadAll();
            bunifuCustomDataGrid1.Refresh();
            bunifuCustomDataGrid1.Update();

        }
        private void bunifuCustomDataGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                edit_user eu = new edit_user();
                int id = (Int32)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["id"].Value;
                eu.getId = id;
                eu.ShowDialog(this);

                string query = "SELECT * FROM personnel;";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable tbl = new DataTable();
                adap.Fill(tbl);

                bunifuCustomDataGrid1.DataSource = tbl;
                loadAll();
                bunifuCustomDataGrid1.Refresh();
                bunifuCustomDataGrid1.Update();
            }
           
        }
        public void loadAll()
        {
            string query = "SELECT * FROM personnel;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            bunifuCustomDataGrid2.ClearSelection();
            bunifuCustomDataGrid2.DataSource = tbl;
            bunifuCustomDataGrid2.Columns["id"].Visible = false;
            bunifuCustomDataGrid2.Columns["address"].Visible = false;
            bunifuCustomDataGrid2.Columns["user"].Visible = false;
            bunifuCustomDataGrid2.Columns["pass"].Visible = false;
            bunifuCustomDataGrid2.Columns["email"].Visible = false;
            bunifuCustomDataGrid2.Columns["bdate"].Visible = false;
            bunifuCustomDataGrid2.Columns["cnum"].Visible = false;
            bunifuCustomDataGrid2.Columns["fname"].HeaderText = "Firstname ";
            bunifuCustomDataGrid2.Columns["lname"].HeaderText = "Lastname ";
            bunifuCustomDataGrid2.Columns["status"].HeaderText = "Status ";
            bunifuCustomDataGrid2.Columns["type"].HeaderText = "Type ";
            bunifuCustomDataGrid2.Columns["specialization"].HeaderText = "Specialization ";
        }

        

        private void bunifuCustomDataGrid3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit_site site = new edit_site();
                int id = (Int32)bunifuCustomDataGrid3.Rows[e.RowIndex].Cells["site_id"].Value;
                site.getId = id;
                site.ShowDialog(this);

                string query = "SELECT * FROM site;";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable tbl = new DataTable();
                adap.Fill(tbl);

                bunifuCustomDataGrid3.DataSource = tbl;
                loadAll();
                bunifuCustomDataGrid1.Refresh();
                bunifuCustomDataGrid1.Update();

            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

            add_new_site site = new add_new_site();
            site.ShowDialog(this);

            string query = "SELECT * FROM site;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            bunifuCustomDataGrid3.DataSource = tbl;
            loadAll();
            bunifuCustomDataGrid1.Refresh();
            bunifuCustomDataGrid1.Update();
        }
        // add floor area in site info
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Hide();
            panel6.Hide();
            panel7.Show();
            create_batch cb = new create_batch();
            cb.Show();


        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            add_requirements ar = new add_requirements();
            ar.ShowDialog(this);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void bunifuCustomDataGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
