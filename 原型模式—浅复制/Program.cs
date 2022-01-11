using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_浅复制
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume r1 = new Resume("大鸟");
            r1.SetPersonInfor("男", "25");
            r1.SetWorkExperience("2012-1234", "A");

            Resume r2 = (Resume)r1.Clone();

            Resume r3 = (Resume)r1.Clone();
            r3.SetPersonInfor("男", "26");

            Resume r4 = (Resume)r1.Clone();
            r4.SetWorkExperience("2012-5678", "B");

            r1.Display();
            r2.Display();
            r3.Display();
            r4.Display();

            Console.ReadLine();
        }
    }
}
