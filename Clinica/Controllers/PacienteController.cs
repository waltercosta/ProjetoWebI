using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Data.Entity.Migrations;

namespace Clinica.Controllers
{
    [DataObject(true)]
    public class PacienteController
    {
        /*Usando entities*/
        #region Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<PACIENTE> selectPaciente(string nome, string cpf)
        {
            var context = new ClinicaEntities();
            return context.PACIENTE.Where(p => (p.pac_nome.Contains(nome) || nome == null)
                     && (p.pac_cpf.Contains(cpf) || cpf == null))
                    .ToList();
        }
        #endregion

        #region Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int adcionarPaciente (PACIENTE paciente)
        {
            var context = new ClinicaEntities();
            context.PACIENTE.Add(paciente);
            return context.SaveChanges();
        }
        #endregion

        #region Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static int deletarPaciente (PACIENTE paciente)
        {
            var context = new ClinicaEntities();
            context.PACIENTE.Remove(paciente);
            return context.SaveChanges();
        }
        #endregion

        #region Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int atualizarPaciente (PACIENTE paciente)
        {
            var context = new ClinicaEntities();
            context.PACIENTE.AddOrUpdate(paciente);
            return context.SaveChanges();
        }
#endregion
    }
}