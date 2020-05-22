using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Excexoes
{
    public class EstabelecimentoException : Exception
    {
        public EstabelecimentoException() { }
        public EstabelecimentoException(string message) : base (message){ }
        public EstabelecimentoException(string message , Exception ex) : base (message, ex) { }
    }
}
