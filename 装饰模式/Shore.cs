using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Shore:Finery
    {
        public override void Show()
        {
            Console.WriteLine("鞋子");
            base.Show();
            Console.WriteLine("回退鞋子");
        }
    }
}
