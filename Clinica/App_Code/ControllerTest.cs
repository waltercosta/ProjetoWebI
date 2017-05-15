using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Clinica.App_Code
{
    [DataObject(true)]
    public class ControllerTest
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