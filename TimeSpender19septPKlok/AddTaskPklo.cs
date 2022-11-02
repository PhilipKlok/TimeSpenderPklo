using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpender19septPKlok
{
    class AddTaskPklo
    {
        //properties
        string taskNamePklo = "";
        int taskTimePklo = 0;
        //constructor
        public AddTaskPklo(string c_taskNamePklo, int c_taskTimePklo)
        {
            taskNamePklo = c_taskNamePklo;
            taskTimePklo = c_taskTimePklo;
        }
        //get
        public string GetTaskNamePklo()
        {
            return taskNamePklo;
        }

        public int GetTaskTimePklo()
        {
            return taskTimePklo;
        }
        //set
        public void SetTaskNamePklo(string c_taskNamePklo)
        {
            taskNamePklo = c_taskNamePklo;
        }
        public void SetTaskTimePklo(int c_taskTimePklo)
        {
            taskTimePklo += c_taskTimePklo;
        }
    }
}
