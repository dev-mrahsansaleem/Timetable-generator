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
    public partial class editForm : templateForm
    {
        private List<cClassData> classStore;
        private int rowIndex;

        public editForm()
        {
            InitializeComponent();
        }

        public editForm(List<cClassData> classStore, int rowIndex)
        {
            this.classStore = classStore;
            this.rowIndex = rowIndex;
        }

        private void editForm_Load(object sender, EventArgs e)
        {
            TBclassName.Text = classStore[rowIndex].ClassName;
            CBstartTime.Text = classStore[rowIndex].StartTime.ToString();
            CBendTime.Text = classStore[rowIndex].EndTime.ToString();
        }
    }
}
