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
    
    public partial class Tb_Ubigeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Ubigeo()
        {
            this.Tb_Cliente = new HashSet<Tb_Cliente>();
            this.Tb_Mecanico = new HashSet<Tb_Mecanico>();
        }
    
        public string cod_ubigeo { get; set; }
        public string IdDepa { get; set; }
        public string IdProv { get; set; }
        public string IdDist { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Cliente> Tb_Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Mecanico> Tb_Mecanico { get; set; }
    }
}
