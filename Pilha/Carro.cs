using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public enum Marcas
    {
        Indefinido,
        Fiat,
        Chevrovet,
        Ford,
        Mazda,
        Ferrari,
        Renault,
        Peugeot,
        Citroen,
        Toyota,
        VolksWagen,
        Audi
    }

    public class Carro
    {
        /// <summary>
        /// Marca do carro
        /// </summary>
        public Marcas Marca { get; set; }

        /// <summary>
        /// Modelo do carro
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Placa do carro
        /// </summary>
        public string Placa { get; set; }

        public Carro Embaixo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public Carro(Random n)
        {           
            string[] Modelos = { "Fiat 147", "Corsa", "Gol Quadrado", "Opala", "Uno", "Passat", "RX8" };
            Marca = (Marcas)n.Next(1, 11);
            Modelo = Modelos[n.Next(0, 6)];
            Placa = string.Format("{0}{1}{2}-{3}{4}{5}{6}",
                                   (char)n.Next(65, 90), // 0
                                   (char)n.Next(65, 90), // 1 
                                   (char)n.Next(65, 90), // 2
                                   n.Next(0, 9),         // 3
                                   n.Next(0, 9),         // 4
                                   n.Next(0, 9),         // 5
                                   n.Next(0, 9));        // 6
            Embaixo = null;
        }

        public Carro(Marcas marca, string modelo, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Embaixo = null;
        }

        public string Imprimir()
        {
            return string.Format("Marca: {0} - Modelo {1} - Placa: {2}",
                   Marca.ToString(),
                   Modelo,
                   Placa);
        }
    }
}
