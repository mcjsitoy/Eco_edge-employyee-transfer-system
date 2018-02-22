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
    public partial class add_new_site : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public add_new_site()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }


        private void add_new_site_Load(object sender, EventArgs e)
        {
            //BATCH START

            
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

            string queryy = "SELECT * FROM personnel WHERE status = 'Available' ;";
            conn.Open();
            MySqlCommand commm = new MySqlCommand(queryy, conn);
            MySqlDataAdapter adapp = new MySqlDataAdapter(commm);
            conn.Close();
            DataTable tbll = new DataTable();
            adapp.Fill(tbll);

            dataGridView1.DataSource = tbll;
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

            //BATCH END

            equip.ColumnCount = 3;
            equip.Columns[0].Name = "equip_id";
            equip.Columns[1].Name = "equip_name";
            equip.Columns[2].Name = "equip_quant";
            equip.Columns[0].HeaderText = "Id";
            equip.Columns[1].HeaderText = "Item";
            equip.Columns[2].HeaderText = "Quantity";
            equip.Columns["equip_id"].Visible = false;

            string query = "SELECT * FROM equipment;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);

            
            bunifuCustomDataGrid1.DataSource = tbl;
            bunifuCustomDataGrid1.ClearSelection();
            bunifuCustomDataGrid1.Columns["equipment_id"].Visible = false;
            bunifuCustomDataGrid1.Columns["equipment_name"].HeaderText = "Item";
            bunifuCustomDataGrid1.Columns["equipment_quantity"].HeaderText = "Quantity";

            string siteQuery = "SELECT * FROM site;";
            conn.Open();
            MySqlCommand siteComm = new MySqlCommand(siteQuery, conn);
            MySqlDataAdapter siteAdap = new MySqlDataAdapter(siteComm);
            conn.Close();
            DataTable siteTbl = new DataTable();
            siteAdap.Fill(siteTbl);

            if (site_name.Text == "") { site_name.Text = "Site Name"; site_name.ForeColor = Color.DimGray; }
            if (site_class.Text == "") { site_class.Text = "Classification"; site_class.ForeColor = Color.DimGray; }
            if (site_desc.Text == "") { site_desc.Text = "Description"; site_desc.ForeColor = Color.DimGray; }
            if (site_loc.Text == "") { site_loc.Text = "Location"; site_loc.ForeColor = Color.DimGray; }


            string query2 = "SELECT * FROM personnel WHERE type = 'Supervisor';";
            conn.Open();
            MySqlCommand comm2 = new MySqlCommand(query2, conn);
            MySqlDataAdapter adap2 = new MySqlDataAdapter(comm2);
            conn.Close();
            DataTable tbl2 = new DataTable();
            adap2.Fill(tbl2);
            string name;
            for (int i = 0; i < tbl2.Rows.Count; i++)
            {
                name = tbl2.Rows[i]["fname"].ToString() + " " + tbl2.Rows[i]["lname"].ToString();
                site_man.AddItem(name);
            }
            site_man.selectedIndex = 0;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (site_name.Text == "" || site_class.Text == "" || site_desc.Text == "" || site_loc.Text == "")
            {
                MessageBox.Show("fill up all the boxes");
            }
            else
            {
                string query = "SELECT * FROM requirements ORDER BY requirements_id DESC LIMIT 1;";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable tbl = new DataTable();
                adap.Fill(tbl);
                int rid = (Int32)tbl.Rows[0]["requirements_id"];

                string insQuery = "INSERT INTO site (`site_id`, `site_name`, `site_location`, `site_description`, `site_manager`, `site_projectclass` ) VALUES (default, '" + site_name.Text + "', '" + site_loc.Text + "', '" + site_desc.Text + "', '" + site_man.selectedValue + "', '" + site_class.Text + "');";
                conn.Open();
                MySqlCommand ins = new MySqlCommand(insQuery, conn);
                ins.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("na add na po");
                this.Close();
            }
        }

        private void site_name_Enter(object sender, EventArgs e)
        {
            if (site_name.Text != "") { site_name.ForeColor = Color.Black; }
            if (site_name.Text == "Site Name") { site_name.Text = ""; }
        }

        private void site_name_Leave(object sender, EventArgs e)
        {
            if (site_name.Text == "") { site_name.Text = "Site Name"; site_name.ForeColor = Color.Black; }
        }

        private void site_class_Enter(object sender, EventArgs e)
        {
            if (site_class.Text != "") { site_class.ForeColor = Color.Black; }
            if (site_class.Text == "Classification") { site_class.Text = ""; }
        }

        private void site_class_Leave(object sender, EventArgs e)
        {
            if (site_class.Text == "") { site_class.Text = "Classification"; site_class.ForeColor = Color.Black; }
        }

        private void site_desc_Enter(object sender, EventArgs e)
        {
            if (site_desc.Text != "") { site_desc.ForeColor = Color.Black; }
            if (site_desc.Text == "Description") { site_desc.Text = ""; }
        }

        private void site_desc_Leave(object sender, EventArgs e)
        {
            if (site_desc.Text == "") { site_desc.Text = "Description"; site_desc.ForeColor = Color.Black; }
        }

        private void site_loc_Enter(object sender, EventArgs e)
        {
            if (site_loc.Text != "") { site_loc.ForeColor = Color.Black; }
            if (site_loc.Text == "Location") { site_loc.Text = ""; }
        }

        private void site_loc_Leave(object sender, EventArgs e)
        {
            if (site_loc.Text == "") { site_loc.Text = "Location"; site_loc.ForeColor = Color.DimGray; }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            //HERE
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0 || equip.SelectedRows.Count > 0)
            {

                int index = bunifuCustomDataGrid1.CurrentCell.RowIndex;


                if (bunifuThinButton23.ButtonText == "Add")
                {
                    

                    int id = (Int32)bunifuCustomDataGrid1.Rows[index].Cells["equipment_id"].Value;

                    for (int i = 0; i < Convert.ToInt32(equip.Rows.Count); i++)
                    {
                        if (numericUpDown1.Value != 0)
                        {
                            if (equip.Rows[i].Cells["equip_id"].Value != null)
                            {
                                if ((Int32)equip.Rows[i].Cells["equip_id"].Value == id)
                                {
                                    int frstquant = Convert.ToInt32(equip.Rows[i].Cells["equip_quant"].Value);
                                    int scndquant = (Int32)numericUpDown1.Value;
                                    int sum = (frstquant + scndquant);

                                    if (Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value) > 0 && numericUpDown1.Value <= Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value))
                                    {
                                        equip.Rows[i].Cells["equip_quant"].Value = sum;
                                        bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value = (Int32)bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value - numericUpDown1.Value;
                                        numericUpDown1.Value = 0;
                                        break;
                                    }
                                    else if (Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value) == 0)
                                    {
                                        MessageBox.Show("this equipment is out of stock");
                                        numericUpDown1.Value = 0;
                                        break;
                                    }
                                    else if (numericUpDown1.Value > Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value))
                                    {
                                        MessageBox.Show("daghan kaayo ang imong gusto, basaha ang available stock");
                                        numericUpDown1.Value = 0;
                                        break;
                                    }
                                }
                            }
                            else if (equip.Rows[i].Cells["equip_id"].Value != null && (Int32)equip.Rows[i].Cells["equip_id"].Value != id)
                            {
                                if (numericUpDown1.Value > Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value))
                                {
                                    MessageBox.Show("daghan kaayo ang imong gusto, basaha ang available stock");
                                }
                                else if (numericUpDown1.Value <= Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value))
                                {

                                    equip.Rows.Add(bunifuCustomDataGrid1.Rows[index].Cells["equipment_id"].Value, bunifuCustomDataGrid1.Rows[index].Cells["equipment_name"].Value, numericUpDown1.Value);
                                    bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value = (Int32)bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value - numericUpDown1.Value;
                                    numericUpDown1.Value = 0;

                                    break;
                                }
                            }
                            else if (equip.Rows[i].Cells["equip_id"].Value == null)
                            {
                                if (numericUpDown1.Value > Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value))
                                {
                                    MessageBox.Show("daghan kaayo ang imong gusto, basaha ang available stock");
                                }
                                else if (numericUpDown1.Value <= Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value))
                                {

                                    equip.Rows.Add(bunifuCustomDataGrid1.Rows[index].Cells["equipment_id"].Value, bunifuCustomDataGrid1.Rows[index].Cells["equipment_name"].Value, numericUpDown1.Value);
                                    bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value = (Int32)bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value - numericUpDown1.Value;
                                    numericUpDown1.Value = 0;
                                    break;
                                }
                            }
                        }
                        else if (numericUpDown1.Value == 0)
                        {
                            MessageBox.Show("please add some quantity");
                            break;
                        }
                    }
                }
                






                else if (bunifuThinButton23.ButtonText == "Remove")
                {
                     
                     MessageBox.Show("DD: " + index);
                    if (index >= 0)
                     {
                         for (int i = 0; i < Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count); i++)
                         {
                             if (equip.Rows[index].Cells["equip_id"].Value != null)
                             {
                                 if (Convert.ToInt32(equip.Rows[index].Cells["equip_id"].Value) == Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells["equipment_id"].Value))
                                 {
                                     int frstquant = Convert.ToInt32(equip.Rows[index].Cells["equip_quant"].Value);
                                     int scndquant = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells["equipment_quantity"].Value);
                                     int sum = (frstquant + scndquant);
                                     bunifuCustomDataGrid1.Rows[i].Cells["equipment_quantity"].Value = sum;
                                     equip.Rows.RemoveAt(i);
                                     break;
                                 }
                            }
                         }
                     } 
                     /*
                    int index = equip.CurrentCell.RowIndex;
                    int id = (Int32)bunifuCustomDataGrid1.Rows[index].Cells["equipment_id"].Value;
                    int yeah = id;
                    
                    int frstquant = Convert.ToInt32(equip.Rows[index].Cells["equip_quant"].Value);
                    int scndquant = Convert.ToInt32(bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value);
                    int sum = (frstquant + scndquant);
                    bunifuCustomDataGrid1.Rows[index].Cells["equipment_quantity"].Value = sum;
                    equip.Rows.RemoveAt(index);
                    */
                }
                equip.ClearSelection();
                bunifuCustomDataGrid1.ClearSelection();
                //UNTIL HERE
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void bunifuCustomDataGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            equip.ClearSelection();
            bunifuThinButton23.Enabled = true;
            numericUpDown1.Enabled = true;
            bunifuThinButton23.ButtonText = "Add";
            bunifuThinButton23.ForeColor = Color.DeepSkyBlue;
            bunifuThinButton23.ActiveFillColor = Color.DeepSkyBlue;
            bunifuThinButton23.ActiveForecolor = Color.White;
            bunifuThinButton23.ActiveLineColor = Color.DeepSkyBlue;
            bunifuThinButton23.IdleFillColor = Color.White;
            bunifuThinButton23.IdleForecolor = Color.DeepSkyBlue;
            bunifuThinButton23.IdleLineColor = Color.DeepSkyBlue;
        }

        private void equip_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            bunifuThinButton23.Enabled = true;
            numericUpDown1.Enabled = false;
            bunifuThinButton23.ButtonText = "Remove";
            bunifuThinButton23.ForeColor = Color.Gray;
            bunifuThinButton23.ActiveFillColor = Color.Gray;
            bunifuThinButton23.ActiveForecolor = Color.White;
            bunifuThinButton23.ActiveLineColor = Color.Gray;
            bunifuThinButton23.IdleFillColor = Color.White;
            bunifuThinButton23.IdleForecolor = Color.Gray;
            bunifuThinButton23.IdleLineColor = Color.Gray;
        }

        private void equip_tab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuThinButton24.ButtonText = "Add";
        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuThinButton24.ButtonText = "Remove";
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton24.ButtonText == "Add")
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    int id = (Int32)dataGridView1.Rows[index].Cells["id"].Value;



                    MessageBox.Show("hi: " + id );


                    batch.Rows.Add(id, dataGridView1.Rows[index].Cells["fname"].Value, dataGridView1.Rows[index].Cells["lname"].Value, dataGridView1.Rows[index].Cells["specialization"].Value);



                    CurrencyManager currencyManager1 = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[index].Visible = false;
                    currencyManager1.ResumeBinding();

                }




            }
            if (bunifuThinButton24.ButtonText == "Remove")
            {
                

                if (this.batch.SelectedRows.Count > 0)
                {
                    int index = batch.CurrentCell.RowIndex;
                    int id = (Int32)batch.Rows[index].Cells["id"].Value;
                    CurrencyManager currencyManager1 = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    batch.Rows[index].Visible = false;
                    currencyManager1.ResumeBinding();

                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {

                        if (id == (Int32)dataGridView1.Rows[i].Cells["id"].Value)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }

                }

            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void equip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
