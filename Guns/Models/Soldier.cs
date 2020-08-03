using Guns.Interfaces;


namespace Guns.Models
{
    class Soldier
    {
        private IWeapon weapon;

        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }
        public void Attack()
        {
            this.weapon.Fire();
        }
    }
}
