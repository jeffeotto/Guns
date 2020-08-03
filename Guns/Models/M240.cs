using Guns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Models
{
    class M240 : IWeapon
    {
        public string type =" M240 Machine Gun";
        public void Fire(string who)
        {
            Console.WriteLine($"{who} is Firing a {type} which fires 200 rounds .30 ammunition per minute.");
        }
    }
}
