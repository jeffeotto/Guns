using Guns.Interfaces;
using Guns.Models;
using System;

namespace Guns
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            IWeapon machineGun = new MachineGun();
            IWeapon riffle = new Riffle();
            IWeapon nineMl = new NineMillimeter();

           var soldier1 = new Soldier()
            {
                Name = "Brian"
            };

            soldier1.Weapon = machineGun;
            soldier1.Attack(soldier1.Name);

            soldier1.Weapon = riffle;
            soldier1.Attack(soldier1.Name);

            soldier1.Weapon = nineMl;
            soldier1.Attack(soldier1.Name);


            
        }
    }
}
