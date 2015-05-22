using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_FolioCabecera
    {
        public int IdFolio { get; set; }

        public int IdRequerimiento { get; set; }

        public int IdCliente { get; set; }

        public DateTime FechaDespacho { get; set; }

        public string Estado { get; set; }
                
        public List<BE_FolioDespachoDetalle> ListFolioDetalle { get; set; }
    }
}
