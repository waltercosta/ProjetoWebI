//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinica
{
    using System;
    using System.Collections.Generic;
    
    public partial class EXAME
    {
        public int exa_id { get; set; }
        public string exa_nome { get; set; }
        public string exa_observacoes { get; set; }
        public int pac_id { get; set; }
        public decimal exa_valor { get; set; }
        public int conv_id { get; set; }
    
        public virtual CONVENIO CONVENIO { get; set; }
        public virtual PACIENTE PACIENTE { get; set; }
    }
}
