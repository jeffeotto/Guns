using Guns.Interfaces;
using System;

namespace Guns.Models
{
    class Soldier
    {
       public string Name { get; set; }
       private IWeapon _weapon;
       

        public Soldier()
        {

        }
        public IWeapon Weapon
        {
            set { this._weapon = value; }  
        }
        public void Attack(string who)
        {
            this._weapon.Fire(who);
        }

    }
}
