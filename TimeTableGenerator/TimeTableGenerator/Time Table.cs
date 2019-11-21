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
        //private int numberOfRooms = 1;
        private string classN = "";
        private int startT = 0;
        private int endT = 24;
        private List<cClassData> classStore = new List<cClassData>();
        private void showAllClass()
        {
            //BindingSource source = new BindingSource();
            //source.DataSource = classStore;
            DGVinputData.DataSource = "";
            DGVinputData.DataSource = classStore;
        }
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
            classN = TBclassName.Text;
            cClassData mydata = new cClassData();
            if(classN!="")
            {
                mydata.ClassName = classN;
                mydata.StartTime = startT;
                mydata.EndTime = endT;
            }
            else
            {
                MessageBox.Show("class name can't be empty", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            classStore.Add(mydata);
            TBclassName.Text = CBendTIme.Text = CBstartTime.Text = "";  //reset data
            showAllClass();
        }

        private void DGVinputData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classStore.RemoveAt(e.RowIndex);
            showAllClass();
        }
    }
}
