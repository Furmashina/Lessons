using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz14_inheritance
{
    internal class Task2
    {
        public void Start()
        {
            Warrior warrior = new Warrior();
            FuryWarrior furyWarrior = new FuryWarrior();
            ProtectWarrior protectWarrior = new ProtectWarrior();
            Console.WriteLine(warrior.Attack());
            Console.WriteLine(furyWarrior.Attack());
            Console.WriteLine(protectWarrior.Attack());

            warrior.ProtectHero(100);
            furyWarrior.ProtectHero(100);
            protectWarrior.ProtectHero(100);
        }
    }

    class Warrior
    {
        public string name;

        public virtual double Attack()
        {
            return 70;
        }

        public virtual void ProtectHero(int damage)
        {
            Console.WriteLine("Воин получил "+damage+" урона");
        }
    }

    class FuryWarrior : Warrior
    {
        public override double Attack()
        {
            return 100;
        }

        public virtual void ProtectHero(int damage)
        {
            Console.WriteLine("Воин получил " + damage*1.1 + " урона");
        }
    }

    class ProtectWarrior : Warrior
    {
        public override double Attack()
        {
            return 50;
        }

        public virtual void ProtectHero(int damage)
        {
            Console.WriteLine("Воин получил " + damage * 0.7 + " урона");
        }
    }
}
