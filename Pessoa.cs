using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } // as propriedades da classe são: nome e idade
        public int Idade { get; set; }

        public void Apresentar() // métodos servem para indicar AÇÃO para a classe
        {
            Console.WriteLine($"Olá, meu nome é {Nome} \n Eu tenho {Idade} anos");
            // \n faz quebra de linha no C#
        }
    }
}