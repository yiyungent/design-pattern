using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_深复制
{
    class Resume : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private WorkExperience _work;

        public Resume(string name)
        {
            this._name = name;
            this._work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this._work = (WorkExperience)work.Clone();
        }

        /// <summary>
        /// 第三种深复制的辅助
        /// </summary>
        /// <param name="m"></param>
        private Resume(Resume m)
        {
            this._work = (WorkExperience)m._work.Clone();
            this._name = m._name;
            this._sex = m._sex;
            this._age = m._age;
        }

        public void SetPersonInfo(string sex, string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            this._work.WorkDate = workDate;
            this._work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", this._name, this._sex, this._age);
            Console.WriteLine("{0} {1}", this._work.WorkDate, this._work.Company);
        }

        public object Clone()
        {
            #region 第一种方法(书上)
            //Resume r = new Resume(this._work);
            //r._name = this._name;
            //r._sex = this._sex;
            //r._age = this._age;
            #endregion
            #region 第二种方法（自创）
            //Resume r = new Resume(this._name);
            //r._work = (WorkExperience)this._work.Clone();
            //r._name = this._name;
            //r._sex = this._sex;
            //r._age = this._age;
            #endregion

            #region 第三种方法（自创：测试通过）
            Resume r = new Resume(this);
            #endregion
            return r;
        }
    }
}
