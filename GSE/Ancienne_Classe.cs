//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ancienne_Classe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ancienne_Classe()
        {
            this.Classe_Details = new HashSet<Classe_Details>();
        }
    
        public string id { get; set; }
        public string surnom { get; set; }
        public Nullable<int> niveau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classe_Details> Classe_Details { get; set; }
    }
}
