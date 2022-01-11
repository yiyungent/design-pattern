using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_深复制
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume r1 = new Resume("大鸟");
            r1.SetPersonInfo("男", "29");
            r1.SetWorkExperience("123", "A");

            Resume r2 = (Resume)r1.Clone();

            Resume r3 = (Resume)r1.Clone();
            r3.SetPersonInfo("女", "30");

            Resume r4 = (Resume)r1.Clone();
            r4.SetWorkExperience("456", "B");

            r1.Display();
            r2.Display();
            r3.Display();
            r4.Display();

            #region 方法1的结果
            //            &r1._work
            //0x0000000004d22db8
            //    * &r1._work: 0x0000000004d22dc8
            //            &r2._work
            //0x0000000004d22e08
            //    * &r2._work: 0x0000000004d22e18

            //            &r1._age
            //0x0000000004d22db0
            //    * &r1._age: 0x0000000004d22cb8
            //            &r2._age
            //0x0000000004d22e00
            //    * &r2._age: 0x0000000004d22cb8
            //            &r3._age
            //0x0000000004d22e50
            //    * &r3._age: 0x0000000004d22d38
            #endregion

            #region 方法3的结果
            //            &r1._work
            //0x0000000004f92db8
            //    * &r1._work: 0x0000000004f92dc8
            //            &r2._work
            //0x0000000004f92e08
            //    * &r2._work: 0x0000000004f92e18

            //            &r1._age
            //0x0000000004f92db0
            //    * &r1._age: 0x0000000004f92cb8
            //            &r2._age
            //0x0000000004f92e00
            //    * &r2._age: 0x0000000004f92cb8
            //            &r3._age
            //0x0000000004ef2e50
            //    * &r3._age: 0x0000000004ef2d38
            #endregion
            Console.ReadLine();
        }
    }
}
