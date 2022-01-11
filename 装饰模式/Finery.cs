using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Finery : Person
    {
        protected Person _component;

        public void Decorate(Person component)
        {
            this._component = component;
        }

        public override void Show()
        {
            if (_component != null)
            {
                _component.Show();
                Console.WriteLine("回退Finery");
            }
        }
    }
}
