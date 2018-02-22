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
    public partial class add_requirements : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public add_requirements()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public int getId { get; set; }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (bunifuThinButton21.ButtonText == "Add")
            {
                int index = bunifuCustomDataGrid1.CurrentCell.RowIndex;
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
            else if (bunifuThinButton21.ButtonText == "Remove")
            {
                int index = equip.CurrentCell.RowIndex;

                foreach (DataGridViewRow row in equip.SelectedRows)
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
                                equip.Rows.Remove(row);
                                break;
                            }
                        }
                    }
                }
            }
            equip.ClearSelection();
            bunifuCustomDataGrid1.ClearSelection();
        }
        int site_id;
        private void add_requirements_Load(object sender, EventArgs e)
        {
            equip.ClearSelection();
            bunifuCustomDataGrid1.ClearSelection();
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
            string name;
            for (int i = 0; i < siteTbl.Rows.Count; i++)
            {
                name = siteTbl.Rows[i]["site_name"].ToString();
                bunifuDropdown1.AddItem(name);
            }
            bunifuDropdown1.selectedIndex = 0;
            site_id = (Int32)siteTbl.Rows[bunifuDropdown1.selectedIndex]["site_id"];

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(equip.Rows.Count) - 1; i++)
            {
                string insQuery = "INSERT INTO site_requirements (`req_id`, `req_site_id`, `req_equipment_id`, `req_equipment_quant`, `req_personnel_quant`) VALUES (default, " + site_id + ", " + Convert.ToInt32(equip.Rows[i].Cells["equip_id"].Value) + "," + Convert.ToInt32(equip.Rows[i].Cells["equip_quant"].Value) + ");";
                conn.Open();
                MySqlCommand ins1 = new MySqlCommand(insQuery, conn);
                ins1.ExecuteNonQuery();
                conn.Close();
               
            }
            MessageBox.Show("na add na po");
            this.Close();

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void equip_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            bunifuThinButton21.Enabled = true;
            numericUpDown1.Enabled = false;
            bunifuThinButton21.ButtonText = "Remove";
            bunifuThinButton21.ForeColor = Color.Gray;
            bunifuThinButton21.ActiveFillColor = Color.Gray;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.Gray;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.Gray;
            bunifuThinButton21.IdleLineColor = Color.Gray;

        }

        private void bunifuCustomDataGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            equip.ClearSelection();
            bunifuThinButton21.Enabled = true;
            numericUpDown1.Enabled = true;
            bunifuThinButton21.ButtonText = "Add";
            bunifuThinButton21.ForeColor = Color.DeepSkyBlue;
            bunifuThinButton21.ActiveFillColor = Color.DeepSkyBlue;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.DeepSkyBlue;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.DeepSkyBlue;
            bunifuThinButton21.IdleLineColor = Color.DeepSkyBlue;


        }

        private void bunifuCustomDataGrid1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void equip_CellLeave(object sender, DataGridViewCellEventArgs e)
        {     
        }
    }
}
