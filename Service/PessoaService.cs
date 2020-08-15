using System;
using System.Collections.Generic;
using System.Text;
using Aula19.Domain;
using Aula19.Repository;

namespace Aula19.Service
{
    class PessoaService
    {
        public string Inserir(Pessoa pessoa)
        {
            if (pessoa.Nome == "")
                return "Preenche o nome da pessoa:";
            if (pessoa.CPF.Length != 9)
                return "CPF precisa de 9 caracteres.";
            if (pessoa.Endereco == "")
                return "Preencha o endereço.";
            
            PessoaRepository pessoaRepository = new PessoaRepository();
            return pessoaRepository.Inserir(pessoa);
        }

        public Pessoa Obter(string nome)
        {
            if (nome == "")
                return new Pessoa();

            PessoaRepository pessoaRepository = new PessoaRepository();
            return pessoaRepository.Obter(nome);
        }
    }
}
