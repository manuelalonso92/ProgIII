using System;
using System.Collections.Generic;

namespace temasSegundoParcialProg3
{
    class Program
    {
        static void Main(string[] args)
        {
            //HERENCIA

            Console.WriteLine("HERENCIA\n");

            Motherboard Asus = new Motherboard("ASUS TUF GAMING B550 PLUS");
            Asus.queSoy();
            Asus.cualEsMiFuncion();

            CPU AMD = new CPU("Ryzen 5600x");
            AMD.cualEsMiFuncion();

            Console.WriteLine("====================================================");


            //INTERFACES

            Console.WriteLine("INTERFACES\n");

            Console.WriteLine("Numero de Pines: " + AMD.Pines());

            Console.WriteLine("====================================================");

            //COLECCIONES

            Console.WriteLine("COLECCIONES\n");

            List<int> numeros = new List<int>();

            Console.WriteLine("Ingresa numeros (0 termina)");

            int elem = 1;

            while (elem != 0) 
            {
                elem = int.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            Console.WriteLine("Numeros ingresados: ");

            foreach (int elemento in numeros) 
            {
                Console.WriteLine(elemento);
            }

        }
    }
}
