using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class NineMillimeter : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing 50 meters range.");
        }
    }
}
