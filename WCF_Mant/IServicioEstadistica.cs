using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEstadistica" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEstadistica
    {
        [OperationContract]
        List<ClienteEstadistica> RankingClientesAño(Int16 año, Int16 top);
        [OperationContract]
        List<MecanicoEstadistica> RankingMecanicoMantAño(Int16 año, Int16 top);
        [OperationContract]
        List<VehiculoEstadistica> RankingVehiculoMantAño(Int16 año, Int16 top);        
    }

    [DataContract]
    [Serializable]
    public class ClienteEstadistica
    {
        [DataMember]
        public String Nombres { get; set; }
        [DataMember]
        public Single TotalMantenimientos { get; set; }
    }

    [DataContract]
    [Serializable]
    public class MecanicoEstadistica
    {
        [DataMember]
        public String Nombres { get; set; }
        [DataMember]
        public Single TotalMantenimientos { get; set; }
    }

    [DataContract]
    [Serializable]
    public class VehiculoEstadistica
    {
        [DataMember]
        public String Placa { get; set; }
        [DataMember]
        public Single TotalMantenimientos { get; set; }
    }   
}