using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EXPO.BusinessEntity;
using EXPO.DataAccess;

namespace EXPO.BusinessLogic
{
    public class BL_ConocimientoEmbarque
    {
        public String Insertar_ConocimientoEmbarque(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Insertar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);
        }
        public String Eliminar_ConocimientoEmbarque(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Eliminar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);
        }

        public String Modificar_ConocimientoEmbarque(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Modificar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);
        }

        public List<BE_ConocimientoEmbarque> Listar_ConocimientoEmbarque(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Listar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);

        }

        public BE_ConocimientoEmbarque Listar_ConocimientoEmbarque_PorId(int iConocimientoEmbarque)
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Listar_ConocimientoEmbarque_PorId(iConocimientoEmbarque);

        }

        public List<BE_LineaNaviera> Listar_LineaNaviera()
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Listar_LineaNaviera();

        }

        public List<BE_Puerto> Listar_Puerto()
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Listar_Puerto();
        }

        public List<BE_TipoCarga> Listar_TipoCarga()
        {
            DA_ConocimientoEmbarque oDA_ConocimientoEmbarque = new DA_ConocimientoEmbarque();
            return oDA_ConocimientoEmbarque.Listar_TipoCarga();

        }
    }
}
