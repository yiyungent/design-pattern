using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    public class RoleStateMemento
    {
        /// <summary>
        /// 生命力
        /// </summary>
        private int vit;
        public int Vitality { get => vit; set => vit = value; }

        private int atk;
        public int Attack { get => atk; set => atk = value; }

        private int def;
        public int Defense { get => def; set => def = value; }

        public RoleStateMemento(int vit,int atk,int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }
    }
}
