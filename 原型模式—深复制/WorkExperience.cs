using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_深复制
{
    class WorkExperience:ICloneable
    {
        private string _workDate;
        public string WorkDate
        {
            get { return _workDate; }
            set { _workDate = value; }
        }

        private string _company;
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
