namespace ConsoleApp23
{
    public class Gun
    {
        protected float _damage { get; private set; }
        private float _caliber;
        public Gun(float damage, float caliber)
        {
            _damage = damage;
            _caliber = caliber;
        }
        public virtual void Fire(Enemy enemy)
        {
            enemy.Damage_Enemy(_damage);
        }
    }
}
