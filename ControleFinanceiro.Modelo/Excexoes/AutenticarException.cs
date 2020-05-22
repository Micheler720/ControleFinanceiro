using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Excexoes
{
    public class AutenticarException : Exception
    {
        public AutenticarException()
        {

        }
        public AutenticarException(string message) : base(message)
        {

        }
        public AutenticarException(string message, Exception e) : base(message , e)
        {

        }
    }
}
