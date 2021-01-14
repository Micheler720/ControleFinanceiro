using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Entidades
{
    public class Tipo_Estabelecimento
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual int Status { get; set; }
        public virtual IList<Estabelecimento> Estabelecimentos { get; set; }
        public virtual Usuario UsTipoEstabelecimento { get; set; }
    }
}
