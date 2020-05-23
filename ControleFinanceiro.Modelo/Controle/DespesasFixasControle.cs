using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Modelo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Controle
{
    public class DespesasFixasControle
    {
        public void validaDespesasFixas(DespesasFixasModelo DespesaFixa)
        {
            var DespesaFixaNegocio = new DespesasFixasNegocio();
            DespesaFixaNegocio.ValidaDespesaFixa(DespesaFixa);
        }
    }
}
