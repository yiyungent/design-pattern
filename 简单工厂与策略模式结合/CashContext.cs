using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂与策略模式结合
{
    class CashContext
    {
        private CashSuper _cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    this._cs = new CashNormal();
                    break;
                case "满300返100":
                    this._cs = new CashReturn("300", "100");
                    break;
                case "打八折":
                    this._cs = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return this._cs.AcceptCash(money);
        }
    }
}
