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
        private string roomNo = "1";
        private List<cClassData> classStore = new List<cClassData>();
        private void showAllClass()
        {
            DGVinputData.DataSource = "";
            DGVinputData.DataSource = classStore;
        }

        private void sortByEndTime(List <cClassData> listofClass)
        {
            for (int j= 0; j < listofClass.Count; j++)
            {
                for (int i = j + 1; i < listofClass.Count; i++)
                {
                    if (listofClass[i].EndTime<=listofClass[i-1].EndTime)
                    {
                        cClassData temp = listofClass[i];
                        listofClass[i] = listofClass[i -1];
                        listofClass[i-1] = temp;
                    }
                }
            }
        }

        private void GenerateOptimalSelectedClass(List<cClassData> allClasses,int n)
        {
            sortByEndTime(allClasses);
            int i, j;
            //first class will always be selected
            i = 0;
            allClasses[i].RoomNo = roomNo;

            for (j = 1; j < n; j++)
            {
                if(allClasses[j].StartTime>=allClasses[i].EndTime)
                {
                    allClasses[j].RoomNo = roomNo;
                    i = j;
                }
            }



            
            
            
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
            if(classStore.Count > 0)
            {
                if(e.ColumnIndex==0)        //delete button on DGV
                {
                    classStore.RemoveAt(e.RowIndex);
                    showAllClass();
                }
                else if(e.ColumnIndex==1)   //edit button on DGV
                { 
                    //showAllClass();
                    //sort(classStore);
                    //showAllClass();
                }
            }
            else
            {
                MessageBox.Show("nothing to delete or edit", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
