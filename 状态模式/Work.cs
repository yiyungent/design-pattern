using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    public class Work
    {
        private int hour;

        public int Hour { get => hour; set => hour = value; }

        private bool finish = false;
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }
        public void WriteProgram()
        {
            if (hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", hour);
            }
            else if (hour < 13)
            {
                Console.WriteLine("当前时间 {0}点 饿了， 午饭：犯困，午休", hour);
            }
            else if (hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", hour);
            }
            else
            {
                if (hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲累之极", hour);
                }
                else
                {
                    Console.WriteLine("当前时间：{0}点 不行了，睡着了", hour);
                }
            }
        }
    }
}
