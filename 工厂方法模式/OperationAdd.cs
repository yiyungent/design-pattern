using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    class OperationAdd:Operation
    {
        public override double GetResult()
        {
            return this.NumberA + this.NumberB;
        }
    }
}
