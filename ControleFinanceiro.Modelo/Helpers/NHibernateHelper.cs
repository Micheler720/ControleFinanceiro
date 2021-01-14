
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Helpers
{
    public class NHibernateHelper
    {
        private static ISessionFactory fabrica = CriarSessionFactory();
        private static ISessionFactory CriarSessionFactory()
        {
            var cfg = RecuperaConfiguracao();
            return cfg.BuildSessionFactory();
        }

        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.SetProperty("hbm2ddl.auto", "insert");
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            return cfg;
        }
        public static void GeraSchema()
        {
            var cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }
        public static void FechaSession()
        {
            fabrica.Close();
        }
        public static ISession AbreSession()
        {
            return fabrica.OpenSession();
        }
    }
}
