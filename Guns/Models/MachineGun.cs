using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class MachineGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing 100 rounds per second.");
        }
    }
}
