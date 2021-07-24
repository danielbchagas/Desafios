namespace console{
    public class NumerosPrimos
    {
        public bool EhPrimo(int numero)
        {
            for(int i = 1; i <= numero; i++)
            {
                if(i == 1 || i == numero)
                    continue;

                if(numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}