using System;

namespace GamePolymorphism
{
    public class Hero
    {
        public string? name;
        public int baseDamage;

        public virtual void useSkill()
        {
            Console.WriteLine("NAME = " + name);
            Console.WriteLine("BASE DAMAGE = " + baseDamage);
        }
    }
}