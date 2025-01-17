﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.VisualBasic;

namespace String
{
    class Program
    {
        // GUIDS -----------------------------------------------------------

        // static void Main(string[] args)
        // {
        //     var id = Guid.NewGuid();
        //     id.ToString();

        //     id = new Guid("1d44389a-b8c2-4894-a805-98f47070f751");
        //     Console.WriteLine(id.ToString().Substring(0, 8));
        // }

        // // INTERPOLAÇÃO DE STRINGS ------------------------------------------
        // static void Main(string[] args)
        // {
        //     // var price = 10.2;
        //     // // var texto = "O preço do produto é: " + price; 
        //     // // var texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true); 
        //     // var texto = $@"O preço 
        //     // do produto é {price}";

        //     // Console.WriteLine(texto);
        // }

        // VOMPARAÇÃO DE STRINGS ----------------------------------------------
        // static void Main(string[] args)
        // {
        //     var texto = "Este texto é um teste";

        //     Console.WriteLine(texto.CompareTo("Este texto é um teste")); 
        //     Console.WriteLine(texto.Contains("teste")); 
        //     Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); 
        // }


        // StartsWith / EndsWith (ComeçaCom / TerminaCom) ----------------------
        // static void Main(string[] args)
        // {
        //     var texto = "Este texto é um teste";

        //     Console.WriteLine(texto.StartsWith("Este"));
        //     Console.WriteLine(texto.StartsWith("este"));
        //     Console.WriteLine(texto.StartsWith("teste"));

        //     Console.WriteLine("");

        //     Console.WriteLine(texto.EndsWith("teste"));
        //     Console.WriteLine(texto.EndsWith("este"));
        //     Console.WriteLine(texto.EndsWith("Teste"));

        // }

        // EQUALS --------------------------------------------------------------
        // static void Main(string[] args)
        // {
        //     var texto = "Este texto é um teste";

        //     Console.WriteLine(texto.Equals("Este texto é um teste")); 
        //     Console.WriteLine(texto.Equals("este texto é um teste"));
        //     Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        // }


        // ÍNDICES -------------------------------------------------------------

        // static void Main(string[] args)
        // {
        //     var texto = "Este texto é um teste";
        //     Console.WriteLine(texto.IndexOf("é")); 
        //     Console.WriteLine(texto.LastIndexOf("s")); 

        // }


        // MÉTODOS ADICIONAIS --------------------------------------------------
        // static void Main(string[] args)
        // {
        //     var texto = "Este texto é um teste";
        //     Console.WriteLine(texto.ToLower()); // converter o texto para minusculo
        //     Console.WriteLine(texto.ToUpper()); // converter o texto para maiusculo
        //     Console.WriteLine(texto.Insert(5, "AQUI ")); // posição + "caracter que você deseja inserir
        //     Console.WriteLine(texto.Remove(5, 5)); // Posição de inicio e fim que deseja remover
        //     Console.WriteLine(texto.Length); // Quantidade de caracteres que uma string tem

        // }


        // MANIPULANDO STRINGS -------------------------------------------------

        // static void Main(string[] args)
        // {
        //     var texto = " Este texto é um teste ";
        //     Console.WriteLine(texto.Replace("Este", "isto")); // trocar um objeto por outro, no caso, "Este" por "isto"

        //     var divisao = texto.Split(" "); // Split = dividir
        //     Console.WriteLine(divisao[0]);
        //     Console.WriteLine(divisao[1]);
        //     Console.WriteLine(divisao[2]);
        //     Console.WriteLine(divisao[3]);

        //     var resultado = texto.Substring(5, 5);
        //     Console.WriteLine(resultado);

        //     Console.WriteLine(texto.Trim()); // remove espaçamento começo/fim

        // }


        // StringBuilder ------------------------------------------------------

        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            texto.Append("Este texto");
            texto.Append(" é um teste");
            texto.Append("é um ");

            texto.ToString();
            Console.WriteLine(texto);

        }
    }
}

