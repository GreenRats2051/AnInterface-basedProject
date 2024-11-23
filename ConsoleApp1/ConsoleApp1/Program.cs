using ConsoleApp1.Abstract;
using ConsoleApp1.Factories;
using ConsoleApp1.Loggers;
using ConsoleApp1.Skills;

ILogger logger = new ConsoleLogger();

var skills = new List<ISkill>
        {
            new SwordSkill("Sword Slash", 10, 1.5f, 2, logger),
            new FireSkill("Fireball", 15, 2.0f, 5, logger),
            new FrostSkill("Frostbite", 12, 1.0f, 3, logger)
        };

IHero hero1 = HeroFactory.CreateHero("Hero1", skills, logger);
IHero hero2 = HeroFactory.CreateHero("Hero2", skills, logger);

hero1.Attack(hero2);
hero2.Attack(hero1);