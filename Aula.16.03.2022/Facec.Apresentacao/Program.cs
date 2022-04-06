using System;
using Facec.Classes;

namespace Facec.Apresentacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Método Extension
            //ImprimirVelocidadeFinal(new Cooper());
            //ImprimirVelocidadeFinal(new Fusca());
            #endregion Método Extension

            #region Partial
            //ImprimirMembroHumano(new Humano());
            #endregion Partial

            #region Struct

            //PosicaoGPS posicaoGPS = new PosicaoGPS() 
            //{
            //    Latitude = 50.00m,
            //    Longitude = 15.00m,

            //};

            var posicaoGPS = new PosicaoGPS(15.00m, -50.00m);

            Console.WriteLine("Está no hemisfério Norte");
            #endregion Struct
            Console.ReadLine();
        }
        static void ImprimirVelocidadeFinal(AbstractCarro carro)
        {
            Console.WriteLine(carro.ObterVelocidadeFinal());
        }

        static void ImprimirMembrosHumano(Humano humano)
        {
            Console.WriteLine($"{humano}");
        }
    }
}
