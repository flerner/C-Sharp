using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado
{
    class Menu
    {
       
        Controlador.Controller controlador;
        public Menu()
        {
            controlador = new Controlador.Controller();
            OpcionesMenuPrincipal();
           
            
        }
      
        public int SolicitarIngresoPrincipal()
        {
            int numero = -2;
            string linea;
            do
            {
                //estas validaciones van en esta vista o en el controller?
                try
                {
                    linea = Console.ReadLine();
                    numero = int.Parse(linea);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Usted ingreso mal la opcion, usted se tiene que arrepentir");
                }
            } while (numero <= 0 || numero > 5);

            switch (numero)
            {
                case 1:
                    OpcionesMenuRecogerArma();
                    break;
                case 2: controlador.DejarArma();
                    SolicitarIngresoPrincipal();
                    break;
                case 3: controlador.Disparar();
                    SolicitarIngresoPrincipal();
                    break;
                case 4:
                    if (controlador.TieneArmaEquipada()) { 
                    Console.WriteLine ("El arma que se esta utilizando en este momento es: " + controlador.VerArmaEnUso());
                    }
                    else
                    {
                        Console.WriteLine(controlador.VerArmaEnUso());
                    }
                    SolicitarIngresoPrincipal();
                    break;
                default: Console.WriteLine("Adios, que tenga usted un buen dia");
                    Console.ReadKey();
                    break;
            }
            return numero;
        }
        public int SolicitarIngresoArma()
        {
            int numero = -2;
            string linea;
            do
            {
                try
                {
                    linea = Console.ReadLine();
                    numero = int.Parse(linea);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Usted ingreso mal la opcion, usted se tiene que arrepentir");
                }
            } while (numero <= 0 || numero > 4);
            if(numero == 4)
            {
                OpcionesMenuPrincipal();
            }
            else
            {
                controlador.EquiparArma(numero);
                OpcionesMenuPrincipal();
            }
            
            return numero;
        }
        public void OpcionesMenuPrincipal()
        {
            Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado ==- \n \n");
            Console.WriteLine("¿Que desea hacer? \n" + "(presione el numero correspondiente a la opcion del menu)");
            Console.WriteLine("1- Recoger arma.\n" + "2- Dejar arma.\n" + "3- Disparar.\n" + "4- Ver arma en uso.\n" + "5- Salir.");
            SolicitarIngresoPrincipal();

        }
        public void OpcionesMenuRecogerArma()
        {
            Console.WriteLine("Por favor, escoja el arma que desea utilizar\n\n");
            Console.WriteLine("1- Revolver.\n" + "2- Rifle.\n" + "3- Escopeta.\n" + "4- Volever atrás.");
            SolicitarIngresoArma();
        }

    }
}
