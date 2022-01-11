using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式
{
    class Stock1
    {
        public void Buy()
        {
            Console.WriteLine("买入股票1");
        }
        public void Sell()
        {
            Console.WriteLine("卖出股票1");
        }
    }
}
