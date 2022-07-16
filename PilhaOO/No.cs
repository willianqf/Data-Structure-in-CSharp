using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// Pilha TAD (Tipo Abstrato de Dados)
namespace PilhaOO
{
    public class No
    {
        /// <summary>
        /// Informação a ser empilhada
        /// </summary>
        public char Info { get; set; }

        /// <summary>
        /// Indica o nó que está por baixo
        /// </summary>
        public No Embaixo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public No()
        {
            Info = char.MinValue;
            Embaixo = null;
        }

        /// <summary>
        /// Construtora
        /// </summary>
        /// <param name="info">Informação a ser salva no nó</param>
        public No(char info)
        {
            Info = info;
            Embaixo = null;
        }
    }
}
