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
    public partial class create_batch : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public create_batch()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public void loadAll()
        {
           
            
            
            string query = "SELECT * FROM personnel WHERE status = 'Available' ;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            dataGridView1.DataSource = tbl;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["fname"].HeaderText = "Firstname";
            dataGridView1.Columns["lname"].HeaderText = "Lastname";
            dataGridView1.Columns["specialization"].HeaderText = "Specialization";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "Add")
            {
                if (this.dataGridView1.SelectedRows.Count > 0 )
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    int id = (Int32)dataGridView1.Rows[index].Cells["id"].Value;



                    MessageBox.Show("hi: " + id + " " + index);


                    batch.Rows.Add(id, dataGridView1.Rows[index].Cells["fname"].Value, dataGridView1.Rows[index].Cells["lname"].Value, dataGridView1.Rows[index].Cells["specialization"].Value);


                    
                    CurrencyManager currencyManager1 = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[index].Visible = false;
                    currencyManager1.ResumeBinding();

                }
                else
                {
                    MessageBox.Show("Select a row");
                }
                //sitoy//
                
             

               

            }
            if (button1.Text == "Remove")
            {
                int index = batch.CurrentCell.RowIndex;
                int id = (Int32)batch.Rows[index].Cells["id"].Value;
                
                if (this.batch.SelectedRows.Count > 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    batch.Rows[index].Visible = false;
                    currencyManager1.ResumeBinding();
                    
                    for(int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                      
                        if (id == (Int32)dataGridView1.Rows[i].Cells["id"].Value)
                       {
                           dataGridView1.Rows[i].Visible = true;
                       }
                    }

                }
            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            button1.Text = "Add";
        }
        public void ComboBox()
        {
            



            string SQLstringu = "Select  site_id, site_name from site ";
             conn.Open();
             MySqlCommand comm = new MySqlCommand(SQLstringu, conn);
             MySqlDataAdapter adap = new MySqlDataAdapter(comm);

             DataTable tbl = new DataTable();
             adap.Fill(tbl);

             //tbl.Columns.Add("site_id", typeof(string));
            // tbl.Columns.Add("site_name", typeof(string));


             comboBox1.ValueMember = "site_id";
             comboBox1.DisplayMember = "site_name";

             comboBox1.DataSource = tbl;


             conn.Close();

            

        }

        private void create_batch_Load(object sender, EventArgs e)
        {
            ComboBox();
            dataGridView1.ClearSelection();
            batch.ColumnCount = 12;
            batch.Columns[0].Name = "id";
            batch.Columns[1].Name = "fname";
            batch.Columns[2].Name = "lname";
            batch.Columns[3].Name = "specialization";
            batch.Columns[4].Name = "bdate";
            batch.Columns[5].Name = "status";
            batch.Columns[6].Name = "cnum";
            batch.Columns[7].Name = "address";
            batch.Columns[8].Name = "type";
            batch.Columns[9].Name = "user";
            batch.Columns[10].Name = "pass";
            batch.Columns[11].Name = "email";
            
            batch.Columns[0].HeaderText = "ID";
            batch.Columns[1].HeaderText = "Firstname";
            batch.Columns[2].HeaderText = "Lastname";
            batch.Columns[3].HeaderText = "Specialization";

            batch.Columns["id"].Visible = false;
            batch.Columns["bdate"].Visible = false;
            batch.Columns["status"].Visible = false;
            batch.Columns["cnum"].Visible = false;
            batch.Columns["address"].Visible = false;
            batch.Columns["type"].Visible = false;
            batch.Columns["user"].Visible = false;
            batch.Columns["pass"].Visible = false;
            batch.Columns["email"].Visible = false; 

            string query = "SELECT * FROM personnel WHERE status = 'Available' ;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            dataGridView1.DataSource = tbl;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["fname"].HeaderText = "Firstname";
            dataGridView1.Columns["lname"].HeaderText = "Lastname";
            dataGridView1.Columns["specialization"].HeaderText = "Specialization";
            dataGridView1.Columns["bdate"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["cnum"].Visible = false;
            dataGridView1.Columns["address"].Visible = false;
            dataGridView1.Columns["type"].Visible = false;
            dataGridView1.Columns["user"].Visible = false;
            dataGridView1.Columns["pass"].Visible = false;
            dataGridView1.Columns["email"].Visible = false;


            




        }

        private void batch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            button1.Text = "Remove";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();
            MessageBox.Show(ID);

           
        }
    }
}
