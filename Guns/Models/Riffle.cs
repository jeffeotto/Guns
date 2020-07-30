using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class Riffle : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing 4 rounds per second.");
        }
    }
}
