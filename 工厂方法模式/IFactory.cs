﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    interface IFactory
    {
        Operation CreateOperation();
    }
}
