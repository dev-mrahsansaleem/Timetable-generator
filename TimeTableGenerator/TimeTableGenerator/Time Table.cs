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
            for (int j= 0; j < pClassStore.Count; j++)
            {
                for (int i = j + 1; i < pClassStore.Count; i++)
                {
                    if (endTime < 0 && endTime < 24)
                    {
                        if (pClassStore[i].EndTime <= pClassStore[i - 1].EndTime)
                        {
                            cClassData temp = pClassStore[i];
                            pClassStore[i] = pClassStore[i - 1];
                            pClassStore[i - 1] = temp;
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalide time", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void GenerateOptimalSelectedClass(List<cClassData> pClassStore)
        {
            currentRoomNo = 1;
            sortByEndTime(pClassStore);
            while(currentRoomNo<=maxRoomCap)
            {
                //select 1st non assigned room after sorting
                foreach (cClassData x in classStore)
                {
                    if (currentRoomNo < 0)
                    {
                        if (x.RoomNo == "no assign")
                        {
                            x.RoomNo = currentRoomNo.ToString();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalide room number", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //^^^^select 1st non assigned room after sorting^^^^

                int i,j;
                i = 0;
                for (j = 1; j < pClassStore.Count; j++)
                {
                    if (startTime < 0 && startTime > 24)
                    {
                        if (pClassStore[j].StartTime >= pClassStore[i].EndTime && pClassStore[j].RoomNo == "no assign")
                        {
                            pClassStore[j].RoomNo = currentRoomNo.ToString();
                            i = j;
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalide time", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                currentRoomNo++;
            }            
        }

        public Time_Table()
        {
            InitializeComponent();
        }
        public void btnInsert_Click(object sender, EventArgs e)
        {
            
                if (classStore.Count >= 0)
                {
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text);//max rooms
                    txtNumberofrooms.ReadOnly = true; //after 1st insertion make readonly can't be change later
                    txtNumberofrooms.BackColor = Color.DimGray;
                    //read data
                    className = TBclassName.Text;
                    startTime = Convert.ToInt32(CBstartTime.Text);
                    endTime = Convert.ToInt32(CBendTime.Text);

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
                    MessageBox.Show("all fields should be filled", "pleas enter the data and then process further", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
       
            {
                if (txtNumberofrooms.Text=)
                {
                    MessageBox.Show("invalid text", "invald", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text);//max rooms
                    if (currentRoomNo < 0 && currentRoomNo > 9)
                    {
                        txtNumberofrooms.ReadOnly = true; //after 1st insertion make readonly can't be change later
                        txtNumberofrooms.BackColor = Color.DimGray;
                        //read data
                        className = TBclassName.Text;
                        startTime = Convert.ToInt32(CBstartTime.Text);
                        endTime = Convert.ToInt32(CBendTime.Text);

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
                        MessageBox.Show("enter valide room no.", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void DGVinputData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(classStore.Count > 0)
            {
                if(e.ColumnIndex==0)        //delete button on DGV
                {
                    classStore.RemoveAt(e.RowIndex);
                    showInputClass();
                }
                else if(e.ColumnIndex==1)   //edit button on DGV
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
            GenerateOptimalSelectedClass(classStore);
            showOutputClass();
        }

        private void txtNumberofrooms_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
