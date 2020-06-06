using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.CodeDom;
using ControleFinanceiro.Modelo.Entidades;
using Google.Protobuf.WellKnownTypes;

namespace ControleFinanceiro.Modelo
{
    public class TipoEstabelecimentoModelo 
    {
        public class Unit
        {
        }
        public class List
        {
            public List<Unit> ListTipoEstabelecimento { get; set; }
        }
    }
}
