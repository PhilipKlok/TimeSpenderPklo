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

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrChangeColorPklo.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }


        // Saves the work you have selected
        private void btnSafeWorkPklo_Click(object sender, EventArgs e)
        {
            // When the combobox is greater or equal to 0 then the richtexhtbox doesn't have to be evaluated
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

        // Click Event for the show button
        private void btnShowPklo_Click(object sender, EventArgs e)
        {
            string allTaskPklo = "";
            // Saves every task with the amount of seconds 
            foreach (var task in listTaskPklo)
            {
                allTaskPklo = allTaskPklo + task.GetTaskNamePklo() + " for " + task.GetTaskTimePklo() + " seconds.\n";
            }
            // Shows all the tasks you have selected and saved
            MessageBox.Show(allTaskPklo);
        }

        // Changing the background of the form
        private void tmrChangeColorPklo_Tick(object sender, EventArgs e)
        {
            if (BackColor == Color.White)
            {
                BackColor = Color.Red;
            }

            else
            {
                BackColor = Color.White;
            }
        }
    }
}
