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
    public partial class add_services : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Main_menu main = new Main_menu();
        public add_services()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root;");
        }

        private void add_services_Load(object sender, EventArgs e)
        {
            string qwer = "SELECT * FROM services";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(qwer, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            service_grid.DataSource = tbl;
            service_grid.Columns["service_id"].HeaderText = "Code";
            service_grid.Columns["name"].HeaderText = "Service Name";
            service_grid.Columns["price"].HeaderText = "Service Fee";
        }

        string sname, sfee, id;

        private void service_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn1.Text = "Update";
                id = service_grid.Rows[e.RowIndex].Cells["service_id"].Value.ToString();
                sname = name.Text = service_grid.Rows[e.RowIndex].Cells["name"].Value.ToString();
                sfee = price.Text = service_grid.Rows[e.RowIndex].Cells["price"].Value.ToString();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM services;";

            conn.Open();
                MySqlCommand comm = new MySqlCommand(select, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            if(btn1.Text == "Save")
            {
                if (name.Text == "" || price.Text == "")
                {
                    MessageBox.Show("kulang imong info");
                }
                else
                {
                    string insQuery = "INSERT INTO services(name, price) VALUES ('" + name.Text + "' ," + price.Text+");";
                    conn.Open();
                    MySqlCommand ins = new MySqlCommand(insQuery, conn);
                    ins.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("na add na po");
                    loadAll();
                }
            }
            else if(btn1.Text == "Update")
            {
                if (name.Text == "" || price.Text == "")
                {
                    MessageBox.Show("kulang imong info");
                }
                else if (sname == name.Text && sfee == price.Text)
                {
                    MessageBox.Show("no changes saved");
                }
                else
                {
                    string upQuery = "UPDATE services SET name='"+name.Text+"', price ="+price.Text+" WHERE service_id =" + id + ";";
                    conn.Open();
                    MySqlCommand ins = new MySqlCommand(upQuery, conn);
                    ins.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("na update na po");
                    loadAll();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn1.Text = "Save";
            name.Text = "";
            price.Text = "";
        }
        public void loadAll()
        {
            string qwer = "SELECT * FROM services";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(qwer, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            service_grid.DataSource = tbl;
            service_grid.Columns["service_id"].HeaderText = "Code";
            service_grid.Columns["name"].HeaderText = "Service Name";
            service_grid.Columns["price"].HeaderText = "Service Fee";
        }
        private void add_services_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
