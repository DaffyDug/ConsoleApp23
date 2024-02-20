namespace ConsoleApp23
{
    public class ShotGun : Gun
    {
        public ShotGun(float damage, float caliber) : base(damage, caliber)
        {
        }
        public override void Fire(Enemy enemy)
        {
            enemy.Damage_Enemy(_damage * 3);
        }
    }
}
