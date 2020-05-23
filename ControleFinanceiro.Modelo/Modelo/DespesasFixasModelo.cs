using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Modelo
{
    public class DespesasFixasModelo
    {
        public string Nome { get; set; }
        public int Codigo { get; private set; }
        public double Valor { get; set; }
        public DespesasFixasModelo(int codigo)
        {
            Codigo = codigo;
        }
    }
}
