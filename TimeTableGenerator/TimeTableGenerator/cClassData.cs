using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableGenerator
{
    public class cClassData
    {
        private string className;
        private int startTime;
        private int endTime;
        private string roomNo;
        public cClassData()
        {
            ClassName = "";
            startTime = 0;
            endTime = 0;
            roomNo = "no assign";
        }

        public string ClassName
        {
            get
            {
                return className;
            }

            set
            {
                className = value;
            }
        }

        public int StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public int EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }
    }
}
