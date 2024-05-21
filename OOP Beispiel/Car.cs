using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    class Car : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Vier Räder haben bodenkontakt.");
        }
    }
}
