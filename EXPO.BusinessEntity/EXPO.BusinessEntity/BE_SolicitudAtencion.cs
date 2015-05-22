using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_SolicitudAtencion
    {

        int _iIdSolicitudAtencion;

        public int IIdSolicitudAtencion
        {
            get { return _iIdSolicitudAtencion; }
            set { _iIdSolicitudAtencion = value; }
        }

        String _sResponsable;

        public String SResponsable
        {
            get { return _sResponsable; }
            set { _sResponsable = value; }
        }

        String _sEstado;

        public String SEstado
        {
            get { return _sEstado; }
            set { _sEstado = value; }
        }

        String _sObservacion;

        public String SObservacion
        {
            get { return _sObservacion; }
            set { _sObservacion = value; }
        }

        int _iIdRequerimiento;

        public int IIdRequerimiento
        {
            get { return _iIdRequerimiento; }
            set { _iIdRequerimiento = value; }
        }

    }
}
