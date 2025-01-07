using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);

            // var meuArray = new int[5] { 5, 6, 7, 3, 2 };
            // meuArray[0] = 12;

            // var funcionarios = new Funcionario[5];
            // funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" };

            // foreach (var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            //     Console.WriteLine(funcionario.Nome);
            // }
        }
    }

    // for (var index = 0; index < meuArray.Length; index++)
    // {
    //     Console.WriteLine(meuArray[index]);

    // para cada...
    // foreach (var item in meuArray)
    // {
    //     Console.WriteLine(item);
    // }

    public struct Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }

}

// Console.WriteLine(meuArray[0]);
// Console.WriteLine(meuArray[1]);
// Console.WriteLine(meuArray[2]);
// Console.WriteLine(meuArray[3]);
// Console.WriteLine(meuArray[4]);






