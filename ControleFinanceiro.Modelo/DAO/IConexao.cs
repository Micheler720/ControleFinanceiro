using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAO
{
    interface IConexao
    {
        bool conectar();
        bool desconectar();
    }
}
