using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂与策略模式结合
{
    class CashReturn : CashSuper
    {
        private double _moneyCondition;

        private double _moneyReturn;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this._moneyCondition = double.Parse(moneyCondition);
            this._moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= this._moneyCondition)
            {
                result = money - Math.Floor(money / this._moneyCondition) * this._moneyReturn;
            }
            return result;
        }
    }
}
