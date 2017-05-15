using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Medico
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cpf { get; set; }
        public int fone { get; set; }
        public string crm { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public int qtdAtendimento { get; set; }
    }
}