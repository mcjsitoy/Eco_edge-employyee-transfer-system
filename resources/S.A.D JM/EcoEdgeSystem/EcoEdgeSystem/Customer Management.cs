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
    public partial class Customer_Management : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Main_menu main = new Main_menu();

        public Customer_Management()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root; Convert Zero Datetime = True; ");
        }

        private void Customer_Management_Load(object sender, EventArgs e)
        {
            string qwer = "SELECT * FROM customers";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(qwer, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            customer_grid.DataSource = tbl;
            customer_grid.Columns["id"].Visible = false;
            customer_grid.Columns["gender"].Visible = false;
            customer_grid.Columns["firstname"].HeaderText = "Firstname";
            customer_grid.Columns["lastname"].HeaderText = "Lastname";
        }

        string uid; string fn; string ln; string gn; DateTime bd;  string cnum;
        private void customer_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn1.Text = "Update";
                uid = customer_grid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                fn = fname.Text = customer_grid.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                ln = lname.Text = customer_grid.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                bd = birthDate.Value = (DateTime) customer_grid.Rows[e.RowIndex].Cells["birthdate"].Value;
                cnum = contactNum.Text = customer_grid.Rows[e.RowIndex].Cells["contact"].Value.ToString();

                if ((int)customer_grid.Rows[e.RowIndex].Cells["gender"].Value == 0)
                { gn = gen.Text = "Male"; }
                else if ((int)customer_grid.Rows[e.RowIndex].Cells["gender"].Value == 1)
                { gn = gen.Text = "Female"; }

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int gender = 0;
            string select = "SELECT * FROM customers;";

            conn.Open();
                MySqlCommand comm = new MySqlCommand(select, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            if (gen.Text == "Male") { gender = 0; }
            else if (gen.Text == "Female") { gender = 1; }

            if (btn1.Text == "Save")
            {
                if (fname.Text == "" || lname.Text == "" || gen.Text == "" || contactNum.Text == "")
                {
                    MessageBox.Show("kulang imong info");
                }
                else if(contactNum.Text.Length < 11 || contactNum.Text.Length > 11)
                {
                    MessageBox.Show("mali imong number dong");
                }
                else
                {
                    string insQuery = "INSERT INTO customers(firstname, lastname, birthdate, gender, contact) VALUES ('" + fname.Text + "', '" + lname.Text + "', '" + birthDate.Value.ToString("yyyy-mm-dd") + "', '" + gender + "', '" + contactNum.Text + "');";
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
                if (fname.Text == "" || lname.Text == "" || gen.Text == "" || contactNum.Text == "")
                {
                    MessageBox.Show("kulang imong info");
                }  
                else if (fn == fname.Text && ln == lname.Text && gn == gen.Text && bd == birthDate.Value && cnum == contactNum.Text)
                {
                    MessageBox.Show("no changes saved");
                }
                else
                {
                    string upQuery = "UPDATE customers SET firstname ='" + fname.Text + "', lastname = '" + lname.Text + "', gender = " + gender + ", birthdate ='" + birthDate.Value.ToString("yyyy-MM-dd") + "', contact = '" + contactNum.Text + "'WHERE id ="+uid+";";
                    conn.Open();
                    MySqlCommand ins = new MySqlCommand(upQuery, conn);
                    ins.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("na update na po");
                    loadAll();
                }
            }
        }
        public void loadAll()
        {
            string qwer = "SELECT * FROM customers";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(qwer, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            customer_grid.DataSource = tbl;
            customer_grid.Columns["id"].Visible = false;
            customer_grid.Columns["gender"].Visible = false;
            customer_grid.Columns["firstname"].HeaderText = "Firstname";
            customer_grid.Columns["lastname"].HeaderText = "Lastname";
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
            birthDate.Text = "";
            contactNum.Text = "";

        }

        private void Customer_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
