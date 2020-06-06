using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Modelo
{
    public class ValoresFixosModelo
    {
        public class Unit
        {
            public string Nome { get; set; }
            public int Id { get; set; }
            public double Valor { get; set; }
            public bool Ativo { get; set; }
            public string Movimentacao { get; set; }
            public int CodigoEstabelecimento { get; set; }
            public string Observacao { get; set; }
        }
        public class List
        {
            public List<Unit> ListEstabelecimento { get; set; }
        }
    }
}
