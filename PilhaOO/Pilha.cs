using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaOO
{
    public class Pilha
    {
        /// <summary>
        /// Indica o nó que está no topo da pilha
        /// </summary>
        public No Topo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public Pilha()
        {
            // Quando o topo é null a pilha está vazia
            Topo = null;
        }

        /// <summary>
        /// Verifica se a pilha está vazia
        /// </summary>
        /// <returns>true se estiver vazia e false caso contrário</returns>
        public bool EstaVazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }

        public void Push(char info)
        {
            // Crio o nó que vai guardar a informação
            No noNovo = new No(info);

            // indico que esse nó está em cima do topo
            noNovo.Embaixo = Topo;

            // Atualizo o topo para o nó novo, que acabou de ser
            // empilhado
            Topo = noNovo;
        }

        public char? Pop()
        {
            char? valorRetorno = null;

            if (!EstaVazia())
            {
                // Recupero a informação que está no topo
                valorRetorno = Topo.Info;

                // Atualizo o topo para o nó que está
                // por baixo do topo
                Topo = Topo.Embaixo;
            }

            return valorRetorno;
        }
    }
}
