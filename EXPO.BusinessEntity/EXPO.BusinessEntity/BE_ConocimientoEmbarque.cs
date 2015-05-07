using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXPO.BusinessEntity
{
    public class BE_ConocimientoEmbarque
    {
        #region "campos"


        int _iIdConocimientoEmbarque;
        String _sNumeroBL;
        int _iPtoOrigen;
        int _iPtoDestino;
        int _iLineaNaviera;
        decimal _dPeso;
        int _iCantidad;
        DateTime _dtFechaZarpe;           
        String _sConsignatario;                                  
        int _iTipoCarga;
        String _sDescripcionCarga;

        DateTime _dtFechaZarpe_Ini;
        DateTime _dtFechaZarpe_Fin;

        String _sPuertoDestino;
        String _sTipoCarga;
        String _sLineaNaviera;
        String _sEstado;
        int _iIdTipoCarga;
        String _sDescripcionEmbarque;

        #endregion


        #region "Propiedades"

        public int iIdTipoCarga
        {
            get { return _iIdTipoCarga; }
            set { _iIdTipoCarga = value; }

        }

        public String sDescripcionEmbarque
        {
            get { return _sDescripcionEmbarque; }
            set { _sDescripcionEmbarque = value; }

        }

        public String sEstado
        {
            get { return _sEstado; }
            set { _sEstado = value; }

        }

        public String sPuertoDestino
        {
            get { return _sPuertoDestino; }
            set { _sPuertoDestino = value; }

        }
        public String sTipoCarga
        {
            get { return _sTipoCarga; }
            set { _sTipoCarga = value; }

        }
        public String sLineaNaviera
        {
            get { return _sLineaNaviera; }
            set { _sLineaNaviera = value; }

        }

        public DateTime dtFechaZarpe_Ini
        {
            get { return _dtFechaZarpe_Ini; }
            set { _dtFechaZarpe_Ini = value; }

        }
        public DateTime dtFechaZarpe_Fin
        {
            get { return _dtFechaZarpe_Fin; }
            set { _dtFechaZarpe_Fin = value; }

        }
        public String sDescripcionCarga
        {
            get { return _sDescripcionCarga; }
            set { _sDescripcionCarga = value; }

        }
        public int iTipoCarga
        {
            get { return _iTipoCarga; }
            set { _iTipoCarga = value; }

        }


        public String sConsignatario
        {
            get { return _sConsignatario; }
            set { _sConsignatario = value; }

        }

        public DateTime dtFechaZarpe
        {
            get { return _dtFechaZarpe; }
            set { _dtFechaZarpe = value; }

        }

        public int iCantidad
        {
            get { return _iCantidad; }
            set { _iCantidad = value; }

        }

        public decimal dPeso
        {
            get { return _dPeso; }
            set { _dPeso = value; }

        }

        public int iIdLineaNaviera
        {
            get { return _iLineaNaviera; }
            set { _iLineaNaviera = value; }

        }

        public int iIdPtoDestino
        {
            get { return _iPtoDestino; }
            set { _iPtoDestino = value; }

        }
        public int iIdPtoOrigen
        {
            get { return _iPtoOrigen; }
            set { _iPtoOrigen = value; }
        }


        public String sNumeroBL
        {
            get { return _sNumeroBL; }
            set { _sNumeroBL = value; }
        }

        public int iIdConocimientoEmbarque
        {
            get { return _iIdConocimientoEmbarque; }
            set { _iIdConocimientoEmbarque = value; }
        }

    }

   #endregion
    }

