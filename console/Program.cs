using System;
using System.Linq;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var palavra = "ovo";

            var resultado = Eh(palavra);

            Console.WriteLine(resultado);
        }

        static bool Eh(string palavra)
        {
            var lista = palavra.ToList();
            
            while(lista.Count() > 0)
            {
                if(lista.Count() == 1) break;

                if(lista.First() == lista.Last())
                {
                    lista.RemoveAt(0);
                    lista.RemoveAt(lista.Count() - 1);
                }
                else return false;
            }

            lista.Clear();

            return true;
        }
    }
}
