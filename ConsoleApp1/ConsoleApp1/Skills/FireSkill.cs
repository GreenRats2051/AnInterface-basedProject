using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Skills
{
    public class FireSkill : BaseSkill, IFireSkill
    {
        public int BurningTime { get; private set; }

        public FireSkill(string name, int damage, float radius, int burningTime, ILogger logger)
            : base(name, damage, radius, logger)
        {
            BurningTime = burningTime;
        }

        public void Use(IHero target)
        {
            base.Use(target);
            _logger.Log($"{Name} will burn {target.Name} for {BurningTime} seconds.", ConsoleColor.Red);
        }
    }

}
