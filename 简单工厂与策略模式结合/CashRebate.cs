using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂与策略模式结合
{
    class CashRebate:CashSuper
    {
        private double _moneyRebate;

        public override double AcceptCash(double money)
        {
            return money * this._moneyRebate;
        }

        public CashRebate(string moneyRebate)
        {
            this._moneyRebate = Convert.ToDouble(moneyRebate);
        }
    }
}
