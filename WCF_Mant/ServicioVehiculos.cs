using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioVehiculos" en el código y en el archivo de configuración a la vez.
    public class ServicioVehiculos : IServicioVehiculos
    {
        
        public List<VehiculoDC> ListarVehiculosFechas(String strVehiculo, DateTime fecini, DateTime fecfin)
        {
            MANTENIMIENTO mant = new MANTENIMIENTO();
            try
            {
                List<VehiculoDC> list = new List<VehiculoDC>();

                var query = mant.usp_VehiculoFechas(strVehiculo, fecini, fecfin);

                foreach (var resultado in query)
                {
                    VehiculoDC objVeh = new VehiculoDC();

                    objVeh.idVehiculo = resultado.idVehiculo;                    
                    objVeh.Fec_Mant_Inic = Convert.ToDateTime(resultado.Fec_Mant_Inic);
                    objVeh.Fec_Mant_Fin = Convert.ToDateTime(resultado.Fec_Mant_Fin);
                    objVeh.tipo_mantenimiento = Convert.ToSingle(resultado.tipo_mantenimiento);
                    objVeh.Nom_mec = resultado.Nom_mec;
                    objVeh.Ape_mec = resultado.Ape_mec;
                    objVeh.idMecanico = resultado.idMecanico;
                    objVeh.Tipo_Trans = Convert.ToSingle(resultado.Tipo_Trans);
                    objVeh.idMarca = resultado.idMarca;
                    objVeh.TipoUnidad=resultado.TipoUnidad;
                    objVeh.Tipo_Unidad =Convert.ToSingle(objVeh.Tipo_Unidad);
                    objVeh.Nom_cli = resultado.Nom_cli;
                    objVeh.Ape_cli = resultado.Ape_cli;

                    list.Add(objVeh);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
