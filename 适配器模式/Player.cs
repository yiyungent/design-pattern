using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式
{
    /// <summary>
    /// 球员
    /// </summary>
    abstract class Player
    {
        protected string name;

        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();

        public abstract void Defense();
    }
}
