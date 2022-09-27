using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado.Modelo
{
    class Rifle: Arma
    {
        public Rifle() : base("Rifle")
        {

        }
        public override void Disparar()
        {
            Console.WriteLine("Púm..., Púm..., Púm...,");
        }

    }
}
