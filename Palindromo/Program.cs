using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        /* Descobrir se uma fórmula é bem formada
         * {1 + 2 * ((3 - 4) + ( 2 / 3 ))}
         * 
         * {1 + 2 ( 3 - 4 ( 2 * 8 ))}}
         * {1 + 2 ((3 - 4 (}
         * 
         * Usando a técnica de ED de PILHA, descobrir
         * se uma formula (string) é bem formada.
         */

        const int tamanho = 100;
        /*
         * OVO
         * UFU
         * ASA
         * ARARA
         * SOCORRAMMESUBINOONIBUSEMMARROCOS
         */

        static void Main(string[] args)
        {
            char[] pilha = new char[tamanho];
            int topo = -1;
            Console.WriteLine();
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            if (palavra.Length > 0)
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    // push
                    pilha[++topo] = palavra[i];
                }

                char letra;
                string saida = string.Empty;
                
                // Pop
                for (int i = topo; i >= 0; i--)
                {
                    letra = pilha[topo];
                    saida += letra;
                    topo--;
                }

                // Verificar se é palindromo
                Console.WriteLine("Entrada:");
                Console.WriteLine(palavra);
                Console.WriteLine("Saída:");
                Console.WriteLine(saida);
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
