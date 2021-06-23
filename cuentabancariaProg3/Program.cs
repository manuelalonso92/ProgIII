using System;

namespace cuentabancariaProg3
{
    class Program
    {
        static void Main(string[] args)
        {
            long cuitCliente;
            string nombreCliente;
            int opcionCuenta;

            //Ingresamos un Cliente
            Console.WriteLine("PROGRAMACION 3 - EJERCICIO BASICO DE HERENCIA\n");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine("Bienvenido Cliente! Ingrese su numero de CUIT: ");
            cuitCliente = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre completo: ");
            nombreCliente = Console.ReadLine();

            //Comprobamos los datos del cliente
            cuitCliente = ComprobarDatos(cuitCliente);


            //Seleccion de cuenta a operar
            Console.WriteLine("Cliente! "+ nombreCliente+" que tipo de cuenta desea operar? \n1-Cuenta Corriente \n2-Caja de Ahorro \nSELECCION: ");
            opcionCuenta = int.Parse(Console.ReadLine());

            //Comprobamos datos de seleccion de cuenta
            opcionCuenta = ComprobarSeleccionCuenta(opcionCuenta);
            Console.Clear();

            //Instanciamos segun seleccion
            if (opcionCuenta == 1)
            {
                //CUENTA CORRIENTE
                CuentaCorriente usuarioCC = new CuentaCorriente(cuitCliente, nombreCliente, 1000000);
                usuarioCC.SimularOperaciones();
                Console.WriteLine(usuarioCC.ResultadoSaldos());

            }
            else 
            {
                //CAJA DE AHORRO
                CajaAhorro usuarioCA = new CajaAhorro(cuitCliente, nombreCliente, 1000000);
                usuarioCA.SimularOperaciones();
                Console.WriteLine(usuarioCA.ResultadoSaldos());
            }


        }

        static long ComprobarDatos(long cuit)
        {
            
            if (cuit.ToString().Length != 11)
            {
                while (cuit.ToString().Length != 11) 
                {
                    Console.WriteLine("ERROR DE CUIT! Ingrese nuevamente su numero de CUIT: ");
                    cuit = long.Parse(Console.ReadLine());
                    Console.Clear();
                }

                return cuit;
            }
            else
            {
                return cuit;
            }

        }

        static int ComprobarSeleccionCuenta(int cuenta) 
        {
            if ((cuenta < 1) || (cuenta > 2)) 
            {
                while ((cuenta < 1) || (cuenta > 2)) 
                {
                    Console.WriteLine("ERROR! Ingrese nuevamente el tipo de cuenta a utilizar: \n1-Caja de Ahorro \n2-Cuenta Corriente \nSELECCION: ");
                    cuenta = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                return cuenta;
            }
            else 
            {
                return cuenta;
            }
        }
    }

   


    class Cuenta
    {
        protected long cuit;
        protected string nombreCliente;
        protected int saldo;
        protected int cantOp;
        

        public Cuenta(long Cuit, string Nombre, int saldo) 
        {
            this.cuit = Cuit;
            this.nombreCliente = Nombre;
            this.saldo = saldo;
        }

   
    }

    class CajaAhorro : Cuenta 
    {
        public CajaAhorro(long Cuit, string Nombre, int saldo) : base(Cuit, Nombre, saldo)
        {
            this.saldo = saldo;
        }
        public void SimularOperaciones()
        {

            int seed = Environment.TickCount;
            Random r = new Random(seed);
            int nro;
            int limiteExt;

            for (int i = 0; i < 100; i++)
            {
                nro = r.Next(1, 100);
                if (nro % 2 == 0)
                {
                    //DEPOSITO
                    Console.WriteLine("Deposito $" + (this.saldo += r.Next(10, 10000)));


                }
                else
                {
                    //EXTRACCION

                    limiteExt = r.Next(10, 10000);
                    if ((this.saldo <= 0) || (limiteExt > this.saldo))
                    {
                        Console.WriteLine("Disculpe, no se puede extraer el monto solicitado! --> $" + limiteExt.ToString());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Extraccion $" + (saldo -= limiteExt));
                    }
                }

                this.cantOp++;
            }
        }
        public string ResultadoSaldos()
        {
            return "Saldo Caja de Ahorro $: " + this.saldo.ToString() + " Cantidad de operaciones realizadas: " + this.cantOp.ToString();
        }

    }

    class CuentaCorriente : Cuenta 
    {
        public CuentaCorriente(long Cuit, string Nombre, int saldo) : base(Cuit, Nombre, saldo)
        {
            this.saldo = saldo;
        }
        public void SimularOperaciones()
        {
            int seed = Environment.TickCount;
            Random r = new Random(seed);
            double tna = 0.5;
            int nro;
            int limiteExt;
            int deposito = 0;
            for (int i = 0; i < 100; i++)
            {
                nro = r.Next(1, 100);
                if (this.saldo > 0)
                {
                    if (nro % 2 == 0)
                    {
                        //DEPOSITO
                        deposito += r.Next(10, 10000);
                        this.saldo += deposito;
                        Console.WriteLine("Deposito $" + deposito + "\tSaldo $" + this.saldo);
                    }
                    else
                    {
                        //EXTRACCION
                        limiteExt = r.Next(10, 10000);
                        if (this.saldo - limiteExt < -10000)//
                        {
                            Console.WriteLine("Disculpe, no se puede extraer mas del descubierto! --> $" + limiteExt.ToString());
                            break;
                        }
                        else
                        {
                            this.saldo -= limiteExt;
                            Console.WriteLine("Extraccion $" + limiteExt + "\tSaldo $" + this.saldo);
                        }
                    }
                    this.cantOp++;
                }
                else
                {
                    if (nro % 2 == 0)
                    {
                        //DEPOSITO
                        deposito += r.Next(10, 10000);
                        this.saldo += deposito;
                        Console.WriteLine("Deposito $" + deposito + "\tSaldo $" + this.saldo);
                    }
                    else
                    {
                        //EXTRACCION
                        limiteExt = r.Next(10, 10000);
                        if (this.saldo - limiteExt < -10000)//
                        {
                            Console.WriteLine("Disculpe, no se puede extraer mas del descubierto! --> $" + limiteExt.ToString());
                            break;
                        }
                        else
                        {
                            this.saldo -= limiteExt;
                            Console.WriteLine("Extraccion $" + limiteExt + "\tSaldo $" + this.saldo);
                        }
                    }
                    this.cantOp++;
                }
                //fecha.AddDays(1);
            }
        }
        public string ResultadoSaldos()
        {
            return "\nNombre: " + this.nombreCliente +
                    "\nCuit: " + this.cuit +
                    "\nSaldo Cuenta Corriente $: " + this.saldo.ToString() +
                    "\nCantidad de operaciones realizadas: " + this.cantOp.ToString();
        }
    }

}

