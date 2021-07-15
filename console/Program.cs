using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaFrases = new List<string>
            {
                "A droga do dote é todo da gorda.",
                "Aí, Lima falou: “Olá, família!”",
                "Ovo de dinossauro"
            };
            
            listaFrases.ForEach(_ => Console.WriteLine(EhPalindromo(_)));
        }

        static bool EhPalindromo(string palavra)
        {
            var lista = TrataString(palavra);
            
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

        static IList<char> TrataString(string palavra)
        {
            return  palavra
                    .ToLower()
                    .Normalize(NormalizationForm.FormD)
                    .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                    .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.SpaceSeparator)
                    .Where(ch => !new char[]{'.', '“', ',', '!', ':', '”'}.Any(_ => _.Equals(ch)))
                    .ToList();
        }
    }
}
