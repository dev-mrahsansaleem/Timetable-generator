using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableGenerator.Template;

namespace TimeTableGenerator
{
    public partial class Time_Table : templateForm
    {
        private int numberOfRooms = 1;
        private string classN = "";
        private int startT = 0;
        private int endT = 24;
        private List<cClassData> classStore = new List<cClassData>();
        public Time_Table()
        {
            InitializeComponent();
        }
        private void CBstartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            startT = System.Convert.ToInt32(CBstartTime.Text);
            if (startT>=endT)
            {
                MessageBox.Show("start time can't be empty", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBendTIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            endT = System.Convert.ToInt32(CBendTIme.Text);
            if (startT>=endT)
            {
                MessageBox.Show("start time can't be empty", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cClassData mydata = new cClassData();
            if(TBclassName.Text.Trim()!="")
            {
                mydata.className = TBclassName.Text;
                mydata.startTime = startT;
                mydata.endTime = endT;
            }
            else
            {
                MessageBox.Show("class name can't be empty", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            classStore.Add(mydata);
        }

        private void btnshowData_Click(object sender, EventArgs e)
        {

        }
    }
}
