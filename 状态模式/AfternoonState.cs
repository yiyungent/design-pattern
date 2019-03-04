using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 下午工作状态
    /// </summary>
    public class AfternoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", work.Hour);
            }
            else
            {
                // 若超过了17点，则将状态移至下一个夜晚
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}
