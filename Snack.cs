using System;
using System.Text.RegularExpressions;

namespace Expendedoras2023_II
{
    internal class Snack:Expendedora
    {
        public Snack()
        {
            marca = "AMS";
            Temperatura = 14;
            precio = 20;
            Saludar();
            LimpiarPantalla();
            Console.WriteLine("Marca: {0} ", marca);
            Console.WriteLine("Temperatura interna {0} [°C] ", Temperatura);
            LimpiarPantalla();
            codigo = MostrarCodigoDeProducto();
            LimpiarPantalla();
            MostrarPrecio(codigo);


        }
    }
}
