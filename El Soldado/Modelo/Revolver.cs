using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado.Modelo
{
    class Revolver: Arma
    {
        public Revolver(): base("Revolver")
        {

        }
        public override void Disparar()
        {
            Console.WriteLine("Púm...,");
        }

      
    }
}
