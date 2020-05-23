using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Modelo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Controle
{
    public class ValoresFixosControle
    {
        public void validaDespesasFixas(ValoresFixosModelo DespesaFixa)
        {
            var DespesaFixaNegocio = new ValoresFixosNegocio();
            DespesaFixaNegocio.ValidaDespesaFixa(DespesaFixa);
        }
    }
}
