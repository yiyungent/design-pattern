﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        { }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Company component in children)
            {
                component.Display(depth + 2);
            }
        }

        /// <summary>
        /// 履行职责
        /// </summary>
        public override void LineOfDuty()
        {
            foreach (Company component in children)
            {
                component.LineOfDuty();
            }
        }
    }
}
