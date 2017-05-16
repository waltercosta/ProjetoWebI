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
    public class ConsultaController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<CONSULTA> selectConsulta(PACIENTE paciente, MEDICO medico, string turno)
        {
            var context = new ClinicaEntities();
            return context.CONSULTA.
                                Where(c => 
                                ((c.pac_id.Equals(paciente.pac_id) || paciente.Equals(null)) || (c.med_id.Equals(medico.med_id) || medico.Equals(null))) &&
                                (c.cons_turno.Contains(turno) || turno  == null)
                                ).ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int adcionarConsulta (CONSULTA consulta)
        {
            var context = new ClinicaEntities();
            context.CONSULTA.Add(consulta);
            return context.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static int deletarConsulta (CONSULTA consulta)
        {
            var context = new ClinicaEntities();
            context.CONSULTA.Remove(consulta);
            return context.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int atualizarConsulta ( CONSULTA consulta)
        {
            var context = new ClinicaEntities();
            context.CONSULTA.AddOrUpdate(consulta);
            return context.SaveChanges();
        }
    }
}