using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    public class No
    {
        /// <summary>
        /// Propriedade responsável por guardar a informação a ser enfileirada
        /// </summary>
        public int Info { get; set; }

        /// <summary>
        /// Aponta para o próximo nó da fila
        /// </summary>
        public No Proximo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public No()
        {
            Info = 0;
            Proximo = null;
        }

        /// <summary>
        /// Construtora
        /// </summary>
        /// <param name="info">Informação a ser armazenada no nó</param>
        public No(int info)
        {
            Info = info;
            Proximo = null;
        }
    }
}
