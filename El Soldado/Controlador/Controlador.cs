using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado.Controlador
{
    class Controller
    {
        Modelo.Soldado soldado;
        Modelo.Revolver revolver;
        Modelo.Escopeta escopeta;
        Modelo.Rifle rifle;
        public Controller()
        {
            Orquestadora();
            
        }
        public void Orquestadora()
        {
            soldado = new Modelo.Soldado();
            revolver = new Modelo.Revolver();
            escopeta = new Modelo.Escopeta();
            rifle = new Modelo.Rifle();
            this.soldado = new Modelo.Soldado();
        }
        public void hola()
        {
            Console.WriteLine("Hola");
        }
        public void EquiparArma(int numero)
        {
            Modelo.Arma arma;
            switch (numero)
            {
                case 1: arma = revolver; break;
                case 2: arma = rifle; break;
                case 3: arma = escopeta; break;
                    //a este punto ya valide que el numero que llegue es de 1 a 3 en el menu por lo q el default
                    //esta de mas pero sino me tira error xq arma no se inicializa. Eso como se puede mejorar?
                default: arma = revolver; break;
            }
            soldado.EquiparArma(arma);
        }
        public Boolean TieneArmaEquipada()
        {
            return soldado.TieneArmaEquipada();
        }
        public void DejarArma()
        {
            soldado.DejarArma();
        }
        public void Disparar()
        {
            soldado.Disparar();
        }
        public string VerArmaEnUso()
        {
            return soldado.VerArmaEnUso();
        }
    }
}
