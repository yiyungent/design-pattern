using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "9.84344";
        }
        protected override string Answer2()
        {
            return "非常不错";
        }
        protected override string Answer3()
        {
            return "有长远计划";
        }
    }
}
