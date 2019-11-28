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
            //update the record by overwriting on the very index
            classStore[rowIndex].ClassName = TBclassNameNew.Text;
            classStore[rowIndex].StartTime = Convert.ToInt32(CBcStartTimeNew.Text);
            classStore[rowIndex].EndTime = Convert.ToInt32(CBcEndTimeNew.Text);
            time_Table.showInputClass();
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            TBclassNameOld.Text = classStore[rowIndex].ClassName;
            TBclassNameOld.ReadOnly = true;
            TBcStartTimeOld.Text = classStore[rowIndex].StartTime.ToString();
            TBcStartTimeOld.ReadOnly = true;
            TBcEndTimeOld.Text = classStore[rowIndex].EndTime.ToString();
            TBcEndTimeOld.ReadOnly = true;
            //make the previous data read only so that the prevoius data cannot be changed instead updated on the side
        }

        private void TBclassNameOld_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
