using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Elevador
    {
        /// <summary>
        /// Indica qual carro está no topo do elevador
        /// </summary>
        public Carro Topo { get; set; }

        public Elevador()
        {
            Topo = null;
        }

        public void Estacionar(Carro carro)
        {
            carro.Embaixo = Topo;
            Topo = carro;
        }

        public Carro Retirar()
        {
            Carro valorRetorno = null;
            if (Topo != null)
            {
                valorRetorno = Topo;
                Topo = Topo.Embaixo;
            }

            return valorRetorno;
        }

        public void Listar()
        {
            Carro aux = Topo;
            while(aux != null)
            {
                Console.WriteLine(aux.Imprimir());
                aux = aux.Embaixo;
            }
        }
    }
}
