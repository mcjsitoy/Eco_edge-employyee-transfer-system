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
    public partial class user_management : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Main_menu main = new Main_menu();
        public user_management()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root;");
        }
        private void user_management_Load(object sender, EventArgs e)
        {
            string qwer = "SELECT * FROM users";
            conn.Open();
                MySqlCommand comm = new MySqlCommand(qwer, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            user_grid.DataSource = tbl;
            user_grid.Columns["user_id"].Visible = false;
            user_grid.Columns["gender"].Visible = false;
            user_grid.Columns["user_type"].Visible = false;
            user_grid.Columns["username"].Visible = false;
            user_grid.Columns["password"].Visible = false;
            user_grid.Columns["firstname"].HeaderText = "Firstname";
            user_grid.Columns["lastname"].HeaderText = "Lastname";
        }
        private void user_grid_CellContentClick(object sender, DataGridViewCellEventArgs e){ }

        string uid; string uname; string fn; string ln; string gn; string type; string pwd;  //DateTime bd;  string sts;
        private void user_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn1.Text = "Update";
                uid = user_grid.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
                fn = fname.Text = user_grid.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                ln = lname.Text = user_grid.Rows[e.RowIndex].Cells["lastname"].Value.ToString();

                if ((int)user_grid.Rows[e.RowIndex].Cells["gender"].Value == 0)
                    { gn = gen.Text = "Male"; }
                else if ((int)user_grid.Rows[e.RowIndex].Cells["gender"].Value == 1)
                    { gn = gen.Text = "Female"; }

                if ((int)user_grid.Rows[e.RowIndex].Cells["user_type"].Value == 0)
                    { type = utype.Text = "Operations Manager"; }
                else if ((int)user_grid.Rows[e.RowIndex].Cells["user_type"].Value == 1)
                    { type = utype.Text = "Supervisor"; }
                else if ((int)user_grid.Rows[e.RowIndex].Cells["user_type"].Value == 2)
                    { type = utype.Text = "Laborer"; }

                uname = user.Text = user_grid.Rows[e.RowIndex].Cells["username"].Value.ToString();
                pwd = pass.Text = user_grid.Rows[e.RowIndex].Cells["password"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int gender = 0, usertype = 0;
            string select = "SELECT * FROM users WHERE username = '" + user.Text + "'";

            conn.Open();
                MySqlCommand comm = new MySqlCommand(select, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            if (gen.Text == "Male") { gender = 0; }
                else if (gen.Text == "Female") { gender = 1; }

            if (utype.Text == "Operations Manager") { usertype = 0; }
                else if (utype.Text == "Supervisor") { usertype = 1; }
                    else if (utype.Text == "Laborer") { usertype = 2; }

            if (btn1.Text == "Save")
            {
                if (fname.Text == "" || lname.Text == "" || user.Text == "" || gen.Text == "" || pass.Text == "" || utype.Text == "")
                {
                    MessageBox.Show("kulang imong info");
                }
                else if (tbl.Rows.Count == 1)
                {
                    MessageBox.Show("naa nay ingana na username");
                    user.Text = uname;
                }
                else
                {
                    string insQuery = "INSERT INTO users(firstname, lastname, gender, username, password, user_type) VALUES ('" + fname.Text + "', '" + lname.Text + "', '" + gender + "', '" + user.Text + "', '" + pass.Text + "', " + usertype + ");";
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
                if (fname.Text == "" || lname.Text == "" || user.Text == "" || gen.Text == "" || pass.Text == "" || utype.Text == "")
                {
                    MessageBox.Show("kulang imong info");
                }
                else if (tbl.Rows.Count == 1)
                {
                    if (uname != user.Text)
                    {
                        MessageBox.Show("naa nay ingana na username");
                        user.Text = uname;
                    }
                    else if (uname == user.Text && fn == fname.Text && ln == lname.Text && gn == gen.Text && pwd == pass.Text && type == utype.Text)
                    {
                        MessageBox.Show("no changes saved");
                    }
                    else
                    {
                        string upQuery = "UPDATE users SET firstname ='" + fname.Text + "', lastname = '" + lname.Text + "', gender = " + gender + ", username ='" + user.Text + "', password = '" + pass.Text + "', user_type = " + usertype + " WHERE user_id = '" + uid + "';";
                        conn.Open();
                            MySqlCommand ins = new MySqlCommand(upQuery, conn);
                            ins.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("na update na po");
                        loadAll();
                    }
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
            fname.Text = "";
            lname.Text = "";
            gen.Text = "";
            utype.Text = "";
            user.Text = "";
            pass.Text = "";
        }
        private void loadAll()
        {
            string qwer = "SELECT * FROM users";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(qwer, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            user_grid.DataSource = tbl;
            user_grid.Columns["user_id"].Visible = false;
            user_grid.Columns["gender"].Visible = false;
            user_grid.Columns["user_type"].Visible = false;
            user_grid.Columns["username"].Visible = false;
            user_grid.Columns["password"].Visible = false;
            user_grid.Columns["firstname"].HeaderText = "Firstname";
            user_grid.Columns["lastname"].HeaderText = "Lastname";
        }

        private void user_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
