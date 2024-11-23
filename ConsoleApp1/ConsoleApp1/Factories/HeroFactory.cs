using ConsoleApp1.Abstract;
using ConsoleApp1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public static class HeroFactory
    {
        public static IHero CreateHero(string name, IList<ISkill> skills, ILogger logger)
        {
            return new Hero(name, skills, logger);
        }
    }

}
