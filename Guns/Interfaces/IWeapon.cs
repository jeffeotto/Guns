using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Guns.Interfaces
{
    interface IWeapon
    {
      void Fire(string who);   
    }
}
