using System;

namespace ConsoleApp23
{
    public class Enemy
    {
        protected float _XP { get; set; }
        Gun _gun;
        public Enemy(float XP, Gun gun)
        {
            _gun = gun;
            _XP = XP;
        }
        public virtual void Damage_Enemy(float i)
        {
            if (_XP - i <= 0)
            {
                _XP = 0;
                Die();
            }
            else
            {
                _XP = -i;
            }
        }
        public virtual void Die()
        {
            Console.WriteLine($"ты умер : \nXP: {_XP} ");
        }
    }
}
