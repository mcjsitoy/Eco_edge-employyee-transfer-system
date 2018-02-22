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
    public partial class Main_menu : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public login_form prev = new login_form();
        public Main_menu()
        {
            
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = accounting_db; Uid = root; Pwd = root;");
        }
        public string getFname { get; set; }
        public string getLname { get; set; }
        public string getUid { get; set; }
        public string getUsername { get; set; }
        public string getUsertype { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            string disp_name = this.getLname + ", " + this.getFname;
            displayName.Text = disp_name;    

            if(this.getUsertype != "0")
            {
                eDITUSERSToolStripMenuItem.Visible = false;
            }
        }
        private void pROFILEToolStripMenuItem_Click(object sender, EventArgs e){ }
        private void label1_Click(object sender, EventArgs e) { }
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            prev.Show();
        }
        private void eDITUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            user_management editUsers = new user_management();
            string uid = this.getUid;
            this.Hide();
            editUsers.main = this;
            editUsers.Show();
           
        }
        private void eDITPROFILEToolStripMenuItem_Click(object sender, EventArgs e){ }
        private void displayName_Click(object sender, EventArgs e){ }
        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_username editUsername = new edit_username();
            string uid = this.getUid;
            editUsername.main = this;
            editUsername.getUid = uid;
            editUsername.Show();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_password editPassword = new edit_password();
            string uid = this.getUid;
            editPassword.main = this;
            editPassword.getUid = uid;
            editPassword.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Management manageCustomer = new Customer_Management();
            this.Hide();
            manageCustomer.main = this;
            manageCustomer.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_services service = new add_services();
            this.Hide();
            service.main = this;
            service.Show();
        }
    }
}
