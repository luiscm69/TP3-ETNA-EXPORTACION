using EXPO.BusinessEntity;
using EXPO.DataAccess.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EXPO.DataAccess
{
    public class DA_Folio
    {
        #region "Transaccionales"
        public String Insertar_Folio(BE_FolioCabecera oFolioCabecera)
        {
            int nroreg = 0;
            using (Database dbEtna = new Database())
            {
                try
                {
                    dbEtna.ProcedureName = "sps_Ins_Folio";
                    dbEtna.AddParameter("@id_requerimiento", DbType.Int32, ParameterDirection.Input, oFolioCabecera.IdRequerimiento);
                    dbEtna.AddParameter("@id_cliente", DbType.Int32, ParameterDirection.Input, oFolioCabecera.IdCliente);
                    dbEtna.AddParameter("@dt_fechadespacho", DbType.DateTime, ParameterDirection.Input, oFolioCabecera.FechaDespacho);
                    dbEtna.AddParameter("@chr_estado", DbType.String, ParameterDirection.Input, oFolioCabecera.Estado);
                    dbEtna.AddParameter("@dt_FechaRegistro", DbType.DateTime, ParameterDirection.Input, DateTime.Now);
                    dbEtna.AddParameter("@vo_Resultado", DbType.Int32, ParameterDirection.Output, String.Empty, 300);
                    dbEtna.ExecuteTransaction();
                    var Retorno = Int32.Parse("" + dbEtna.GetParameter("@vo_Resultado"));

                    if (Retorno > 0)
                    {
                        foreach (var foliodeta in oFolioCabecera.ListFolioDetalle)
                        {
                            dbEtna.ParameterClear();

                            dbEtna.ProcedureName = "sps_Ins_FolioDet";
                            dbEtna.AddParameter("@id_foliodespacho", DbType.Int32, ParameterDirection.Input, Retorno);
                            dbEtna.AddParameter("@cod_tipodocumento", DbType.String, ParameterDirection.Input, foliodeta.sCodigoTipoDocumento);
                            dbEtna.AddParameter("@chr_estado", DbType.String, ParameterDirection.Input, "1");
                            dbEtna.AddParameter("@vo_Resultado", DbType.Int32, ParameterDirection.Output, String.Empty, 300);

                            dbEtna.ExecuteTransaction();

                            var Retorno2 = Int32.Parse("" + dbEtna.GetParameter("@vo_Resultado"));
                            if (Retorno2 > 0) nroreg++;
                   
                        }
                    }
                    return Convert.ToString(nroreg);

                }
                catch (Exception e)
                {
                    return "-1|Ocurrio un error en la capa de datos :" + e.Message;
                }
            }
        }

        #endregion

        #region "No Transaccionales"

        public DataTable Listar_TipoDocumento()
        {
            DataTable dt = null;
            try
            {
                using (Database dbEtna = new Database())
                {
                    dbEtna.ProcedureName = "sps_Listar_TipoDocumento";
                    dt = dbEtna.GetDataSet().Tables[0];
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable Obtener_RequerimientoCab(string CodigoReq)
        {
            DataTable dt = null;
            try
            {
                using (Database dbEtna = new Database())
                {
                    dbEtna.ProcedureName = "sps_ListarClienteReq";
                    dbEtna.AddParameter("@cod_requerimiento", DbType.String, ParameterDirection.Input, CodigoReq);    
                    dt = dbEtna.GetDataSet().Tables[0];
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null;
            }


        }

        public DataTable Listar_Requerimientos(string CodigoReq)
        {
            DataTable dt = null;
            try
            {
                using (Database dbEtna = new Database())
                {
                    dbEtna.ProcedureName = "sps_ListarReqDet";
                    dbEtna.AddParameter("@cod_requerimiento", DbType.String, ParameterDirection.Input, CodigoReq);
                    dt = dbEtna.GetDataSet().Tables[0];
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable ListadoFolios(DateTime FInicial, DateTime FFinal)
        {
            DataTable dt = null;
            try
            {
                using (Database dbEtna = new Database())
                {
                    dbEtna.ProcedureName = "sps_Listarfolios";
                    dbEtna.AddParameter("@DT_FECHAINICIAL", DbType.DateTime, ParameterDirection.Input, FInicial);
                    dbEtna.AddParameter("@DT_FECHAFINAL", DbType.DateTime, ParameterDirection.Input, FFinal);

                    dt = dbEtna.GetDataSet().Tables[0];
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion
    }
}
