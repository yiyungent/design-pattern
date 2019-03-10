using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    public class RoleStateCaretaker
    {
        private RoleStateMemento memento;
        public RoleStateMemento Memento { get => memento; set => memento = value; }
    }
}
