namespace ConsoleApp23
{
    public class Player
    {
        private Gun _gun;
        public Player(Gun gun)
        {
            _gun = gun;
        }
        public void TakeGun(Gun gun1)
        {
            _gun = gun1;
        }
        public void Atack(Enemy enemy)
        {
            if (_gun == null)
            {
                _gun.Fire(enemy);
            }
        }
    }
}
