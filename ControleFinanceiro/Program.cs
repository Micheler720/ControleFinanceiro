﻿using ControleFinanceiro.Modelo.Helpers;
using ControleFinanceiro.Visao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //NHibernateHelper.GeraSchema();
            Application.Run(new Frm_Login());
        }
    }
}
