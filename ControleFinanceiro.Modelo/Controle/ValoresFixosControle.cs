using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Helpers;
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
        public void validaDespesasFixas(Valores_Fixos DespesaFixa)
        {
            NHibernateHelper.GeraSchema();
            var DespesaFixaNegocio = new ValoresFixosNegocio();
            DespesaFixaNegocio.ValidaDespesaFixa(DespesaFixa);
            var session = NHibernateHelper.AbreSession();
            var dao = new ValoresFixosDAO(session);
            dao.Adiciona(DespesaFixa);
            session.Close();
        }
    }
}
