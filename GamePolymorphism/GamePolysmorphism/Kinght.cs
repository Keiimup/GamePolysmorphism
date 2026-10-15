using System;

namespace GamePolymorphism
{
    public class Knight : Hero
    {
        public int bonusArmor;

        public override void useSkill()
        {
            base.useSkill();
            Console.WriteLine("BONUS ARMOR = " + bonusArmor);
        }
    }
}