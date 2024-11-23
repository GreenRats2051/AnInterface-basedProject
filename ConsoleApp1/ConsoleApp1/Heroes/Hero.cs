using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Heroes
{
    public class Hero : IHero
    {
        public string Name { get; private set; }
        public IList<ISkill> Skills { get; private set; }
        private ILogger _logger;

        public Hero(string name, IList<ISkill> skills, ILogger logger)
        {
            Name = name;
            Skills = skills;
            _logger = logger;
        }

        public void Attack(IHero target)
        {
            int totalDamage = 0;
            foreach (var skill in Skills)
            {
                skill.Use(target);
                totalDamage += skill.Damage;
            }
            _logger.Log($"{Name} attacks {target.Name} for {totalDamage} damage.", ConsoleColor.Red);
        }

        public void ReceiveDamage(int damage, IHero attacker)
        {
            _logger.Log($"{Name} receives {damage} damage from {attacker.Name}.", ConsoleColor.Yellow);
        }
    }

}
