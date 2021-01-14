using NHibernate.Mapping.ByCode.Impl;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Entidades
{
    public class Usuario
    {
        public virtual string Nome {get; set;}
        public virtual string Email {get; set; }
        public virtual string Senha {get; set; }
        public virtual int Sexo {get; set; }
        public virtual int Id {get; set; }
        public virtual string Foto {get; set; }
    }
}
