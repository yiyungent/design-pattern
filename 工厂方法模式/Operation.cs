using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    abstract class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public abstract double GetResult();
    }
}
