using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operFactory = new MulOperation();// new SubFactory();//new AddFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 10;
            oper.NumberB = 20;
            double result = oper.GetResult();

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
