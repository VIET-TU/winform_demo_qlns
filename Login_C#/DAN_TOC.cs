//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login_C_
{
    using System;
    using System.Collections.Generic;
    
    public partial class DAN_TOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAN_TOC()
        {
            this.HSNVs = new HashSet<HSNV>();
        }
    
        public string ma_dan_toc { get; set; }
        public string ten_dan_toc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HSNV> HSNVs { get; set; }
    }
}
