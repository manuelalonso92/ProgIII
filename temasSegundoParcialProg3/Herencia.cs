using System;
using System.Collections.Generic;
using System.Text;

namespace temasSegundoParcialProg3
{
    class Herencia
    {
    }

    class Motherboard 
    {
        protected String nombre;

        public Motherboard(String marca) { nombre = marca; }
        public void queSoy() { Console.WriteLine(nombre.ToString()+ ": Soy una placa madre!"); }

        public virtual void cualEsMiFuncion() { Console.WriteLine(nombre.ToString() + ": Soy capaz de almacenar componentes de PC!"); }

    }

    class CPU : Motherboard, InumeroPines
    {
        public CPU(String nombreCPU) : base(nombreCPU) { }

        public override void cualEsMiFuncion() { Console.WriteLine(nombre.ToString()+": Proceso informacion de las partes del PC"); }

        public int Pines() 
        {
            return 48;
        }
    }
}
