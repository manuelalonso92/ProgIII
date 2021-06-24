using System;

namespace ejercicioFechas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Realice una clase utilitaria de manejo de tiempo y fechas que tenga al menos:
            ObtenerDiasCalendario() obtiene los días entre dos fechas
            ObtenerDiasLaborables() obtiene los días laborables entre dos fechas
            SumarDiasLaborables() obtiene una fecha sumando una cantidad de días a una fecha inicial
            Tenga en cuenta fines de semanas y feriados
            Puede guardar los feriados en un arreglo
            */



            DateTime f1; //FEcha1
            DateTime f2; //Fecha2

            Console.WriteLine("Ingrese la primer fecha: 1/6/2021");
            f1 = DateTime.Parse("1/6/2021");
            Console.WriteLine("Ingrese la segunda fecha: 21/6/2021");
            f2 = DateTime.Parse("21/6/2021");

            TimeSpan DiasEntreFechas = f1 - f2;

            //Dias entre fechas
            Console.WriteLine("Dias entre fechas: " + Math.Abs(DiasEntreFechas.Days));

            //Dias laborables entre fechas
            for (int i = 0; i < DiasEntreFechas.Days; i++) {
                if (f1.DayOfWeek == DayOfWeek.Saturday)
                {
                    f1 = f1.AddDays(2);

                }
                else if (f1.DayOfWeek == DayOfWeek.Sunday)
                {
                    f1 = f1.AddDays(1);

                }

                if (f2.DayOfWeek == DayOfWeek.Saturday)
                {
                    f2 = f2.AddDays(-1);

                }
                else if (f2.DayOfWeek == DayOfWeek.Sunday)
                {
                    f2 = f2.AddDays(-2);

                }
            }

            int diff = (int)f2.Subtract(f1).TotalDays;
            int result = diff / 7 * 5 + diff % 7;

            Console.WriteLine("Dias entre fechas laborables: " + result.ToString());


            //Fecha sumando una cantidad de dias

            DateTime fechaOriginal = DateTime.Now;
            DateTime tmpFecha = fechaOriginal;
            int diasLaborab = 10;
            while (diasLaborab != 0) 
            { 
                tmpFecha = tmpFecha.AddDays(1);
                if ((tmpFecha.DayOfWeek != DayOfWeek.Saturday) && (tmpFecha.DayOfWeek != DayOfWeek.Sunday))
                { diasLaborab--; }
            }

            /*DateTime[] holidays = 
                new DateTime[] { 
                new DateTime(2010,12,27),
                new DateTime(2010,12,28),
                new DateTime(2011,01,03),
                new DateTime(2011,01,12),
                new DateTime(2011,01,13)*/

            Console.WriteLine("Fecha original: "+fechaOriginal.ToString()); 
            Console.WriteLine("Fecha nueva con los dias sumados: "+tmpFecha.ToString());
        }


      
    }


}
