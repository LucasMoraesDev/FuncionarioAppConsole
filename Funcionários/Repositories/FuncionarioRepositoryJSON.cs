using FuncionarioAppConsole.Entities;
using FuncionarioAppConsole.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioAppConsole.Repositories
{
    public class FuncionarioRepositoryJSON : IFuncionarioRepository
    {
        public void Exportar(Funcionario funcionario)
        {
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            //abrir um arquivo em mode de escrita
            var streamWriter = new StreamWriter("c:\\temp\\funcionario.json");

            //escrever os dados no arquivo
            streamWriter.WriteLine(json);

            //fechando o arquivo
            streamWriter.Close();
        }
    }
}
