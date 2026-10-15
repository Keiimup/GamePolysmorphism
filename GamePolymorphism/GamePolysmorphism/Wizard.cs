using System;

namespace GamePolymorphism
{
    public class Wizard : Hero
    {
        public int bonusMagic;

        public override void useSkill()
        {
            base.useSkill();
            Console.WriteLine("BONUS MAGIC = " + bonusMagic);
        }
    }
}