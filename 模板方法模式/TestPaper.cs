using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("问题1：加速度是多少?");
            Console.WriteLine("答案：" + Answer1());
        }
        protected virtual string Answer1()
        {
            return "";
        }

        public void TestQuestion2()
        {
            Console.WriteLine("问题2：你对自己的看法？");
            Console.WriteLine("答案：" + Answer2());
        }
        protected virtual string Answer2()
        {
            return "";
        }

        public void TestQuestion3()
        {
            Console.WriteLine("问题3：你对未来的打算?");
            Console.WriteLine("答案：" + Answer3());
        }
        protected virtual string Answer3()
        {
            return "";
        }
    }
}
