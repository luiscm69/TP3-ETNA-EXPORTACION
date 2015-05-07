using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_LineaNaviera
    {
        #region "Campos"
        int _iIdLineaNaviera;
        String _sDescripcion;
        String _sRepresentante;
        String _sEstado;
        #endregion

        #region "Propiedades"

        public String sEstado
        {
            get { return _sEstado; }
            set { _sEstado = value; }

        }


        public String sRepresentante
        {
            get { return _sRepresentante; }
            set { _sRepresentante = value; }

        }

        public String sDescripcion
        {
            get { return _sDescripcion; }
            set { _sDescripcion = value; }

        }

        public int iIdLineaNaviera
        {
            get { return _iIdLineaNaviera; }
            set { _iIdLineaNaviera = value; }

        }
       
   #endregion



    }
}
