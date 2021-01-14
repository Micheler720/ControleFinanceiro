using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Entidades
{
    public class Valores_Fixos
    {
        public virtual string Nome { get; set; }
        public virtual int Id { get; set; }
        public virtual double Valor { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual string Movimentacao { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual string Observacao { get; set; }
        public virtual int DiaPagamento { get; set; }
        public virtual int Parcela { get; set; }
        public virtual Usuario UsValoresFixos { get; set; }
    }
}
