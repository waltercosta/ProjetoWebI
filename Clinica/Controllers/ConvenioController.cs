using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using System.ComponentModel;

namespace Clinica.Controllers
{
    [DataObject(true)]
    public class ConvenioController
    {
        #region select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<CONVENIO> selectConvenio(string nome, int fone)
        {
            var context = new ClinicaEntities();
            return context.CONVENIO.Where(c => (c.conv_nome.Contains(nome) || nome == null) &&
            (c.conv_fone.Equals(fone) || fone == 0)).ToList();
        }
        #endregion

        #region Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int adcionarConvenio(CONVENIO convenio)
        {
            var context = new ClinicaEntities();
            context.CONVENIO.Add(convenio);
            return context.SaveChanges();
        }
        #endregion

        #region Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static int deletarConvenio (CONVENIO convenio)
        {
            var context = new ClinicaEntities();
            context.CONVENIO.Remove(convenio);
            return context.SaveChanges();
        }
        #endregion

        #region Updade
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int atualizarConvenio (CONVENIO convenio)
        {
            var context = new ClinicaEntities();
            context.CONVENIO.AddOrUpdate(convenio);
            return context.SaveChanges();
        }
        #endregion
    }
}