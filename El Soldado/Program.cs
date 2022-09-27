using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Soldado
{
    internal class Program
    {
        static void Main(string[] args)
        {
     

            Menu menu = new Menu();

            #region
            /*while (ingresoPrincipal != 5)
            {

                switch (ingresoPrincipal)
                {
                    case 1:
                        {

                            int ingresoArma = Menu.solicitarIngresoArma();
                            switch (ingresoArma)
                            {
                                case 1:
                                    soldado.recogerArma(revolver);
                                    break;
                                case 2:
                                    soldado.recogerArma(rifle);
                                    break;
                                case 3:
                                    soldado.recogerArma(escopeta);
                                    break;
                                case 4:
                                    break;
                            }
                            break;
                        }
                    case 2:
                        soldado.dejarArma();
                        break;
                    case 3:
                        soldado.disparar();
                        break;
                    case 4:
                        if (soldado.Arma != null)
                        {
                            Console.WriteLine(soldado.Arma.Nombre);
                        }
                        else
                        {
                            Console.WriteLine("Parece que el soldado no tiene ningun arma");
                        }
                        break;

                }

                
           
                ingresoPrincipal = Menu.solicitarIngresoPrincipal();
            }*/
            #endregion
        }


    }
}
