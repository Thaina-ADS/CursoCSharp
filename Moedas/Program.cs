using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;
            Console.WriteLine(Math.Round(valor)); // arredonda o valor
            Console.WriteLine(Math.Ceiling(valor)); // arredonda p cima
            Console.WriteLine(Math.Floor(valor)); // arredonda p baixo

            // FORMATANDO MOEDAS -----------------------
            //Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); 


        }

    }
}