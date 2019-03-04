using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 抽象出的状态，所有状态都来实现它
    /// </summary>
    public abstract class State
    {
        /// <summary>
        /// 所有状态都应具有的行为
        /// </summary>
        /// <param name="work"></param>
        public abstract void WriteProgram(Work work);
    }
}
