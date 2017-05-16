using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;

namespace Clinica.Controllers
{
    [DataObject(true)]
    public class ExameController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<EXAME> selectExame(string nome, int id)
        {
            var context = new ClinicaEntities();
            return context.EXAME.Where(e => (e.exa_nome.Contains(nome) || nome == null)
                     && (e.exa_id == id || id == 0))
                    .ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int adcionarExame(EXAME exame)
        {
            var context = new ClinicaEntities();
            context.EXAME.Add(exame);
            return context.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static int deletarExame(EXAME exame)
        {
            var context = new ClinicaEntities();
            context.EXAME.Remove(exame);
            return context.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int atualizarExame(EXAME exame)
        {
            var context = new ClinicaEntities();
            context.EXAME.AddOrUpdate(exame);
            return context.SaveChanges();
        }
    }
}