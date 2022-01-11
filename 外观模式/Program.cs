using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund f = new Fund();
            f.BuyFund();
            Thread.Sleep(2000);
            f.SellFund();


            Console.ReadLine();
        }
    }
}
