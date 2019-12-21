using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            classStore = classStore.OrderBy(o => o.RoomNo).ToList();
            DGVinputData.DataSource = "";
            DGVinputData.DataSource = classStore;
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
                if (x.RoomNo == -1)
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
                    x.RoomNo = -1;
            }
            //^^^^reset all classes incase pre changed^^^
            sortByEndTime(pClassStore);

            while (currentRoomNo<=maxRoomCap && allAssigned())
            {
                //select 1st non assigned room after sorting
                foreach (cClassData x in classStore)
                {
                    if (x.RoomNo == -1)
                    {
                        x.RoomNo = currentRoomNo;
                        break;
                    }
                }
                //^^^^select 1st non assigned room after sorting^^^^

                int i,j;
                i = 0;
                for (j = 1; j < pClassStore.Count; j++)
                {
                    //if(pClassStore[j].StartTime > pClassStore[i].EndTime)
                    if (pClassStore[j].StartTime >= pClassStore[i].EndTime && pClassStore[j].RoomNo == -1)
                    {
                        pClassStore[j].RoomNo = currentRoomNo;
                        i = j;
                    }
                }


                currentRoomNo++;
            }            
        }
        // insert button
        public void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNumberofrooms.Text.Trim() != "")                //validating room number
            {
                try
                {
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text.Trim());
                    if (maxRoomCap > 0 && maxRoomCap < 100)
                    {
                        className = TBclassName.Text.Trim();          //validating class name
                        if (className != "")
                        {
                            try
                            {
                                startTime = Convert.ToInt32(CBstartTime.Text.Trim());     //validating start time
                                try
                                {
                                    endTime = Convert.ToInt32(CBendTime.Text.Trim());    
                                    if (startTime < endTime)                             // validating end time
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
                                        MessageBox.Show("Start time must be less than endtime of class", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Select a valid end time for a class", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Select a valid start time for a class", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a class name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of rooms must be between 0 to 9", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Number of rooms must be numaric values", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter maximum number of rooms available...!!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void DGVinputData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(classStore.Count > 0)
            {
                if(e.ColumnIndex==1)        //delete button on DGV
                {
                    classStore.RemoveAt(e.RowIndex);
                    GenerateOptimalSelectedClass(classStore);
                    showInputClass();
                }
                else if(e.ColumnIndex==2)   //edit button on DGV
                {
                    TimeTableGenerator.Edit nform = new TimeTableGenerator.Edit(this ,classStore,e.RowIndex);
                    nform.Show();
                    GenerateOptimalSelectedClass(classStore);
                }
            }
            else
            {
                MessageBox.Show("nothing to delete or edit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtNumberofrooms.Text.Trim() != "")         // validating room number while generationg optimal time table
            {
                try
                {
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text.Trim());
                    GenerateOptimalSelectedClass(classStore);
                    showInputClass();
                }
                catch
                {
                    MessageBox.Show("Number of rooms must be numaric values", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter maximum number of rooms available...!!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DGVinputData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DGVinputData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
        

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            try
            {
                string filename = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Open csv and txt  File";
                //dialog.Filter = "CSV Files (*.txt)|*.txt";
                //dialog.Filter = "CSV Files (*.csv)|*.csv";
                dialog.ShowDialog();
                filename = dialog.FileName;
                TBFileName.Text = filename;
                try
                {
                    StreamReader reader = new StreamReader(File.OpenRead(@filename));
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(',');
                            if (values.Length >= 3)
                            {
                                cClassData myclass = new cClassData();
                                myclass.ClassName = values[0];
                                myclass.StartTime = Convert.ToInt32(values[1]);
                                myclass.EndTime = Convert.ToInt32(values[2]);
                                classStore.Add(myclass);
                            }

                        }

                    }
                    MessageBox.Show("Data Loaded Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showInputClass();
                }
                catch
                {
                    MessageBox.Show("Can't Read or load specified file...!!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Error while opening CSV file...!!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void WriteCSV<T>(IEnumerable<T> items,string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).OrderBy(p => p.Name);
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach(var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (txtNumberofrooms.Text.Trim() != "")         // validating room number while generationg optimal time table
            {
                try
                {
                    string filePath = @"D:\git hub\Timetable-generator C#\Print.csv";
                    maxRoomCap = Convert.ToInt32(txtNumberofrooms.Text.Trim());
                    GenerateOptimalSelectedClass(classStore);
                    showInputClass();

                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }

                    WriteCSV(classStore, filePath);
                    MessageBox.Show(@"D:\git hub\Timetable-generator C#\Print.csv", "File genrated successfuly at:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Number of rooms must be numaric values", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter maximum number of rooms available...!!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
