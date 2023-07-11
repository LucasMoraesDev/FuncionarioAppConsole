using FuncionarioAppConsole.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioAppConsole.Interfaces
{

    public interface IFuncionarioRepository
    {

        void Exportar(Funcionario funcionario);
    }
}
