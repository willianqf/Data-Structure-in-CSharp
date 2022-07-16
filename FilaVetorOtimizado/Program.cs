using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FilaVetorOtimizado
{
    class Program
    {
        static bool Enfileira(int[] fila, int info, ref int ultimo)
        {
            bool valorRetorno = false;

            // Verifica se cabe na fila
            if (ultimo < fila.Length - 1)
            {
                ultimo++;
                fila[ultimo] = info;
                valorRetorno = true;
            }

            return valorRetorno;
        }

        static int Desenfileira(int[] fila, ref int ultimo)
        {
            int valorRetorno = -1;

            // verificar se não está vazia
            if (ultimo > -1)
            {
                valorRetorno = fila[0];

                // Deslocar todos os valores para a esquerda
                for (int i = 1; i <= ultimo; i++)
                {
                    fila[i - 1] = fila[i];
                }

                ultimo--;
            }

            return valorRetorno;
        }

        static void Main(string[] args)
        {
            // Determina o tamanho do vetor
            const int tamanho = 5;

            // Array a ser utilizado para gerenciar a fila
            int[] fila = new int[tamanho];

            // Indica que a fila está vazia
            int ultimo = -1;

            Enfileira(fila, 10, ref ultimo);
            Enfileira(fila, 11, ref ultimo);
            Enfileira(fila, 12, ref ultimo);
            Enfileira(fila, 13, ref ultimo);
            Enfileira(fila, 14, ref ultimo);

            int info = Desenfileira(fila, ref ultimo);
            Console.WriteLine(info);

            info = Desenfileira(fila, ref ultimo);
            Console.WriteLine(info);
            info = Desenfileira(fila, ref ultimo);
            Console.WriteLine(info);

            Enfileira(fila, 22, ref ultimo);
            Enfileira(fila, 20, ref ultimo);

            info = Desenfileira(fila, ref ultimo);
            Console.WriteLine(info);

            Enfileira(fila, 1, ref ultimo);
            Enfileira(fila, 2, ref ultimo);
            Enfileira(fila, 3, ref ultimo);
        }
    }
}
