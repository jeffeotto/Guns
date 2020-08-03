using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class M240 : IWeapon
    {
      
        public void Fire(string who)
        {
            Console.WriteLine($"{who}Firing 200 rounds .30 ammunition per minute.");
        }
    }
}
