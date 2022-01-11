using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂与策略模式结合
{
    abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
