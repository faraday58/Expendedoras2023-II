using System;
using System.Threading;

namespace Expendedoras2023_II
{
    internal class Expendedora
    {
        internal string marca;
        internal float precio;
        short cantProductos;
        byte temperatura;
        internal string codigo;

        public byte Temperatura {
            get => temperatura;
            set
            {
                if( value < 0 || value > 20   )
                {
                    temperatura = 14;
                }
                else
                {
                    temperatura = value;
                }


            }
        }

        public Expendedora()
        {
          
        }

        public Expendedora(byte temperatura)
        {
            this.Temperatura= temperatura;
            Console.WriteLine("Temperatura: {0}", this.Temperatura);


        }



        internal void LimpiarPantalla()
        {
            Thread.Sleep(2000);
            Console.Clear();

        }





        internal void Saludar()
        {
            Console.WriteLine(" Bienvenido ");
        }
        internal string MostrarCodigoDeProducto()
        {
            Console.WriteLine(" A1: Doritos \t B2: Coca Cola \t C3: Chocorroles ");
            Console.WriteLine("Ingrese el código a elegir");
            string codigo = Console.ReadLine();
            //string codigo;
            return codigo;

        }


        internal void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "A1":
                    Console.WriteLine("El precio es: ${0}", precio);
                    break;
                case "B2":
                    Console.WriteLine("El precio es: ${0}", precio+5);
                    break;
                case "C3":
                    Console.WriteLine("El precio es: ${0}", precio-3);
                    break;
            }



        }






    }
}
