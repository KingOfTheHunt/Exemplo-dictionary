using System;
using System.Collections.Generic;

namespace ExemploDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 
             * Uma estrutura de dados que contém chave e valor
             * Não pode existir chaves iguais.
             * O valor pode ser repetido.
             * Uma chava identifica um valor.
            */

            // Crie um algoritmo que descubra a primeira letra que não se repete.
            Dictionary<char, int> letras = new Dictionary<char, int>();

            Console.Write("Escreva uma palavra: ");
            string palavra = Console.ReadLine().ToUpper();

            Console.WriteLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                char caracterAtual = palavra[i];

                // Verifica se já existe a chava no dictionary
                if (!letras.ContainsKey(caracterAtual))
                {
                    letras.Add(caracterAtual, 1);
                }
                else
                {
                    letras[caracterAtual]++;
                }
            }

            Console.WriteLine("Exibindo o dicionario:");
            foreach (KeyValuePair<char, int> par in letras)
            {
                Console.WriteLine($"{par.Key}: {par.Value}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<char, int> par in letras)
            {
                if (par.Value == 1)
                {
                    Console.WriteLine("A primeira letra que não se repete.");
                    Console.WriteLine($"{par.Key}: {par.Value}");
                    return;
                }
            }
        }
    }
}
