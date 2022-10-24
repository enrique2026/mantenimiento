using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioVehiculos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioVehiculos
    {
        [OperationContract]
        List<VehiculoDC> ListarVehiculosFechas(String strVehiculo, DateTime fecini, DateTime fecfin);      
    }

    [DataContract]
    [Serializable]
    public class VehiculoDC
    {
        [DataMember]
        public String idVehiculo { get; set; }
        
        [DataMember]
        public DateTime Fec_Mant_Inic { get; set; }
        [DataMember]
        public DateTime Fec_Mant_Fin { get; set; }
        [DataMember]
        public Single tipo_mantenimiento { get; set; }
        [DataMember]
        public String TipoMantenimiento { get; set; }
        [DataMember]        
        public String Nom_mec { get; set; }
        [DataMember]
        public String Ape_mec { get; set; }
        [DataMember]
        public String idMecanico  { get; set; }
        [DataMember]
        public Single  Tipo_Trans  { get; set; }
        [DataMember]
        public String TipoTransmision { get; set; }
        [DataMember]
        public String idMarca { get; set; }
        [DataMember]
        public Single Tipo_Unidad{ get; set; }
        
        [DataMember]
        public String  TipoUnidad { get; set; }
        [DataMember]
        public String Nom_cli { get; set; }
        [DataMember]
        public String Ape_cli { get; set; }
      
    }
}
