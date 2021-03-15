using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {








            string comando;
            double troca, Km;
            
            Console.WriteLine();
            Console.WriteLine("--- Conversor Milhas/Km ---");
            Console.WriteLine("Digite um valor a ser convertido...");
            Console.WriteLine();
            comando = Console.ReadLine();
            Console.WriteLine();

            troca = Convert.ToDouble(comando);
            Km = troca*1.609;

            Console.Beep();
            Console.WriteLine($"Conversão: {Km:N3} Km.");
            















        }
    }
}
