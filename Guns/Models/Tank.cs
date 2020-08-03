using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class Tank
    {
        public string Model { get; set; }
        private IWeapon _weapon;

        public IWeapon Weapon
        {
             set { this._weapon = value; }
        }
        public Tank()
        {
            
        }
        public void Attack(string who)
        {
            this._weapon.Fire(who);
        }
    }
}
