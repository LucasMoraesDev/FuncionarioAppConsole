using FuncionarioAppConsole.Entities;
using FuncionarioAppConsole.Interfaces;
using FuncionarioAppConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioAppConsole.Controllers
{
    /// <summary>
    /// Classe de controle para o fluxo de cadastro de funcionario
    /// </summary>
    public class FuncionarioController
    {
        /// <summary>
        /// Método para executar o cadastro de um funcionario
        /// </summary>
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n*** CADASTRO DE FUNCIONARIO ***\n");

                var funcionario = new Funcionario();

                Console.Write("NOME.....................: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("CPF......................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("MATRÍCULA................: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("DATA ADMISSÃO............: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("CARGO....................: ");
                funcionario.Cargo = Console.ReadLine();

                Console.Write("SALÁRIO..................: ");
                funcionario.Salario = decimal.Parse(Console.ReadLine());


                Console.Write("\nESCOLHA XML OU JSON......: ");
                var opcao = Console.ReadLine();

                IFuncionarioRepository funcionarioRepository = null;

                switch (opcao)
                {
                    case "XML":
                        funcionarioRepository = new FuncionarioRepositoryXML();
                        break;
                    case "JSON":
                        funcionarioRepository = new FuncionarioRepositoryJSON();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                //exportando o arquivo
                funcionarioRepository.Exportar(funcionario);

                Console.WriteLine("\nFUNCIONÁRIO CADASTRADO COM SUCESSO!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nOcorreram erros de validação no preenchimento dos dados:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar funcionario!");
                Console.WriteLine(e.Message);
            }
        }
    }

}



