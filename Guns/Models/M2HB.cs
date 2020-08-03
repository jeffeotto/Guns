using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class M2HB : IWeapon
    {
       
        public void Fire(string who)
        {
            Console.WriteLine($"{who}Firing Browning .50 ammunition.");
        }
    }
}
