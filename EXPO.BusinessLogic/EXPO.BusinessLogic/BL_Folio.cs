using EXPO.BusinessEntity;
using EXPO.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EXPO.BusinessLogic
{
    public class BL_Folio
    {
        public String Insertar_Folio(BE_FolioCabecera oFolioCabecera)
        {
            if (!oFolioCabecera.ListFolioDetalle.Any() || oFolioCabecera.ListFolioDetalle == null)
                throw new Exception("El folio tiene que tener un detalle");

            DA_Folio oDa_Folio = new DA_Folio();
            return oDa_Folio.Insertar_Folio(oFolioCabecera);
        }

        public DataTable Listar_TipoDocumento()
        {
            DA_Folio oDa_Folio = new DA_Folio();
            return oDa_Folio.Listar_TipoDocumento();

        }

        public DataRow Obtener_RequerimientoCab(string CodigoReq)
        {
            DA_Folio oDa_Folio = new DA_Folio();
            DataTable dt = oDa_Folio.Obtener_RequerimientoCab(CodigoReq);
            if (dt != null && dt.Rows.Count >= 0)
                return dt.Rows[0];
            return null;

        }

        public DataTable Listar_Requerimientos(string CodigoReq)
        {
            DA_Folio oDa_Folio = new DA_Folio();
            DataTable dt = oDa_Folio.Listar_Requerimientos(CodigoReq);
            return dt;

        }

        public DataTable ListadoFolios(DateTime FInicial, DateTime FFinal)
        {
            DA_Folio oDa_Folio = new DA_Folio();
            DataTable dt = oDa_Folio.ListadoFolios(FInicial, FFinal);
            return dt;
        }
    }
}
