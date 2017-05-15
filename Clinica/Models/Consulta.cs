using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Consulta
    {
        public Paciente paciente { get; set; }
        public Convenio convenio { get; set; }
        public Medico medico { get; set; }
        public DateTime dataConsulta { get; set; }
        public char turno { get; set; }
        public string situacao { get; set; }
    }
}