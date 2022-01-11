using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class TestPaperA:TestPaper
    {
        protected override string Answer1()
        {
            return "9.8";
        }
        protected override string Answer2()
        {
            return "没啥看法";
        }
        protected override string Answer3()
        {
            return "没啥打算";
        }
    }
}
