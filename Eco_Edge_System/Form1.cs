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
    public partial class login : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public login()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ecoedge_db; Uid = root; Pwd = root;");
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            if (password.Text == "") { password.Text = "Password"; password.ForeColor = Color.DimGray;}
            else if (password.Text != "") { password.ForeColor = Color.LightGray; }
            if (username.Text == "") { username.Text = "Username"; username.ForeColor = Color.DimGray; }
            else if (username.Text != "") { username.ForeColor = Color.LightGray; }
        }
        public string getrigger { get; set; }

        private void btn1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            char[] cuser = user.ToCharArray();
            char[] cpass = pass.ToCharArray();
            Boolean u = true;
            Boolean p = true;
            for(int i = 0; i < cuser.Length; i++)
            {
                if(cuser[i] == '\\')
                {
                    u = false;
                }
            }
            for (int i = 0; i < cpass.Length; i++)
            {
                if (cpass[i] == '\\')
                {
                    p = false;
                }
            }

            if(u == true && p == true)
            {
                string query = "SELECT * FROM personnel WHERE user = '" + user + "' AND pass ='" + pass + "';";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable tbl = new DataTable();
                adap.Fill(tbl);

                if (tbl.Rows.Count == 1)
                {
                    main mn = new main();
                    load_dialog ld = new load_dialog();
                    mn.prev = this;
                    ld.ShowDialog(this);
                    mn.getId = (Int32)tbl.Rows[0]["id"];
                    this.Hide();
                    mn.Show();
                }
                else if (username.ForeColor == Color.Gray || password.ForeColor == Color.Gray)
                {
                    MessageBox.Show("You did not enter a username or password!");
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Please dont include a backslash blabla");
            }         
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text != "") { username.ForeColor = Color.LightGray; }
            if (username.Text == "Username") { username.Text = ""; }
        }
        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "") { username.Text = "Username"; username.ForeColor = Color.DimGray; }
            if (checkBox1.Checked) { password.PasswordChar = '\0'; }
                else { password.PasswordChar = '·'; }
        }
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text != "") { password.ForeColor = Color.LightGray; password.PasswordChar = '*'; }
            if (password.Text == "Password") { password.Text = ""; }
            if (checkBox1.Checked) { password.PasswordChar = '\0'; }
                else { password.PasswordChar = '·'; }
        }
        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "") { password.Text = "Password"; password.ForeColor = Color.DimGray; password.PasswordChar = '\0'; }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { password.PasswordChar = '\0'; }
            else { password.PasswordChar = '·'; }
        }
        private void label2_Click(object sender, EventArgs e) { }

    }
}
