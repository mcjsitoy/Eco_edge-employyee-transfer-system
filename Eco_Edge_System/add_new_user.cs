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
    public partial class add_new_user : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public add_new_user()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }

        private void fname_OnValueChanged(object sender, EventArgs e) { }

        private void add_new_user_Load(object sender, EventArgs e)
        {
            
            if (fname.Text == "") { fname.Text = "Firstname"; fname.ForeColor = Color.DimGray;}
            if (lname.Text == "") { lname.Text = "Lastname"; lname.ForeColor = Color.DimGray; }
            if (cnum.Text == "") { cnum.Text = "Contact Number"; cnum.ForeColor = Color.DimGray; }
            if (email.Text == "") { email.Text = "Email Address"; email.ForeColor = Color.DimGray; }
            if (adrs.Text == "") { adrs.Text = "Address"; adrs.ForeColor = Color.DimGray; }
            if (special.Text == "") { special.Text = "Specialization"; special.ForeColor = Color.DimGray; }
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(fname.Text == "" || lname.Text == "" || cnum.Text == "" || email.Text == "" || adrs.Text == "" || special.Text == "")
            {
                MessageBox.Show("fill up all the boxes");
            }
            if (cnum.Text.Length < 11)
            {
                MessageBox.Show("incorrect format of contact number");
            }
            else
            {
                char fl = fname.Text[0];
                string username = fl + lname.Text;
                string password = "p4$$" + cnum.Text;
                string insQuery = "INSERT INTO personnel (`id`, `fname`, `lname`, `bdate`, `status`, `cnum`, `address`, `type`, `user`, `pass`, `specialization`, `email`) VALUES(default, '" + fname.Text + "', '" + lname.Text + "', '" + bdate.Value.ToString("yyyy-MM-dd") + "', 'Avalilable', '" + cnum.Text + "', '" + adrs.Text + "', '" + type.selectedValue.ToString() + "', '" + username + "','" + password + "', '" + special.Text + "', '" + email.Text + "');";
                conn.Open();
                MySqlCommand ins = new MySqlCommand(insQuery, conn);
                ins.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("na add na po");
                this.Close();
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
      }

        private void fname_Enter(object sender, EventArgs e)
        {

            if (fname.Text != "") { fname.ForeColor = Color.Black; }
            if (fname.Text == "Firstname") { fname.Text = ""; }

        }

        private void fname_Load(object sender, EventArgs e)
        {

        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if (fname.Text == "") { fname.Text = "Firstname"; fname.ForeColor = Color.DimGray; }
          
            

        }

        private void lname_Enter(object sender, EventArgs e)
        {

            if (lname.Text != "") { lname.ForeColor = Color.Black; }
            if (lname.Text == "Lastname") { lname.Text = ""; }

        }

        private void lname_Leave(object sender, EventArgs e)
        {
            if (lname.Text == "") { lname.Text = "Lastname"; lname.ForeColor = Color.DimGray; }

        }

        private void cnum_Enter(object sender, EventArgs e)
        {
            if (cnum.Text != "") { cnum.ForeColor = Color.Black; }
            if (cnum.Text == "Contact Number") { cnum.Text = ""; }


        }

        private void cnum_Leave(object sender, EventArgs e)
        {
            if (cnum.Text == "") { cnum.Text = "Contact Number"; cnum.ForeColor = Color.DimGray; }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text != "") { email.ForeColor = Color.Black; }
            if (email.Text == "Email Address") { email.Text = ""; }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "") { email.Text = "Email Address"; email.ForeColor = Color.DimGray; }
        }

        private void adrs_Enter(object sender, EventArgs e)
        {
            if (adrs.Text != "") {adrs.ForeColor = Color.Black; }
            if (adrs.Text == "Address") { adrs.Text = ""; }
        }

        private void adrs_Leave(object sender, EventArgs e)
        {
            if (adrs.Text == "") { adrs.Text = "Address"; adrs.ForeColor = Color.DimGray; }
        }

        private void special_Enter(object sender, EventArgs e)
        {
            if (special.Text != "") { special.ForeColor = Color.Black; }
            if (special.Text == "Specialization") { special.Text = ""; }
        }

        private void special_Leave(object sender, EventArgs e)
        {
            if (special.Text == "") { special.Text = "Specialization"; special.ForeColor = Color.DimGray; }
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
