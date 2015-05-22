using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_FolioDespachoDetalle
    {
        public int iIdFolioDespachoDet { get; set; }

        public int iIdFolioDespacho { get; set; }

        public int iIdTipoDocumento { get; set; }

        public string sEstado { get; set; }

        public DateTime dFechaRegistro { get; set; }

        public string sCodigoTipoDocumento { get; set; }

        public string sDescripcionTipoDocumento { get; set; }



    }
}
