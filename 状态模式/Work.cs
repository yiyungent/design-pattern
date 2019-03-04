using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    public class Work
    {
        #region 状态模式
        private State current;
        public Work()
        {
            // 工作初始化为上午工作状态，即上午9点开始上班
            current = new ForenoonState();
        }

        private double hour;
        /// <summary>
        /// 钟点，状态转换的凭据
        /// </summary>
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;
        /// <summary>
        /// 任务完成属性，是否能下班的依据
        /// </summary>
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State state)
        {
            current = state;
        }

        public void WriteProgram()
        {
            // 调用当前状态的写程序方法
            current.WriteProgram(this);
        }
        #endregion

        #region 旧版
        //private int hour;

        //public int Hour { get => hour; set => hour = value; }

        //private bool finish = false;
        //public bool TaskFinished
        //{
        //    get { return finish; }
        //    set { finish = value; }
        //}
        //public void WriteProgram()
        //{
        //    if (hour < 12)
        //    {
        //        Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", hour);
        //    }
        //    else if (hour < 13)
        //    {
        //        Console.WriteLine("当前时间 {0}点 饿了， 午饭：犯困，午休", hour);
        //    }
        //    else if (hour < 17)
        //    {
        //        Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", hour);
        //    }
        //    else
        //    {
        //        if (hour < 21)
        //        {
        //            Console.WriteLine("当前时间：{0}点 加班哦，疲累之极", hour);
        //        }
        //        else
        //        {
        //            Console.WriteLine("当前时间：{0}点 不行了，睡着了", hour);
        //        }
        //    }
        //}
        #endregion
    }
}
