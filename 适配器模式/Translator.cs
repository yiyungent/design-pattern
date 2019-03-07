using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式
{
    class Translator : Player
    {
        private ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            wjzf.Name = name;
        }

        // 翻译者将 "Attack" 翻译为 "进攻" 告诉外籍中锋
        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
