using ControleFinanceiro.Modelo;
using ControleFinanceiro.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Controle
{
    class TipoEstabelecimentoControle
    {
        public void validaTipoEstabelecimento(TipoEstabelecimentoModelo tipoEstabelecimento)
        {
            var tipoEstabelecimentoNegocio = new TipoEstabelecimentoNegocio();

            if (tipoEstabelecimentoNegocio.validaTipoEstabelecimentoNegocio(tipoEstabelecimento))
            {

            }
        }
    }
}
