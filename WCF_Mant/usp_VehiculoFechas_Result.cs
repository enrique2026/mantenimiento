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
    
    public partial class usp_VehiculoFechas_Result
    {
        public string idVehiculo { get; set; }
        public System.DateTime Fec_Mant_Inic { get; set; }
        public System.DateTime Fec_Mant_Fin { get; set; }
        public int tipo_mantenimiento { get; set; }
        public string TipoMantenimiento { get; set; }
        public string Nom_mec { get; set; }
        public string Ape_mec { get; set; }
        public string idMecanico { get; set; }
        public Nullable<int> Tipo_Trans { get; set; }
        public string TipoTransmision { get; set; }
        public string idMarca { get; set; }
        public Nullable<int> Tipo_Unidad { get; set; }
        public string TipoUnidad { get; set; }
        public string Nom_cli { get; set; }
        public string Ape_cli { get; set; }
    }
}
