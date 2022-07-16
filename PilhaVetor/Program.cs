using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaVetor
{
    class Program
    {
        const int tamanho = 10;

        static bool push(int[] pilha, int info, int topo)
        {
            bool valorRetorno = false;

            if (topo < tamanho-1)
            {
                Console.Write(info + ", ");
                pilha[topo+1] = info;
                valorRetorno = true;
            }

            return valorRetorno;
        }

        static int pop(int[] pilha, ref int topo)
        {
            int valorRetorno = 0;

            if (topo >= 0)
            {
                valorRetorno = pilha[topo];
                topo--;
                Console.Write(valorRetorno + ", ");
            }

            return valorRetorno;
        }

        static void Main(string[] args)
        {    
            /*   Topo
             *  -1
             *     0  1  2  3  4  5  6  7  8  9
             *     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
             * 
             */
            int[] pilha = new int[tamanho];
            int topo = -1;

            Console.WriteLine("Empilhando");

            if (push(pilha, 1, topo)) topo++;
            if (push(pilha, 2, topo)) topo++;
            if (push(pilha, 3, topo)) topo++;
            if (push(pilha, 4, topo)) topo++;
            if (push(pilha, -5, topo)) topo++;
            if (push(pilha, 6, topo)) topo++;
            if (push(pilha, 7, topo)) topo++;
            if (push(pilha, 8, topo)) topo++;
            if (push(pilha, 9, topo)) topo++;
            if (push(pilha, 10, topo)) topo++;
            if (push(pilha, 11, topo)) topo++;

            Console.WriteLine();
            Console.WriteLine("Desempilhando");

            int info;
            for (int i = 100; i >= 0; i--)
            {
                info = pop(pilha, ref topo);
            }

            Console.WriteLine();
        }
    }
}
