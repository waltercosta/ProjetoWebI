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
    
    public partial class CONVENIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONVENIO()
        {
            this.CONSULTA = new HashSet<CONSULTA>();
            this.EXAME = new HashSet<EXAME>();
        }
    
        public int conv_id { get; set; }
        public string conv_nome { get; set; }
        public string conv_sigla { get; set; }
        public int conv_fone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTA> CONSULTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAME> EXAME { get; set; }
    }
}
