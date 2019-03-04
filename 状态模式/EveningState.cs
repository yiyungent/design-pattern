using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 晚间工作状态
    /// </summary>
    public class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                // 若完成任务，则转入下班状态
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲累之极", work.Hour);
                }
                else
                {
                    // 超过21点，转入睡眠工作状态
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }
}
