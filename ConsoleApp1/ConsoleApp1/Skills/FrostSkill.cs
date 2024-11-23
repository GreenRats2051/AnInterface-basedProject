using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Skills
{
    public class FrostSkill : BaseSkill, IFrostSkill
    {
        public int Cooldown { get; private set; }

        public FrostSkill(string name, int damage, float radius, int cooldown, ILogger logger)
            : base(name, damage, radius, logger)
        {
            Cooldown = cooldown;
        }

        public void Use(IHero target)
        {
            base.Use(target);
            _logger.Log($"{Name} freezes {target.Name} for {Cooldown} seconds.", ConsoleColor.Cyan);
        }
    }

}
