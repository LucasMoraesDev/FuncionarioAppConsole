using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FuncionarioAppConsole.Entities
{
    //Modelo de dados da entidade Cliente
    public class Funcionario
    {
        //atributo da classe
        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _matricula;
        private DateTime _dataAdmissao;
        private string _cargo;
        private decimal _salario;

        //Método construtor [ctor + 2xtab]
        public Funcionario()
        {
            //gerando o id do cliente
            Id = Guid.NewGuid();
        }

        public Guid Id
        {
            get => _id;
            set => _id = value;
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Nome do cliente é obrigatório");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Nome do cliente inválido. Informe de 8 a 100 caracteres.");

                _nome = value;
            }
        }
        public string Cpf
        {
            get => _cpf;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("CPF do cliente é obrigatório");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("CPF do cliente inválido. Informe exatamente 11 números.");

                _cpf = value;
            }
        }

        public string Matricula { get => _matricula; set => _matricula = value; }
        public DateTime DataAdmissao { get => _dataAdmissao; set => _dataAdmissao = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public decimal Salario { get => _salario; set => _salario = value; }
    }
}