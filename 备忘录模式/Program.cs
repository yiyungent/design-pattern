using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            // 大战 Boss 前
            GameRole lixiaoyao = new GameRole();
            // 大战 Boss 前，获得初始角色状态
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            // 保存进度
            //GameRole backup = new GameRole();
            //backup.Vitality = lixiaoyao.Vitality;
            //backup.Attack = lixiaoyao.Attack;
            //backup.Defense = lixiaoyao.Defense;
            RoleStateCaretaker roleStateCaretaker = new RoleStateCaretaker();
            // 保存进度时，由于封装在 Memento 中，因此我们并不知道保存了哪些具体的角色数据
            roleStateCaretaker.Memento = lixiaoyao.SaveState();

            // 大战 Boss 时，损耗严重 
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            // 恢复之前的状态
            //lixiaoyao.Vitality = backup.Vitality;
            //lixiaoyao.Attack = backup.Attack;
            //lixiaoyao.Defense = backup.Defense;
            lixiaoyao.RecoveryState(roleStateCaretaker.Memento);
            lixiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
