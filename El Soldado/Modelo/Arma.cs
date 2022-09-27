using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado.Modelo
{
    abstract class Arma: IDisparable
    {
        private string nombre;

        public Arma(string nombre)
        {
            this.nombre = nombre;
        }
        public  abstract void Disparar();
        public string Mostrarse()
        {
            return nombre;
        }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
