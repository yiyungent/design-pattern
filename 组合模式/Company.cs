using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        /// <summary>
        /// 履行职责
        ///     不同的部门需要履行不同的职责
        /// </summary>
        public abstract void LineOfDuty();
    }
}
