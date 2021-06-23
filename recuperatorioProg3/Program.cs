using System;

namespace recuperatorioProg3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroTicket;

            //Nro Ticket
            Console.WriteLine("Bienvenido Cliente! Ingrese su numero de Ticket (8 digitos): ");
            nroTicket = int.Parse(Console.ReadLine());

            //Iniciliza el sorteo
            Sorteo juegaCliente = new Sorteo();

            //Elije 5 numeros entre 0 y 50
            int numeroCliente;
            int[] arregloNumerosCliente = new int[5];



            //Verificacion numero valido y carga en un arreglo

            Console.WriteLine("Elija 5 (Cinco) numeros entre 0 y 50: ");
            for (int i = 0; i < 5; i++)
            { 
                numeroCliente = int.Parse(Console.ReadLine());
                while ((numeroCliente < 0) || (numeroCliente > 50))
                {
                    Console.WriteLine("Error, vuelva a elegir un numero: ");
                    numeroCliente = int.Parse(Console.ReadLine());
                }
                arregloNumerosCliente[i] = numeroCliente;
            }
            
            

            //Verificamos los aciertos
            
            juegaCliente.generadorNumerosSorteo(arregloNumerosCliente);

            
            
        }
    }




    class Sorteo 
    {
        public void generadorNumerosSorteo(int [] arregloNumerosCliente) 
        {
            int nroRandom;
            int cantAciertos = 0;
            int[] arrnumerosSorteo = new int[5];
           
            //Generamos los 5 numeros random
            Random randomNumero = new Random();
            for (int i = 0; i < 5; i++) 
            {
                nroRandom = randomNumero.Next(0, 50);
                arrnumerosSorteo[i] = nroRandom;
            }

            //Verificamos los aciertos

            for (int i = 0; i <= arregloNumerosCliente.Length; i++) 
            {
                for (int j = 0; j <= arrnumerosSorteo.Length; j++) 
                {
                    if (arregloNumerosCliente[i] == arrnumerosSorteo[j]) 
                    {
                        cantAciertos++;
                    }
                }
            }

            Console.WriteLine("Estimado cliente Ud. ha acertado "+cantAciertos.ToString()+ " numeros! ");
        }

        

       
    }
}
