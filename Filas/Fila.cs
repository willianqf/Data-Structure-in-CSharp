using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    public class Fila
    {
        /// <summary>
        /// Aponta para o primeiro nó da fila
        /// </summary>
        public No Primeiro { get; set; }

        /// <summary>
        /// Construtora Padrão
        /// </summary>
        public Fila()
        {
            Primeiro = null;
        }

        /// <summary>
        /// Enfileira a informação passada como parâmetro desse método (função)
        /// </summary>
        /// <param name="info">Informação a ser enfileirada</param>
        public void Enfileira(int info)
        {
            No novo = new No(info);

            // Descobrir se a fila está vazia
            if (EstaVazia() == true)
            {
                Primeiro = novo;
            }
            else
            {
                // Descobrir quem é o último
                No auxiliar = Primeiro;
                while (auxiliar.Proximo != null)
                {
                    auxiliar = auxiliar.Proximo;
                }

                auxiliar.Proximo = novo;
            }
        }

        public bool EstaVazia()
        {
            bool valorRetorno = false;

            if (Primeiro == null)
            {
                valorRetorno = true;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Remove o primeiro nó da fila. Se ele existir!
        /// </summary>
        /// <returns>A informação que o nó estava guardando</returns>
        public int Desenfileira()
        {
            int valorRetorno = 0;

            // Só desenfileirar se a fila não estiver vazia
            if (!EstaVazia())
            {
                valorRetorno = Primeiro.Info;
                Primeiro = Primeiro.Proximo;
            }

            return valorRetorno;
        }
    }
}
