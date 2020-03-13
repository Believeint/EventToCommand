using System;
using System.Collections.Generic;
using System.Text;

namespace EventToCommand1.Models
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Pessoa(int id, string nome, int idade, string cidade, string estado)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
