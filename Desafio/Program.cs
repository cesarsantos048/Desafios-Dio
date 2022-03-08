using System;
using Desafio.Entities;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
             double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            double media = ((2 * A) + (3 * B) + (5 * C))/10;
            Console.WriteLine($"MEDIA = {media.ToString("N1")}");
            Console.ReadKey();
        }
    }
}
