﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式
{
    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("前锋 {0} 进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("前锋 {0} 防守", name);
        }
    }
}
