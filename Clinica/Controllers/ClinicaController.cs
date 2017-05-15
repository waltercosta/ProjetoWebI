using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace Clinica.Controllers
{
    [DataObject(true)]
    public class ClinicaController 
    {



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public bool cadastrar(MEDICO m)
        {

            return false;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public bool deletar(MEDICO m)
        {
            return false;
        }
    }
}