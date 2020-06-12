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
        public string Mensagem { get; internal set; }
        public void GravarDespesasFixas(Valores_Fixos DespesaFixa)
        {
            var DespesaFixaNegocio = new ValoresFixosNegocio();

            if (DespesaFixaNegocio.ValidaDespesaFixa(DespesaFixa)) 
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new ValoresFixosDAO(session);
                dao.Adiciona(DespesaFixa);
                session.Close();
                Mensagem = "Dados inseridos com sucesso";
            }
            
        }
        public void AlterarDespesasFixas(Valores_Fixos DespesaFixa)
        {
            var DespesaFixaNegocio = new ValoresFixosNegocio();

            if (DespesaFixaNegocio.ValidaDespesaFixa(DespesaFixa))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new ValoresFixosDAO(session);
                dao.Alterar(DespesaFixa);
                session.Close();
                Mensagem = "Dados alterados com sucesso";
            }

        }
        public void ExcluirDespesaFixas(Valores_Fixos DespesaFixa)
        {
            var DespesaFixaNegocio = new ValoresFixosNegocio();

            if (DespesaFixaNegocio.ValidaDespesaFixa(DespesaFixa))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new ValoresFixosDAO(session);
                dao.Excluir(DespesaFixa);
                session.Close();
                Mensagem = "Dados excluidos com sucesso";
            }

        }
        public List<List<string>> BuscarDespesasFixas()
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new ValoresFixosDAO(session);
            var valoresFixos = dao.BuscarDespesas();
            session.Close();
            return valoresFixos;
        }

        public Valores_Fixos BuscarDespesasFixasId(int id)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new ValoresFixosDAO(session);
            var valorFixo = dao.BuscarDespesaId(id);
            session.Close();
            return valorFixo;
        }


    }
}
