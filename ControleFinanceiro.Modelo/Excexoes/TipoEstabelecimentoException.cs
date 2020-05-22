using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Excexoes
{
    public class TipoEstabelecimentoException : Exception
    {
        public TipoEstabelecimentoException() { }
        public TipoEstabelecimentoException (string message) : base(message) { }
        public TipoEstabelecimentoException(string message, Exception ex) : base(message, ex) { }
    }
}
