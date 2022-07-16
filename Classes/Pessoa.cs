using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pessoa
    {
        /// <summary>
        /// Nome da pessoa
        /// </summary>
        public string Nome { get; set; }

        private int Idade;

        public Pessoa()
        {
            Console.WriteLine("Informe o nome da pessoa");
            Nome = Console.ReadLine();
            Idade = 0;
            Imprimir();
        }

        public Pessoa(string nome)
        {
            Nome = nome;
            Idade = 0;
            Imprimir();
        }

        public void FazerAniversario()
        {
            Console.WriteLine("Feliz aniversário " + Nome + "!!!! \\o/");
            Idade += 1;
            Imprimir();
        }

        public int ObterIdade()
        {
            return Idade;
        }

        public void Imprimir()
        {
            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
