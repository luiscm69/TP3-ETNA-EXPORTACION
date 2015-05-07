using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_TipoCarga
    {
        #region "campos"
          int _iIdTipoCarga;
          String _sDescripcion;
          String _sEstado;

        #endregion

        #region "Propiedades"


          public int iIdTipoCarga
        {
            get { return _iIdTipoCarga; }
            set { _iIdTipoCarga = value; }

        }
          public String sDescripcion
        {
            get { return _sDescripcion; }
            set { _sDescripcion = value; }

        }


          public String sEstado
        {
            get { return _sEstado; }
            set { _sEstado = value; }

        }

      
    }

   #endregion
}


