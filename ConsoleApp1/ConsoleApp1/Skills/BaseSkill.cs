using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Skills
{
    public class BaseSkill : ISkill
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public float Radius { get; private set; }
        public ILogger _logger;

        public BaseSkill(string name, int damage, float radius, ILogger logger)
        {
            Name = name;
            Damage = damage;
            Radius = radius;
            _logger = logger;
        }

        public void Use(IHero target)
        {
            _logger.Log($"{Name} is used on {target.Name}.", ConsoleColor.Green);
        }
    }

}
