using PatronStrategy.Comportamientos;
using PatronStrategy.Patos;
using System;

namespace PatronStrategy
{
    class PatronStrategy
    {
        private static void Main(string[] args)
        {
            _Pato Decoy = new DecoyDuck();
            _Pato Mallard = new MallardDuck();
            _Pato Model = new ModelDuck();
            _Pato RedHead = new RedHeadDuck();
            _Pato Rubber = new RubberDuck();

            MenuPato Menus = new MenuPato();

            string opcion = "";

            do
            {
                Console.Clear();
                Console.WriteLine("     - - - P A R Q U E - - -");
                Console.WriteLine("\n Te encuentras con un letrero que dice:");
                Console.WriteLine(" \"Bienvenido al parque de patos, favor de elegir un pato\"");
                Console.WriteLine("\n Al levantar la mirada puedes ver lo siguientes patos:");

                Console.WriteLine("\n   [1] Un pato falso");
                Console.WriteLine("   [2] Pato Mallard");
                Console.WriteLine("   [3] Pato Modelo (Es bonito)");
                Console.WriteLine("   [4] Pato Cabeza Roja (se ve malvado)");
                Console.WriteLine("   [5] Pato de hule");

                Console.Write("\n Elija un pato o presione [0] para huir del parque: ");
                opcion = Console.ReadLine();

                if (opcion == null)
                    opcion = "";

                switch (opcion)
                {
                    case "0":
                        Console.WriteLine("\nNo escaparas por siempre...");
                        break;

                    case "1":
                        Menus.PatoSeleccionado(Decoy);
                        break;

                    case "2":
                        Menus.PatoSeleccionado(Mallard);
                        break;

                    case "3":
                        Menus.PatoSeleccionado(Model);
                        break;

                    case "4":
                        Menus.PatoSeleccionado(RedHead);
                        break;

                    case "5":
                        Menus.PatoSeleccionado(Rubber);
                        break;

                    default:
                        Console.WriteLine("\n Elija una opcion valida \n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "0");
        }
    }
}