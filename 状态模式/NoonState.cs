﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 中午工作状态
    /// </summary>
    class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine("当前时间 {0}点 饿了， 午饭：犯困，午休", work.Hour);
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
