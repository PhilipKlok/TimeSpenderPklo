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

        int taskTimePklo = 3;
        bool taskAlreadyInListPklo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSafeWorkPklo_Click(object sender, EventArgs e)
        {
            if (cmbActivityPklo.SelectedIndex >= 0 || rtbActivityPklo.Text != "")
            {
                if (cmbActivityPklo.SelectedIndex >= 0)
                {
                    foreach (var task in listTaskPklo)
                    {
                        if (task.GetTaskNamePklo() == cmbActivityPklo.SelectedIndex.ToString())
                        {
                            task.SetTaskTimePklo(taskTimePklo);
                            taskAlreadyInListPklo = true;
                        }
                    }

                    if (taskAlreadyInListPklo == false)
                    {
                        addingTasksPklo = new AddTaskPklo(cmbActivityPklo.SelectedItem.ToString(), 0);
                        listTaskPklo.Add(addingTasksPklo);
                    }
                }

                else
                {
                    foreach (var task in listTaskPklo)
                    {
                        if (task.GetTaskNamePklo() == rtbActivityPklo.Text)
                        {
                            task.SetTaskTimePklo(taskTimePklo);
                            taskAlreadyInListPklo = true;
                        }
                    }

                    if (taskAlreadyInListPklo == false)
                    {
                        addingTasksPklo = new AddTaskPklo(rtbActivityPklo.Text, 0);
                        listTaskPklo.Add(addingTasksPklo);
                    }
                }
            }

            cmbActivityPklo.SelectedIndex = -1;
            rtbActivityPklo.Text = "";
            taskAlreadyInListPklo = false;

        }

        private void btnShowPklo_Click(object sender, EventArgs e)
        {

            string allTaskPklo = "";
            foreach (var task in listTaskPklo)
            {
                allTaskPklo = allTaskPklo + task.GetTaskNamePklo() + " for " + task.GetTaskTimePklo() + " seconds.\n";
            }
            MessageBox.Show(allTaskPklo);
        }
    }
}
