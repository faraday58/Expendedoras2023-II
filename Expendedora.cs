using System;
using System.Threading;

namespace Expendedoras2023_II
{
    internal class Expendedora
    {
        string marca;
        float precio;
        short cantProductos;
        byte temperatura;
        string codigo;

        public Expendedora()
        {
            marca = "AMS";
            temperatura = 14;
            precio = 20; 
            Saludar();
            LimpiarPantalla();
            Console.WriteLine("Marca: {0} ", marca);
            Console.WriteLine("Temperatura interna {0} [°C] ", temperatura);
            LimpiarPantalla();
            codigo= MostrarCodigoDeProducto();
            LimpiarPantalla();
            MostrarPrecio(codigo);

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
