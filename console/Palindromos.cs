using System.Collections.Generic;
using System;
using System.Linq;
using System.Globalization;
using System.Text;

namespace console
{
    public class Palindromos
    {
        public bool EhPalindromo(string texto)
        {
            var lista = TrataString(texto);
            
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

        private IList<char> TrataString(string texto)
        {
            return  texto
                    .ToLower()
                    .Normalize(NormalizationForm.FormD)
                    .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                    .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.SpaceSeparator)
                    .Where(ch => !new char[]{'.', '“', ',', '!', ':', '”'}.Any(_ => _.Equals(ch)))
                    .ToList();
        }
    }
}