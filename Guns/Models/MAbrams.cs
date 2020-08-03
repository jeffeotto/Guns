using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class MAbrams
    {
        private IWeapon weapon;

        public MAbrams(IWeapon weapon)
        {
            this.weapon = weapon;
        }
        public void Attack(string who)
        {
            this.weapon.Fire(who);
        }
    }
}
