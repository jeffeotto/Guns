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

            var soldier = new Soldier(machineGun);
            soldier.Attack();

            soldier = new Soldier(riffle);
            soldier.Attack();

            soldier = new Soldier(nineMl);
            soldier.Attack();
        }
    }
}
