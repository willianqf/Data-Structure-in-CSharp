using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            /*
            Console.WriteLine("Empilhando...");
            Console.WriteLine(10);
            pilha.Push(10);
            Console.WriteLine(3);
            pilha.Push(3);
            Console.WriteLine(21);
            pilha.Push(21);

            Console.WriteLine("A pilha está vazia?");
            Console.WriteLine(pilha.EstaVazia());

            Console.WriteLine("Desempilhando...");
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());

            Console.WriteLine("A pilha está vazia?");
            Console.WriteLine(pilha.EstaVazia());
            */

            Console.WriteLine();
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            if (palavra.Length > 0)
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    // push
                    pilha.Push(palavra[i]);
                }

                string saida = string.Empty;
                char? letra;
                // Pop
                do
                {
                    letra = pilha.Pop();
                    if (letra != null)
                    {
                        saida += letra;
                    }

                } while (letra != null);

                if (palavra.Equals(saida))
                {
                    Console.WriteLine("É palindromo!!!");
                }
                else
                {
                    Console.WriteLine("Não é palindromo!!!");
                }
            }
        }
    }
}
