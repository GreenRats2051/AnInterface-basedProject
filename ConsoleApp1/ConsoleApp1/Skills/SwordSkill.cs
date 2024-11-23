using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Skills
{
    public class SwordSkill : BaseSkill, IAttackSkill
    {
        public int DamageMultiplier { get; private set; }

        public SwordSkill(string name, int damage, float radius, int damageMultiplier, ILogger logger)
            : base(name, damage, radius, logger)
        {
            DamageMultiplier = damageMultiplier;
        }

        public void Use(IHero target)
        {
            int totalDamage = Damage * DamageMultiplier;
            _logger.Log($"{Name} deals {totalDamage} damage to {target.Name}.", ConsoleColor.Green);
            target.ReceiveDamage(totalDamage, null);
        }
    }
}
