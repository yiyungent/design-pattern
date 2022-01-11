using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式
{
    class Pursuit : IGiveGift
    {
        SchoolGirl _mm;

        public Pursuit(SchoolGirl mm)
        {
            this._mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(_mm.Name + "送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_mm.Name + "送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(_mm.Name + "送你巧克力");
        }
    }
}
