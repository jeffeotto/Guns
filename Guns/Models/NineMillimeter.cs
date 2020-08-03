using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class NineMillimeter : IWeapon
    {
        public string type = "Pistol";
        public void Fire(string who)
        {
            Console.WriteLine($"{who} is handling a {type} firing 50 meters range.");
        }
    }
}
