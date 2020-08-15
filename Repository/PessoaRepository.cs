using Aula19.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula19.Repository
{
    class PessoaRepository
    {
        public string Inserir(Pessoa pessoa)
        {
            return "Registro inserido com sucesso!";
        }

        public Pessoa Obter(string nome)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "José";
            pessoa.CPF = "987654321";
            pessoa.Endereco = "Rua 2";

            return pessoa;
        }
    }
}
