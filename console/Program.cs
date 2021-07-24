using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var verificaNumeros = new NumerosPrimos();
            var numeros = new int[]{2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            
            foreach (var item in numeros)
            {
                Console.WriteLine(verificaNumeros.EhPrimo(item) == true ? "Sim" : "Não");
            }
        }
    }
}