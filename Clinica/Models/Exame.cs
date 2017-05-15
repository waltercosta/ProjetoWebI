using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Exame
    {
        public string nome { get; set; }
        public int codigo { get; set; }
        public string observacoes { get; set; }
        public Paciente paciente { get; set; }
        public int valor { get; set; }
        public Convenio convenio { get; set; }
    }
}