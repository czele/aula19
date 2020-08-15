using Aula19.Domain;
using Aula19.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula19.Controller
{
    class PessoaController
    {
        public string Inserir(Pessoa pessoa)
        {
            PessoaService pessoaService = new PessoaService();
            return pessoaService.Inserir(pessoa);
        }

        public Pessoa Obter(string nome)
        {
            PessoaService pessoaService = new PessoaService();
            return pessoaService.Obter(nome);
        }
    }
}
