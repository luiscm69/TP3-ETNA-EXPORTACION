using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_Puerto
    {
        #region "Campos"
        int _iIdPuerto;
        String _sCodigoISIM;
        String _sDescripcion;
        String _sEstado;
        int _iIdPais;
        
        #endregion

        #region "Propiedades"

        public int iIdPais
        {
            get { return _iIdPais; }
            set { _iIdPais = value; }

        }


        public int iIdPuerto
        {
            get { return _iIdPuerto; }
            set { _iIdPuerto = value; }

        }


        public String sCodigoISIM
        {
            get { return _sCodigoISIM; }
            set { _sCodigoISIM = value; }

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

        #endregion

    }
}
