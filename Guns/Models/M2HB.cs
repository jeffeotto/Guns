using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class M2HB : IWeapon
    {
        public string type =  "M2HB Machine Gun";
        public void Fire(string who)
        {
            Console.WriteLine($"{who} is firing a {type} Browning .50 ammunition.");
        }
    }
}
