using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("考生A");
            TestPaper studentA = new TestPaperA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();
            studentA.TestQuestion3();

            Console.WriteLine();

            Console.WriteLine("考生B");
            TestPaper studentB = new TestPaperB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();
            studentB.TestQuestion3();


            Console.ReadKey();
        }
    }
}
