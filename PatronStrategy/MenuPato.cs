using PatronStrategy.Comportamientos;
using PatronStrategy.Patos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public class MenuPato
    {
        public void PatoSeleccionado(_Pato patonsio)
        {
            string opcion = "";

            do
            {
                Console.Clear();
                Console.WriteLine(" Has seleccionado al " + patonsio.Nombre + "\n");
                patonsio.Presentacion();
                Console.WriteLine("\n Que deseas hacer con el pato?");

                Console.WriteLine("\n   [1] Ver que puede hacer");
                Console.WriteLine("   [2] Modificar su comportamiento con hechiceria malvada");

                Console.Write("\n Elija una opcion o presione [0] para dejar al pato en paz: ");
                opcion = Console.ReadLine();

                if (opcion == null)
                    opcion = "";

                switch (opcion)
                {
                    case "0":
                        Console.WriteLine("\n Te alejas lentamente del pato...");
                        break;

                    case "1":
                        MenuHabilidades(patonsio);
                        break;

                    case "2":
                        MenuCambios(patonsio);
                        break;

                    default:
                        Console.WriteLine("\n Elija una opcion valida \n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "0");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private void MenuHabilidades(_Pato patonsio)
        {
            string opcion = "";

            do
            {
                Console.Clear();
                Console.WriteLine(" Que deseas que haga el pato?");

                Console.WriteLine("\n   [1] Arrojarlo para que vuele");
                Console.WriteLine("   [2] Obligarlo a graznar con magia oscura");
                Console.WriteLine("   [3] Dejarlo en el agua para ver si puede nadar");

                Console.Write("\n Elija una opcion o presione [0] para dejar al pato en paz: ");
                opcion = Console.ReadLine();

                if (opcion == null)
                    opcion = "";

                switch (opcion)
                {
                    case "0":
                        Console.WriteLine("\n Dejas de analizar al pato...");
                        break;

                    case "1":
                        Console.WriteLine("");

                        patonsio.IntentarVolar();

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("");

                        patonsio.IntentarQuack();

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("");

                        patonsio.IntentarNadar();

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\n Elija una opcion valida \n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "0");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private void MenuCambios(_Pato patonsio)
        {
            string opcion = "";

            do
            {
                Console.Clear();
                Console.WriteLine(" Usas magia oscura en el pato... que deseas cambiar?");

                Console.WriteLine("\n   [1] \"El pato volara...\"");
                Console.WriteLine("   [2] \"Ahora este pato ya no puede volar...\"");
                Console.WriteLine("   [3] \"Le otorgo la habilidad de levitar con brujeria...\"");
                Console.WriteLine("\n   [4] \"Ahora sera capaz de graznar...\"");
                Console.WriteLine("   [5] \"Desde ahora en adelante, no podra volver a graznar...\"");
                Console.WriteLine("   [6] \"¡Invade sus mentes! y graznales telepaticamente...\"");
                Console.WriteLine("\n   [7] \"Le otorgo la habilidad de nadar...\"");
                Console.WriteLine("   [8] \"Pesado como roca, jamas nadara otra vez...\"");
                Console.WriteLine("   [9] \"Magia usaras y por el lago nadaras...\"");

                Console.Write("\n Elija una opcion o presione [0] para dejar al pato en paz: ");
                opcion = Console.ReadLine();

                if (opcion == null)
                    opcion = "";

                switch (opcion)
                {
                    case "0":
                        Console.WriteLine("\n *Detienes tu magia oscura*");
                        break;

                    case "1":
                        patonsio.SetVolar(new VolarNormal());
                        Console.WriteLine("\n *Hechizo Realizado*"); 
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        patonsio.SetVolar(new VolarNo());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        patonsio.SetVolar(new VolarBrujo());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        patonsio.SetQuack(new QuackNormal());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "5":
                        patonsio.SetQuack(new QuackNo());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "6":
                        patonsio.SetQuack(new QuackTelepatico());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "7":
                        patonsio.SetNadar(new NadarNormal());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "8":
                        patonsio.SetNadar(new NadarNo());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "9":
                        patonsio.SetNadar(new NadarMagia());
                        Console.WriteLine("\n *Hechizo Realizado*");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\n Elija una opcion valida \n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "0");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
