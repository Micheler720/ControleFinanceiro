using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Entidades
{
    public class Fin_Receber
    {
        public virtual int Id { get; set; }
        public virtual string Documento { get; set; }
        public virtual DateTime Data_Lancamento { get; set; }
        public virtual DateTime Data_Inclusao { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual double Valor { get; set; }
        public virtual string Observacao { get; set; }
        public virtual int Importado { get; set; }
        public virtual DateTime Data_Pagamento { get; set; } 
        public virtual int Parcela { get; set; }
        public virtual Usuario UsLancamento { get; set; }

    }
}
