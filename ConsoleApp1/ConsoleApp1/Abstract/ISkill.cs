using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    public interface ISkill
    {
        string Name { get; }
        int Damage { get; }
        float Radius { get; }
        void Use(IHero target);
    }

}
