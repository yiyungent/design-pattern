using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式
{
    class Proxy:IGiveGift
    {
        Pursuit _gg;

        public Proxy(SchoolGirl mm)
        {
            this._gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            _gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            _gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            _gg.GiveFlowers();
        }
    }
}
