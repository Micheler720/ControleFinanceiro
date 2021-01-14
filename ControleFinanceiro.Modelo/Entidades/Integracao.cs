using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Entidades
{
    public class Integracao
    {
        public virtual int Id { get; set; }
        public virtual string Usuario { get; set; }
        public virtual string Senha { get; set; }
        public virtual int TipoIntegracao { get; set; }
    }
}
