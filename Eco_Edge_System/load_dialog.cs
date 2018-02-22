using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Edge_System
{
    public partial class load_dialog : Form
    {
        public Form lg = new Form();

        public load_dialog()
        {
            InitializeComponent();
        }
        public string getFname { get; set; }
        public string getEmail { get; set; }
        public string getNum { get; set; }
        public string getBdate { get; set; }
        public string getType { get; set; }
        public string getUser { get; set; }
        public string getPass { get; set; }

        main mn = new main();
        private void timer1_Tick(object sender, EventArgs e)
        { 
            lg.Hide();
            this.Close();
        }

        private void load_dialog_Load(object sender, EventArgs e)
        {
            
        }

        private void load1_Load(object sender, EventArgs e)
        {

        }
    }
}
