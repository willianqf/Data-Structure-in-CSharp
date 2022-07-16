using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Vectra
 *  Omega
 *  Opala
 *  Gol Quadrado
 *  Uno
 * 
 */


/* 
 */

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random(DateTime.Now.Millisecond);

            // Empilhar
            Console.WriteLine("Estacionar");
            Carro c1 = new Carro(n);
            Carro c2 = new Carro(n);
            Carro c3 = new Carro(n);

            Elevador principal = new Elevador();
            principal.Estacionar(c1);
            principal.Estacionar(c2);
            principal.Estacionar(c3);

            principal.Listar();
            Console.WriteLine("Sair");

            Elevador Manobras = new Elevador();
            bool achou = false;
            Carro saida = c1;

            while (achou == false)
            {
                if (principal.Topo == saida)
                {
                    principal.Retirar();
                    achou = true;

                    while (Manobras.Topo != null)
                    {
                        principal.Estacionar(Manobras.Retirar());
                    }
                }
                else
                {
                    Manobras.Estacionar(principal.Retirar());
                }
            }
            Console.WriteLine("O carro " + saida.Imprimir() + " saiu");
            principal.Listar();

        }
    }
}
