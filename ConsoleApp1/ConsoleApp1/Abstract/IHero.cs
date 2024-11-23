using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    public interface IHero
    {
        string Name { get; }
        IList<ISkill> Skills { get; }
        void Attack(IHero target);
        void ReceiveDamage(int damage, IHero attacker);
    }

}
