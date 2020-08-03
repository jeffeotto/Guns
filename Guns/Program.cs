using Guns.Interfaces;
using Guns.Models;
using System;

namespace Guns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Soldier");
            
            IWeapon machineGun = new MachineGun();
            IWeapon riffle = new Riffle();
            IWeapon nineMl = new NineMillimeter();

           var soldier1 = new Soldier()
            {
                Name = "Brian"
            };

            Console.WriteLine("Weapon #1");
            soldier1.Weapon = machineGun;
            soldier1.Attack(soldier1.Name);
            Console.WriteLine();

            Console.WriteLine("Weapon #2");
            soldier1.Weapon = riffle;
            soldier1.Attack(soldier1.Name);
            Console.WriteLine();

            Console.WriteLine("Weapon #3");
            soldier1.Weapon = nineMl;
            soldier1.Attack(soldier1.Name);
            Console.WriteLine();



            Console.WriteLine("Tank");
            IWeapon cannon = new Cannon();
            IWeapon m240Mgun = new M240();
            IWeapon m2hbMgun = new M2HB();

            var tank1 = new Tank()
            {
                Model = "Mabrams"
            };
           
            Console.WriteLine("Weapon #1");
            tank1.Weapon = cannon;
            tank1.Attack(tank1.Model);
            Console.WriteLine();

            Console.WriteLine("Weapon #2");
            tank1.Weapon = m240Mgun;
            tank1.Attack(tank1.Model);
            Console.WriteLine();

            Console.WriteLine("Weapon #3");
            tank1.Weapon =m2hbMgun;
            tank1.Attack(tank1.Model);
            Console.WriteLine();


        }
    }
}
