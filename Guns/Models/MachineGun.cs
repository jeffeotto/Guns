using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    public class MachineGun : IWeapon
    {
    
         public string type = "MachineGun";

        public void Fire(string who)
        {
            Console.WriteLine($"{who} is handling a {type} which fires 100 rounds per second.");
        }
    }
}
