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
        
        public Time_Table()
        {
            InitializeComponent();
        }
        //variables
        private int maxRoomCap = -1;
        private string className = "";
        private int startTime = 0;
        private int endTime = 24;
        private int currentRoomNo = 1;
        private List<cClassData> classStore = new List<cClassData>();

        public void showInputClass()
        {
            DGVinputData.DataSource = "";
            DGVinputData.DataSource = classStore;
        }
        public void showOutputClass()
        {
            classStore = classStore.OrderBy(o => o.RoomNo).ToList();
            DGVoutputData.DataSource = "";
            DGVoutputData.DataSource = classStore;
        }
        public void sortByEndTime(List <cClassData> pClassStore)
        {

            int i, j;
            cClassData key;

            for(i=1;i<pClassStore.Count;i++)
            {
                key = pClassStore[i];
                j = i - 1;

                while(j>=0&&pClassStore[j].EndTime>key.EndTime)
                {
                    pClassStore[j + 1] = pClassStore[j];
                    j = j - 1;
                }
                pClassStore[j + 1] = key;
            }
            

        }

        public bool allAssigned()
        {
            bool status = false;
            foreach(cClassData x in classStore)
            {
                if (x.RoomNo == "no assign")
                {
                    status = true;
                    break;
                }
            }
            return status;
        }

        public void GenerateOptimalSelectedClass(List<cClassData> pClassStore)
        {
            currentRoomNo = 1;

            //reset all classes incase pre changed
            foreach (cClassData x in classStore)
            {
                    x.RoomNo = "no assign";
            }
            //^^^^reset all classes incase pre changed^^^
            sortByEndTime(pClassStore);

            while (currentRoomNo<=maxRoomCap && allAssigned())
            {
                //select 1st non assigned room after sorting
                foreach (cClassData x in classStore)
                {
                    if (x.RoomNo == "no assign")
                    {
                        x.RoomNo = currentRoomNo.ToString();
                        break;
                    }
                }
                //^^^^select 1st non assigned room after sorting^^^^

                int i,j;
                i = 0;
                for (j = 1; j < pClassStore.Count; j++)
                {
                    //if(pClassStore[j].StartTime > pClassStore[i].EndTime)
                    if (pClassStore[j].StartTime >= pClassStore[i].EndTime && pClassStore[j].RoomNo == "no assign")
                    {
                        pClassStore[j].RoomNo = currentRoomNo.ToString();
                        i = j;
                    }
                }


                currentRoomNo++;
            }            
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNumberofrooms.Text.Trim() != "")
            {
                try
                {
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text.Trim());
                    if (maxRoomCap > 0 && maxRoomCap < 10)
                    {
                        className = TBclassName.Text.Trim();
                        if (className != "")
                        {
                            try
                            {
                                startTime = Convert.ToInt32(CBstartTime.Text.Trim());
                                try
                                {
                                    endTime = Convert.ToInt32(CBendTime.Text.Trim());
                                    if (startTime < endTime)
                                    {
                                        cClassData mydata = new cClassData();//create a object
                                        mydata.ClassName = className;
                                        mydata.StartTime = startTime;
                                        mydata.EndTime = endTime;
                                        //add new data object (new class) in to classStore
                                        classStore.Add(mydata);
                                        //reset GUI data input fields
                                        CBstartTime.Text = "";
                                        CBendTime.Text = "";
                                        TBclassName.Text = "";
                                        className = "";
                                        startTime = 0;
                                        endTime = 24;
                                        //whole data on datagrid view
                                        showInputClass();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Start time must be less than endtime of class", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Select a valid end time for a class", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Select a valid start time for a class", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a class name", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of rooms must be between 0 to 9", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Number of rooms must be numaric values", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter maximum number of rooms available...!!!", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void DGVinputData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(classStore.Count > 0)
            {
                if(e.ColumnIndex==1)        //delete button on DGV
                {
                    classStore.RemoveAt(e.RowIndex);
                    showInputClass();
                }
                else if(e.ColumnIndex==2)   //edit button on DGV
                {
                    TimeTableGenerator.Edit nform = new TimeTableGenerator.Edit(this ,classStore,e.RowIndex);
                    nform.Show();
                }
            }
            else
            {
                MessageBox.Show("nothing to delete or edit", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtNumberofrooms.Text.Trim() != "")
            {
                try
                {
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Number of rooms must be numaric values", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter maximum number of rooms available...!!!", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            GenerateOptimalSelectedClass(classStore);
            showOutputClass();
            //showInputClass();                 //don't remove it
        }

        private void DGVinputData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DGVinputData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void DGVoutputData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DGVoutputData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
    }
}
