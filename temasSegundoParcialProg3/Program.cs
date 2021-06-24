using System;
using System.Collections.Generic;
using System.IO;

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

            numeros.RemoveAt(numeros.Count - 1); //Elimina el ulimo elemento que es 0

            Console.WriteLine("Numeros ingresados: ");

            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);


            }

            Console.WriteLine("====================================================");

            //ARCHIVOS

            Console.WriteLine("ARCHIVOS\n");

            
            //ESCRIBIR
            try
            {
                string path = @"C:\Users\Manu\Documents\arch.txt";
                Console.WriteLine("Escribi lo que quieras cabeza de pingo: ");
                string texto = Console.ReadLine() + " -> Fecha y Hora: " + DateTime.Now;

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(texto);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            //LEER 
            Console.WriteLine("\n**********************************");
            Console.WriteLine("LEYENDO ARCHIVO: \n");
            
            try
            {
                int counter = 0;
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Manu\Documents\arch.txt");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }

                file.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
           
        }
    }
}
