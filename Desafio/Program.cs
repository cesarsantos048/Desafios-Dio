using System;
using Desafio.Entities;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi Heroi = new Heroi("Cesar", 23, "Knight");
            Mago desafio = new Mago("teste", 23, "tar");

            Console.WriteLine(desafio.Ataque(13));
        }
    }
}
