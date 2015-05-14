using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EXPO.BusinessEntity;
using EXPO.DataAccess;

namespace EXPO.BusinessLogic
{
    public class BL_SolicitudAtencion
    {

        public String Insertar_SolicitudAtencion(BE_SolicitudAtencion oBE_SolicitudAtencion)
        {
            DA_SolicitudAtencion oDA_SolicitudAtencion = new DA_SolicitudAtencion();
            return oDA_SolicitudAtencion.Insertar_SolicitudAtencion(oBE_SolicitudAtencion);
        }
        public String Eliminar_SolicitudAtencion(BE_SolicitudAtencion oBE_SolicitudAtencion)
        {
            DA_SolicitudAtencion oDA_SolicitudAtencion = new DA_SolicitudAtencion();
            return oDA_SolicitudAtencion.Eliminar_SolicitudAtencion(oBE_SolicitudAtencion);
        }

        public String Modificar_SolicitudAtencion(BE_SolicitudAtencion oBE_SolicitudAtencion)
        {
            DA_SolicitudAtencion oDA_SolicitudAtencion = new DA_SolicitudAtencion();
            return oDA_SolicitudAtencion.Modificar_SolicitudAtencion(oBE_SolicitudAtencion);
        }

        public List<BL_SolicitudAtencion> Listar_SolicitudAtencion(BE_SolicitudAtencion oBE_SolicitudAtencion)
        {
            DA_SolicitudAtencion oDA_SolicitudAtencion = new DA_SolicitudAtencion();
            return oDA_SolicitudAtencion.Listar_SolicitudAtencion(oBE_SolicitudAtencion);

        }

        public BE_ConocimientoEmbarque Listar_SolicitudAtencion_PorId(int iSolicitudAtencion)
        {
            DA_SolicitudAtencion oDA_SolicitudAtencion = new DA_SolicitudAtencion();
            return oDA_SolicitudAtencion.Listar_SolicitudAtencion_PorId(iSolicitudAtencion);

        }

    }
}
