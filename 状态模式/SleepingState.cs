using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 睡眠状态
    /// </summary>
    public class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间：{0}点 不行了，睡着了", work.Hour);
        }
    }
}
