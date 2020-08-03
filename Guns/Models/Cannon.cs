using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class Cannon : IWeapon
    {
     
        public void Fire(string who)
        {
            Console.WriteLine($"{who}Firing 3km range.");
        }
    }
}
