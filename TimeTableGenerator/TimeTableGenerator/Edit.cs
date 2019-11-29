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
    public partial class Edit : templateForm
    {

        private string className = "";
        private int startTime = 0;
        private int endTime = 24;

        private List<cClassData> classStore;
        private int rowIndex;
        private Time_Table time_Table;

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Time_Table time_Table, List<cClassData> classStore, int rowIndex)
        {
            InitializeComponent();
            this.time_Table = time_Table;
            this.classStore = classStore;
            this.rowIndex = rowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            className = TBclassNameNew.Text.Trim();
            if(className!="")
            {
                classStore[rowIndex].ClassName = className;
                try
                {
                    startTime = Convert.ToInt32(CBcStartTimeNew.Text);//start time accepted
                    try
                    {
                        endTime = Convert.ToInt32(CBcEndTimeNew.Text);//end time accepted
                        if (startTime < endTime)
                        {
                            classStore[rowIndex].StartTime = startTime;
                            classStore[rowIndex].EndTime = endTime;
                            //^^^^^^^^^^^^^^^^^valid start and end time
                            time_Table.showInputClass();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Start time must be less than endtime of class", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
=======
            //update the record by overwriting on the very index
            classStore[rowIndex].ClassName = TBclassNameNew.Text;
            classStore[rowIndex].StartTime = Convert.ToInt32(CBcStartTimeNew.Text);
            classStore[rowIndex].EndTime = Convert.ToInt32(CBcEndTimeNew.Text);
            time_Table.showInputClass();
            this.Close();
>>>>>>> 814f6c7b36b0ffb7a3c3c09ef5e2a50437bf21a6
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            TBclassNameOld.Text = classStore[rowIndex].ClassName;
            TBclassNameOld.ReadOnly = true;
            TBcStartTimeOld.Text = classStore[rowIndex].StartTime.ToString();
            TBcStartTimeOld.ReadOnly = true;
            TBcEndTimeOld.Text = classStore[rowIndex].EndTime.ToString();
            TBcEndTimeOld.ReadOnly = true;
<<<<<<< HEAD
=======
            //make the previous data read only so that the prevoius data cannot be changed instead updated on the side
        }

        private void TBclassNameOld_TextChanged(object sender, EventArgs e)
        {

>>>>>>> 814f6c7b36b0ffb7a3c3c09ef5e2a50437bf21a6
        }
    }
}
