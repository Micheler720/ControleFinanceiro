using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Entidades
{
    public class Estabelecimento
    {
        public virtual string Nome { get; set; }
        public virtual int Id { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Bairro { get; set; }
        public virtual int Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual Tipo_Estabelecimento Tipo_Estabelecimento { get; set; }
        public virtual string CEP { get; set; }
        public virtual string Estado { get; set; }
        public virtual Usuario UsEstabelecimento { get; set; }
    }
}
