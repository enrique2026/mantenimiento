//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Mant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Sist_Veh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Sist_Veh()
        {
            this.Tb_Mant_Detalle = new HashSet<Tb_Mant_Detalle>();
        }
    
        public string idSist_Veh { get; set; }
        public string desc_Sist_Veh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Mant_Detalle> Tb_Mant_Detalle { get; set; }
    }
}
