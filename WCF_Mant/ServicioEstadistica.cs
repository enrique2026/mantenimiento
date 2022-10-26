using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstadistica" en el código y en el archivo de configuración a la vez.
    public class ServicioEstadistica : IServicioEstadistica
    {        
        MANTENIMIENTO mant = new MANTENIMIENTO();
        public List<ClienteEstadistica> RankingClientesAño(Int16 año, Int16 top)
        {
            try
            {
                List<ClienteEstadistica> objLista = new List<ClienteEstadistica>();
                var query = mant.usp_RankingClieMantAños(año).Take(top);
                foreach (var item in query)
                {
                    ClienteEstadistica objClienteEstadistica = new ClienteEstadistica();
                    objClienteEstadistica.Nombres = item.NOMBRES;
                    objClienteEstadistica.TotalMantenimientos = Convert.ToSingle(item.TotalMant);
                    objLista.Add(objClienteEstadistica);
                }
                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MecanicoEstadistica> RankingMecanicoMantAño(Int16 año, Int16 top)
        {
            try
            {
                List<MecanicoEstadistica> objLista = new List<MecanicoEstadistica>();
                var query = mant.usp_RankingMantMecAños(año).Take(top);
                foreach (var item in query)
                {
                    MecanicoEstadistica objMecanicoEstadistica = new MecanicoEstadistica();
                    objMecanicoEstadistica.Nombres = item.NOMBRES;
                    objMecanicoEstadistica.TotalMantenimientos = Convert.ToSingle(item.TotalMant);
                    objLista.Add(objMecanicoEstadistica);
                }
                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VehiculoEstadistica> RankingVehiculoMantAño(Int16 año, Int16 top)
        {
            try
            {
                List<VehiculoEstadistica> objLista = new List<VehiculoEstadistica>();
                var query = mant.usp_RankingVehiculosMantAños(año).Take(top);
                foreach (var item in query)
                {
                    VehiculoEstadistica objVehiculoEstadistica = new VehiculoEstadistica();
                    objVehiculoEstadistica.Placa = item.PLACA;
                    objVehiculoEstadistica.TotalMantenimientos = Convert.ToSingle(item.TotalMant);
                    objLista.Add(objVehiculoEstadistica);
                }
                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }        
    }
}