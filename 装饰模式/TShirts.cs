﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("T恤");
            base.Show();
            Console.WriteLine("回退TShirt");
        }
    }
}
