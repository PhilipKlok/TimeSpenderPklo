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
    public partial class Form1 : Form
    {
        AddTaskPklo addingTasksPklo = null;
        List<AddTaskPklo> listTaskPklo = new List<AddTaskPklo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSafeWorkPklo_Click(object sender, EventArgs e)
        {
            if(cmbActivityPklo.SelectedIndex >= 0) {
                
            }
        }
    }
}
