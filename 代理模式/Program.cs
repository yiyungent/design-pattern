using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            Proxy daili = new Proxy(jiaojiao);

            daili.GiveChocolate();
            daili.GiveDolls();
            daili.GiveFlowers();

            Console.ReadLine();
        }
    }
}
