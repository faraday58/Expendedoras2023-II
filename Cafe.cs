using System;


namespace Expendedoras2023_II
{
    internal class Cafe:Expendedora
    {
        public Cafe()
        {
            Saludar();
            Temperatura = 60;
            Console.WriteLine("La temperatura es: {0} [°C]", Temperatura);
        }


    }
}
