using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa {
    internal class Program {
        static void Main(string[] args) {

            // Variaveis
            int[] numeros = new int[5];

            string[] palavras = new string[5];

           
            Console.WriteLine("Digite cinco números: \n");

            for(int i = 0; i < numeros.Length; i++) {
                Console.Write($"{i + 1}° número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
                                 
            Console.WriteLine("\nDigite cinco Palavras: \n");

            for(int i = 0; i < palavras.Length; i++) {
                Console.Write($"{i + 1}° palavra: ");
                palavras[i] = Console.ReadLine();
            }

            Console.WriteLine("\nTodas as palavras registradas\n");

            int soma = 0;

            for(int i = 0; i < palavras.Length; i++) {
                Console.WriteLine($"A {i + 1}° entrada de dados foi o número {numeros[i]}" +
                    $" e a palavra {palavras[i]} ");

                    soma += numeros[i];
            }

            Console.WriteLine($"\nA soma de todos os números digitados foi: {soma}\n");

            

        }
    }
}
