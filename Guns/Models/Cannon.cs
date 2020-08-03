using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class Cannon : IWeapon
    {
        public string type = "Cannon";
        public void Fire(string who)
        {
            Console.WriteLine($"{who } is firing a {type} with 3km range.");
        }
    }
}
