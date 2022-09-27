using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado.Modelo
{
    class Soldado
    {
        private IDisparable _arma;

        internal IDisparable Arma { get => _arma; set => _arma = value; }

        public Soldado()
        {
            Arma = null;
        }
        
        public void EquiparArma(Arma arma)
        {
            if (this.Arma != null)
            {
                Console.WriteLine("Parece que el soldado ya tiene un arma en sus manos");
            }
            else
            {
                this.Arma = arma;
            }
        }
    
        public void Disparar()
        {
            if (this.Arma != null)
            {
                Arma.Disparar();
            }
            else
            {
                Console.WriteLine("Parece que el soldado no tiene arma");
            }
        }
        public void DejarArma()
        {
            if (this.Arma != null)
            {
                this.Arma = null;
            }
        }
        public string VerArmaEnUso()
        {
            if(Arma != null) 
            { 
            return Arma.Mostrarse();
            }
            {
                return "Parece que el soldado no tiene arma en sus manos...";
            }
        }
        public Boolean TieneArmaEquipada()
        {
            return this.Arma != null;
        }
    }
}
