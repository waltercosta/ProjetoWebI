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
    
    public partial class PACIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTE()
        {
            this.CONSULTA = new HashSet<CONSULTA>();
            this.EXAME = new HashSet<EXAME>();
        }
    
        public int pac_id { get; set; }
        public string pac_nome { get; set; }
        public string pac_end { get; set; }
        public string pac_cpf { get; set; }
        public Nullable<int> pac_fone { get; set; }
        public System.DateTime pac_dataNasc { get; set; }
        public string pac_sexo { get; set; }
        public string pac_plano { get; set; }
        public string pac_estado { get; set; }
        public string pac_cidade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTA> CONSULTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAME> EXAME { get; set; }
    }
}
