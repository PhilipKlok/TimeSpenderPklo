using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpender19septPKlok
{
    public partial class Form2 : Form
    {
        Form1 frm = new Form1();
        public Form2(Form1 frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClosePklo_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }
    }
}
