using Aula19.Controller;
using Aula19.Domain;
using Aula19.Service;
using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa que você está pesquisando");
            string nome = Console.ReadLine();
            
            PessoaController pessoaController = new PessoaController();
            Pessoa pessoa = pessoaController.Obter(nome);
            Console.WriteLine($"Nome: {pessoa.Nome}, CPF: {pessoa.CPF}, Endereço: {pessoa.Endereco}");

            /*Pessoa pessoa = new Pessoa();
            
            Console.WriteLine("Digite o nome da pessoa.");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            pessoa.CPF = Console.ReadLine();
            Console.WriteLine("Digite o endereço");
            pessoa.Endereco = Console.ReadLine();

            PessoaController pessoaController = new PessoaController();
            string retorno = pessoaController.Inserir(pessoa);

            Console.WriteLine($"O retorno é: {retorno}.");*/
        }
    }
}
