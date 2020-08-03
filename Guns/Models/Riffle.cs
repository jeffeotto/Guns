using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class Riffle : IWeapon
    {

        public string type = "Riffle";
        public void Fire(string who)
        {
            Console.WriteLine($"{who} is handling a {type} which fires 4 rounds per second.");
        }
    }
}
