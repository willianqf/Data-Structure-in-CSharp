using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaVetor
{
    public enum OPCOES
    {
        Indefinido = -1,
        Sair = 0,
        Enfileirar = 1,
        Desenfileirar = 2,
        Imprimir = 3
    }

    class Program
    {
        static bool Enfileirar(int[] fila, int elemento, int primeiro)
        {
            bool valorRetorno = false;
            int posicao = -1;

            for (int i = primeiro; i < fila.Length; i++)
            {
                if (fila[i] == 0)
                {
                    posicao = i;
                    break;
                }
            }

            if (posicao > -1)
            {
                fila[posicao] = elemento;
                valorRetorno = true;
            }

            return valorRetorno;
        }

        static int Desenfileirar(int[] fila, int primeiro)
        {
            int valorRetorno = -1;

            if (!EstaVazia(fila, primeiro))
            {
                valorRetorno = fila[primeiro];
            }

            return valorRetorno;
        }

        static void Imprimir(int[] fila, int primeiro)
        {
            if (!EstaVazia(fila, primeiro))
            {
                for (int i = primeiro; i < fila.Length; i++)
                {
                    if (fila[i] != 0)
                    {
                        Console.Write(fila[i] + ", ");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static bool EstaVazia(int[] fila, int primeiro)
        {
            bool valorRetorno = false;

            if (primeiro < fila.Length)
            {
                if (fila[primeiro] == 0)
                {
                    valorRetorno = true;
                }
            }

            return valorRetorno;
        }

        static void Main(string[] args)
        {
            // Elemento auxiliar para a fila
            int elemento;

            // Determina o tamanho da fila
            const int tamanho = 10;

            // Vetor que vai representar a fila
            int[] fila = new int[tamanho];

            // indicará o primeiro elemento (nó) da fila
            // -1 significa que não tem nada na fila
            int primeiro = 0;

            // Apresentar um menu de opções para o usuario
            OPCOES opcao = OPCOES.Indefinido;

            do
            {
                //Console.Clear();
                Console.WriteLine("Escolha");
                Console.WriteLine("[0] - Sair");
                Console.WriteLine("[1] - Enfileirar");
                Console.WriteLine("[2] - Desenfileirar");
                Console.WriteLine("[3] - Imprimir");
                Console.WriteLine("Opção: ");

                try
                {
                    opcao = (OPCOES)int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um valor entre 0 e 3!");
                }

                switch (opcao)
                {
                    case OPCOES.Sair:
                        Console.WriteLine("Obrigado por utilizar os nossos serviços de fila!");
                        break;

                    case OPCOES.Enfileirar:
                        elemento = -1;
                        do
                        {
                            Console.WriteLine("Informe o elemento: ");

                            try
                            {
                                elemento = int.Parse(Console.ReadLine());
                                if (elemento < 0)
                                {
                                    Console.WriteLine("Digite um valor maior que zero!");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Informe um valor maior que zero!");
                            }

                        } while (elemento <= 0);

                        if (Enfileirar(fila, elemento, primeiro) == true)
                        {
                            Console.WriteLine("O elemento " + elemento + " entrou na fila!");
                        }
                        else
                        {
                            Console.WriteLine("A fila está lotada!");
                        }

                        break;

                    case OPCOES.Desenfileirar:
                        elemento = Desenfileirar(fila, primeiro);
                        if (elemento < 0)
                        {
                            Console.WriteLine("A fila estava vazia!");
                        }
                        else
                        {
                            primeiro++;
                            Console.WriteLine("O elemento " + elemento + " acabou de sair!");
                        }

                        break;

                    case OPCOES.Imprimir:
                        Imprimir(fila, primeiro);
                        break;

                    default:
                        break;
                }

                /*switch (opcao)
                {
                    case 0:
                        break;

                    case 1:
                        Enfileirar(fila, 1);
                        break;

                    case 2:
                        Desenfileirar(fila);
                        break;

                    case 3:
                        Imprimir(fila);
                        break;

                    default:
                        break;
                }*/

            } while (opcao != OPCOES.Sair);

        }
    }
}
