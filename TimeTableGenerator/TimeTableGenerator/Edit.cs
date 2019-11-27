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
            classStore[rowIndex].ClassName = TBclassNameNew.Text;
            classStore[rowIndex].StartTime = Convert.ToInt32(CBcStartTimeNew.Text);
            classStore[rowIndex].EndTime = Convert.ToInt32(CBcEndTimeNew.Text);
            time_Table.showInputClass();
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            TBclassNameOld.Text = classStore[rowIndex].ClassName;
            TBcStartTimeOld.Text = classStore[rowIndex].StartTime.ToString();
            TBcEndTimeOld.Text = classStore[rowIndex].EndTime.ToString();
        }
    }
}
