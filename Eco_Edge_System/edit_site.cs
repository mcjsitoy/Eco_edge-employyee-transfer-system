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
    public partial class edit_site : Form
    {

        MySqlConnection conn = new MySqlConnection();
        public edit_site()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public int getId { get; set; }
        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void edit_site_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personnel WHERE type = 'Supervisor';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
           
            string sitequery = "SELECT * FROM site WHERE site_id ="+this.getId+";";
            conn.Open();
            MySqlCommand comm2 = new MySqlCommand(sitequery, conn);
            MySqlDataAdapter adap2 = new MySqlDataAdapter(comm2);
            conn.Close();
            DataTable tbl2 = new DataTable();
            adap2.Fill(tbl2);

            string name;
            int index = 0;
            string sname;
            site_name.Text = tbl2.Rows[0]["site_name"].ToString();
            site_loc.Text = tbl2.Rows[0]["site_location"].ToString();
            site_desc.Text = tbl2.Rows[0]["site_description"].ToString();
            site_class.Text = tbl2.Rows[0]["site_projectclass"].ToString();
            sname = tbl2.Rows[0]["site_manager"].ToString();
            
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                name = tbl.Rows[i]["fname"].ToString() + " " + tbl.Rows[i]["lname"].ToString();
                site_man.AddItem(name);

                if (name == sname)
                {
                    index = i;
                }
            }
            site_man.selectedIndex = index;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (site_name.Text == "" || site_class.Text == "" || site_desc.Text == "" || site_loc.Text == "")
            {
                MessageBox.Show("fill up all the boxes");
            }
            else
            {
                string upQuery = "UPDATE site SET site_name ='" + site_name.Text + "', site_location = '" + site_loc.Text + "', site_description ='" + site_desc.Text + "', site_manager ='" + site_man.selectedValue + "', site_projectclass='" + site_class.Text + "' WHERE site_id =" + this.getId + ";";
                conn.Open();
                MySqlCommand ins3 = new MySqlCommand(upQuery, conn);
                ins3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("na update na po");
                this.Close();

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = "Edit Site";
            pictureBox2.Visible = true;
            site_class.Enabled = true;
            site_desc.Enabled = true;
            site_loc.Enabled = true;
            site_name.Enabled = true;
            site_man.Enabled = true;
        }

        private void site_desc_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("it worked");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Show_add site = new Show_add();
            site.getId = getId;
            site.ShowDialog(this);
        }
    }
}
