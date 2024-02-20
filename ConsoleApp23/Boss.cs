using System;

namespace ConsoleApp23
{
    class Boss : Enemy
    {
        private float _armor;
        public Boss(float XP, Gun gun, float armor) : base(XP, gun)
        {
            _armor = armor;
        }
        public override void Damage_Enemy(float i)
        {
            if (_armor < i)
            {
                base.Damage_Enemy(i);
            }
            else
            {
                base.Damage_Enemy(i / 2);
            }
        }
        public override void Die()
        {
            base.Die();
        }
    }
}
