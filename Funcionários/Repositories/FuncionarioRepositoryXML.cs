using FuncionarioAppConsole.Entities;
using FuncionarioAppConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FuncionarioAppConsole.Repositories
{

    internal class FuncionarioRepositoryXML : IFuncionarioRepository
    {
        public void Exportar(Funcionario funcionario)
        {
            var xmlSerializer = new XmlSerializer(typeof(Funcionario));

            //abrindo o arquivo em modo de escrita
            var streamWriter = new StreamWriter("c:\\temp\\funcionario.xml");

            //escrevend os dados no arquivo
            xmlSerializer.Serialize(streamWriter, funcionario);

            streamWriter.Close();
        }
    }
}
