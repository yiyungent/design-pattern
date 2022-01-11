using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            TShirts t = new TShirts();
            Cap c = new Cap();
            Shore s = new Shore();

            Person p = new Person("小菜");

            t.Decorate(c);// T恤
            c.Decorate(s);// 礼帽
            s.Decorate(p);//  鞋子

            t.Show();// T恤  礼帽  鞋子 装扮的是小菜


            Console.ReadLine();
        }
    }
}
