using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /// <summary>
    /// Implementa a classe dog para criar objetos cachorros
    /// </summary>
    public class Dog
    {
        #region Propriedades

        /// <summary>
        /// Dono do doguinho
        /// </summary>
        public Pessoa Dono { get; set; }

        /// <summary>
        /// Nome do dog
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Ano Nascimento do doginho
        /// </summary>
        public int AnoNascimento { get; set; }

        private int Idade;

        #endregion

        #region Construtoras

        /// <summary>
        /// Construtora Padrão
        /// </summary>
        public Dog()
        {
            Nome = string.Empty;
            AnoNascimento = DateTime.MinValue.Year;
            Idade = 0;
        }

        /// <summary>
        /// Construtora
        /// </summary>
        /// <param name="nome">Nome do dog</param>
        /// <param name="ano">Ano de nascimento do dog</param>
        public Dog(string nome, int ano)
        {
            Nome = nome;
            AnoNascimento = ano;
            Idade = CalculaIdade();
        }

        public Dog(Pessoa dono, string nome, int ano)
        {
            Dono = dono;
            Nome = nome;
            AnoNascimento = ano;
            Idade = CalculaIdade();
        }

        #endregion

        #region Métodos
        private int CalculaIdade()
        {
            return DateTime.Now.Year - AnoNascimento;
        }

        /// <summary>
        /// Obtem a idade do doguinho
        /// </summary>
        /// <returns>a idade do doguinho</returns>
        public int ObterIdade()
        {
            return Idade;
        }

        /// <summary>
        /// Recalcula a idade do doguinho
        /// </summary>
        public void AlterarIdade()
        {
            Idade = CalculaIdade();
        }

        /// <summary>
        /// Imprime todos os dados do doguinho
        /// </summary>
        public void Imprime()
        {
            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("Ano  : " + AnoNascimento);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Dono : " + Dono.Nome);
        }

        #endregion
    }
}
