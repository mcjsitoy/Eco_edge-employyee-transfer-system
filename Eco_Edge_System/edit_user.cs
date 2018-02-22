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
    public partial class edit_user : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public edit_user()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        public int getId {get; set;}
        string prevfname;
        string prevlname;
        string prevcnum;
        string prevemail;
        string prevaddress;
        string prevspec;
        DateTime prevbdate;
        int prevtype;
        int type = 0, trigger = 0, trigger2 = 0;
        private void edit_user_Load(object sender, EventArgs e)
        {
            
            int uid = this.getId;
            string query = "SELECT * FROM personnel WHERE id = " + uid + ";";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adap = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            bunifuiOSSwitch1.Value = false;
            bunifuiOSSwitch2.Value = false;
            if(tbl.Rows.Count == 1)
            {
                prevfname = fname.Text = tbl.Rows[0]["fname"].ToString();
                prevlname = lname.Text = tbl.Rows[0]["lname"].ToString();
                prevcnum = cnum.Text = tbl.Rows[0]["cnum"].ToString();
                prevemail = email.Text = tbl.Rows[0]["email"].ToString();
                prevaddress = adrs.Text = tbl.Rows[0]["address"].ToString();
                prevspec = special.Text = tbl.Rows[0]["specialization"].ToString();
                prevbdate = bdate.Value = (DateTime)tbl.Rows[0]["bdate"];
                if (tbl.Rows[0]["type"].ToString() == "Admin")
                    prevtype = type = 0;
                else if (tbl.Rows[0]["type"].ToString() == "Operation Manager")
                    prevtype = type = 1;
                else if (tbl.Rows[0]["type"].ToString() == "Supervisor")
                    prevtype = type = 2;
                type1.selectedIndex = type;
            }
           
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            bunifuCustomLabel1.Text = "Edit User";
            fname.Enabled = true;
            lname.Enabled = true;
            cnum.Enabled = true;
            email.Enabled = true;
            adrs.Enabled = true;
            special.Enabled = true;
            bdate.Enabled = true;
            type1.Enabled = true;
            bunifuiOSSwitch1.Enabled = true;
            bunifuiOSSwitch2.Enabled = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (fname.Text == "" || lname.Text == "" || cnum.Text == "" || email.Text == "" || adrs.Text == "" || special.Text == "")
            {
                MessageBox.Show("fill up all the boxes");
            }
            if (cnum.Text.Length < 11)
            {
                MessageBox.Show("incorrect format of contact number");
            }
            else
            {
                if (prevfname == fname.Text && prevlname == lname.Text && prevcnum == cnum.Text && prevemail == email.Text && prevaddress == adrs.Text && prevspec == special.Text && prevbdate == bdate.Value && prevtype == type)
                {
                    if (trigger == 1 || trigger2 == 1)
                    {
                        if (trigger == 1)
                        {
                            char fl = fname.Text[0];
                            string username = fl + lname.Text;
                            string userQuery = "UPDATE personnel SET user='" + username + "' WHERE id =" + this.getId + ";";
                            conn.Open();
                            MySqlCommand ins1 = new MySqlCommand(userQuery, conn);
                            ins1.ExecuteNonQuery();
                            conn.Close();
                        }

                        if (trigger2 == 1)
                        {
                            string password = "p4$$" + cnum.Text;
                            string passQuery = "UPDATE personnel SET pass='" + password + "' WHERE id =" + this.getId + ";";
                            conn.Open();
                            MySqlCommand ins2 = new MySqlCommand(passQuery, conn);
                            ins2.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("na update na po");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No changes made");
                        this.Close();
                    }
                }
                else
                {
                    if (trigger == 1)
                    {
                        char fl = fname.Text[0];
                        string username = fl + lname.Text;
                        string userQuery = "UPDATE personnel SET user='" + username + "' WHERE id =" + this.getId + ";";
                        conn.Open();
                        MySqlCommand ins1 = new MySqlCommand(userQuery, conn);
                        ins1.ExecuteNonQuery();
                        conn.Close();
                    }
                    else if (trigger2 == 1)
                    {
                        string password = "p4$$" + cnum.Text;
                        string passQuery = "UPDATE personnel SET pass='" + password + "' WHERE id =" + this.getId + ";";
                        conn.Open();
                        MySqlCommand ins2 = new MySqlCommand(passQuery, conn);
                        ins2.ExecuteNonQuery();
                        conn.Close();
                    }

                    string upQuery = "UPDATE personnel SET fname = '" + fname.Text + "', lname ='" + lname.Text + "', cnum ='" + cnum.Text + "', email ='" + email.Text + "', address='" + adrs.Text + "', specialization='" + special.Text + "', bdate='" + bdate.Value.ToString("yyyy-MM-dd") + "', type='" + type1.selectedValue.ToString() + "' WHERE id =" + this.getId + ";";
                    conn.Open();
                    MySqlCommand ins3 = new MySqlCommand(upQuery, conn);
                    ins3.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("na update na po");
                    this.Close();
                }
            }
        }

        private void cnum_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bdate_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch2.Value == true)
            {
                trigger2 = 1;
            }
            else
            {
                trigger2 = 0;
            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if(bunifuiOSSwitch1.Value == true)
            {
                trigger = 1;
            }
            else
            {
                trigger = 0;
            }
        }
    }
}
