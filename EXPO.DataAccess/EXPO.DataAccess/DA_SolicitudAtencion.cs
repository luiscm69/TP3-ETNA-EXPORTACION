using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EXPO.DataAccess.BaseDatos;
using EXPO.BusinessEntity;


namespace EXPO.DataAccess
{
    public class DA_SolicitudAtencion
    {

        #region "Transaccion"

        public String Insertar_SolicitudAtencion(BE_SolicitudAtencion oBE_SolicitudAtencion)
        {            
             //  Finalidad               :   Graba un nuevo registro en la tabla conocimiento de embarque 
             //  Entradas                :  
             //  BE_ConocimientoEmbarque :   Una entidad de timpo Be_Conocimiento de Embarque             
             //  Resultados              :   Una cadena que retorna el estado de la ejecución  
            
            using (Database dbEtna = new Database())
            {
                try
                {
                    dbEtna.ProcedureName = "sps_Ins_ConocimientoEmbarque";
                    dbEtna.AddParameter("@vi_var_NumeroBL", DbType.String, ParameterDirection.Input, oBE_ConocimientoEmbarque.sNumeroBL);
                    dbEtna.AddParameter("@vi_id_PtoOrigen", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iIdPtoOrigen);
                    dbEtna.AddParameter("@vi_id_PtoDestino", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iIdPtoDestino);
                    dbEtna.AddParameter("@vi_id_LineaNaviera", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iIdLineaNaviera);
                    dbEtna.AddParameter("@vi_dec_Peso", DbType.Decimal, ParameterDirection.Input, oBE_ConocimientoEmbarque.dPeso);
                    dbEtna.AddParameter("@vi_int_Cantidad", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iCantidad);
                    dbEtna.AddParameter("@vi_dt_FechaZarpe", DbType.DateTime, ParameterDirection.Input, oBE_ConocimientoEmbarque.dtFechaZarpe);
                    dbEtna.AddParameter("@vi_var_Consignatario", DbType.String, ParameterDirection.Input, oBE_ConocimientoEmbarque.sConsignatario);
                    dbEtna.AddParameter("@vi_id_TipoCarga", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iTipoCarga);
                    dbEtna.AddParameter("@vi_var_DescripcionCarga", DbType.String, ParameterDirection.Input, oBE_ConocimientoEmbarque.sDescripcionCarga);
                    dbEtna.AddParameter("@vo_Resultado", DbType.String, ParameterDirection.Output, String.Empty, 300);
                    dbEtna.ExecuteTransaction();
                    String Retorno = dbEtna.GetParameter("@vo_Resultado").ToString();                    
                    return Retorno;
                }
                catch (Exception e)
                {
                    return "-1|Ocurrio un error en la capa de datos :"+  e.Message ;
                }
            }
        }
        public String Eliminar_SolicitudAtencion(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            //  Finalidad               :   Elimina un registro de la tabla conocimiento de embarque 
            //  Entradas                :  
            //  BE_ConocimientoEmbarque :   Una entidad de timpo Be_Conocimiento de Embarque             
            //  Resultados              :   Una cadena que retorna el estado de la ejecución  

            using (Database dbEtna = new Database())
            {
                try
                {
                    dbEtna.ProcedureName = "sps_Del_ConocimientoEmbarque";
                    dbEtna.AddParameter("@vi_id_ConocimientoEmbarque", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iIdConocimientoEmbarque);
                    dbEtna.AddParameter("@vo_Resultado", DbType.String, ParameterDirection.Output, String.Empty, 300);
                    dbEtna.ExecuteTransaction();
                    String Retorno = dbEtna.GetParameter("@vo_Retorno").ToString();
                    return Retorno;
                }
                catch (Exception e)
                {
                    return "-1| ocurrio un error :" + e.Message;
                }
            }
        }
        public String Modificar_SolicitudAtencion(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            //  Finalidad               :   Modifica un registro de la tabla conocimiento de embarque 
            //  Entradas                :  
            //  BE_ConocimientoEmbarque :   Una entidad de timpo Be_Conocimiento de Embarque             
            //  Resultados              :   Una cadena que retorna el estado de la ejecución 

            using (Database dbEtna = new Database())
            {
                try
                {
                    dbEtna.ProcedureName = "sps_upd_ConocimientoEmbarque";
                    dbEtna.AddParameter("@vi_id_ConocimientoEmbarque", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.iIdConocimientoEmbarque);
                    dbEtna.AddParameter("@vo_Resultado", DbType.String, ParameterDirection.Output, String.Empty, 300);
                    dbEtna.ExecuteTransaction();
                    String Retorno = dbEtna.GetParameter("@vo_Retorno").ToString();
                    return Retorno;
                }
                catch (Exception e)
                {
                    return "-1| ocurrio un error :" + e.Message;
                }
            }
        }
       

        #endregion

        #region "No Transaccionales"
        public List<BE_ConocimientoEmbarque> Listar_SolicitudAtencion(BE_ConocimientoEmbarque oBE_ConocimientoEmbarque)
        {
            //  Finalidad               :   Lista los registros de la tabla conocimiento de embarque dependiendo de los filtros
            //  Entradas                :  
            //  BE_ConocimientoEmbarque :   Una entidad de timpo Be_Conocimiento de Embarque             
            //  Resultados              :   Una lista de objetos de tipo conocimiento de embarque

            IDataReader reader = null;
            try
            {
                using (Database dbEtna = new Database())
                {
                    dbEtna.ProcedureName = "sps_Lis_ConocimientoEmbarque";
                    dbEtna.AddParameter("@vi_estado", DbType.Int32, ParameterDirection.Input, oBE_ConocimientoEmbarque.sEstado);
                    dbEtna.AddParameter("@vi_dt_fecha_zarpe_ini", DbType.DateTime, ParameterDirection.Input, oBE_ConocimientoEmbarque.dtFechaZarpe_Ini);
                    dbEtna.AddParameter("@vi_dt_fecha_Zarpe_fin", DbType.DateTime, ParameterDirection.Input, oBE_ConocimientoEmbarque.dtFechaZarpe_Fin);
                    reader = dbEtna.GetDataReader();
                    List<BE_ConocimientoEmbarque> oLis_ConocimientoEmbarque = new List<BE_ConocimientoEmbarque>();
                    while (reader.Read())
                    {
                        oLis_ConocimientoEmbarque.Add(Pu_ConocimientoEmbarque.Publicar_ConocimientoEmbarque(reader));
                    }
                    reader.Close();                   
                    return oLis_ConocimientoEmbarque;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public BE_ConocimientoEmbarque Listar_SolicitudAtencion_PorId(int iConocimientoEmbarque)
        {
            //  Finalidad               :   Lista un registro de la tabla conocimiento de embarque
            //  Entradas                :  
            //  BE_ConocimientoEmbarque :   Código de conocimiento de embarque             
            //  Resultados              :   un objeto de tipo Be_ConocimientoEmarque

            IDataReader reader = null;
            try
            {
                using (Database dbEtna = new Database())
                {
                    dbEtna.ProcedureName = "sps_Listar_PorId_ConocimientoEmbarque";
                    dbEtna.AddParameter("@vi_id_ConocimientoEmbarque", DbType.Int32, ParameterDirection.Input, iConocimientoEmbarque);                   
                    reader = dbEtna.GetDataReader();
                    List<BE_ConocimientoEmbarque> oLis_ConocimientoEmbarque = new List<BE_ConocimientoEmbarque>();
                    while (reader.Read())
                    {
                        oLis_ConocimientoEmbarque.Add(Pu_ConocimientoEmbarque.Publicar_ConocimientoEmbarque_PorId(reader));
                    }
                    reader.Close();
                    return oLis_ConocimientoEmbarque[0];
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }


        #region "Publicacion"
    class Pu_ConocimientoEmbarque
    {

        public static BE_ConocimientoEmbarque Publicar_ConocimientoEmbarque(IDataReader DReader)
        {
            //  Finalidad               :   Mapea los campos de la Base de datos con los atributos del Objeto
            //  Entradas                :  
            //  IDataReader             :   una fila de tipo Data Reader            
            //  Resultados              :   un objeto de tipo BE_ConocimientoEmbarque

            try
            {
                BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();
                int indice = 0;
                indice = DReader.GetOrdinal("id_ConocimientoEmbarque");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iIdConocimientoEmbarque = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("var_NumeroBL");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sNumeroBL = DReader.GetString(indice);
                indice = DReader.GetOrdinal("var_Consignatario");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sConsignatario = DReader.GetString(indice);
                indice = DReader.GetOrdinal("Puerto");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sPuertoDestino = DReader.GetString(indice);
                indice = DReader.GetOrdinal("TipoCarga");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sTipoCarga = DReader.GetString(indice);
                indice = DReader.GetOrdinal("LineaNaviera");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sLineaNaviera = DReader.GetString(indice);
                indice = DReader.GetOrdinal("dt_FechaZarpe");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.dtFechaZarpe = DReader.GetDateTime(indice);
                indice = DReader.GetOrdinal("Estado");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sEstado = DReader.GetString(indice);
                return oBE_ConocimientoEmbarque;
            }
            catch (Exception e)
            {
            
                return null;
            }


        }
        public static BE_ConocimientoEmbarque Publicar_ConocimientoEmbarque_PorId(IDataReader DReader)
        {
            //  Finalidad               :   Mapea los campos de la Base de datos con los atributos del Objeto
            //  Entradas                :  
            //  IDataReader             :   una fila de tipo Data Reader            
            //  Resultados              :   un objeto de tipo BE_ConocimientoEmbarque

            try
            {
                BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();
                int indice = 0;             
                indice = DReader.GetOrdinal("id_ConocimientoEmbarque");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iIdConocimientoEmbarque = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("var_NumeroBL");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sNumeroBL = DReader.GetString(indice);
                indice = DReader.GetOrdinal("id_PtoOrigen");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iIdPtoOrigen = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("id_PtoDestino");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iIdPtoDestino = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("id_LineaNaviera");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iIdLineaNaviera = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("dec_Peso");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.dPeso = DReader.GetDecimal(indice);
                indice = DReader.GetOrdinal("int_Cantidad");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iCantidad = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("dt_FechaZarpe");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.dtFechaZarpe = DReader.GetDateTime(indice);
                indice = DReader.GetOrdinal("var_Consignatario");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sConsignatario = DReader.GetString(indice);
                indice = DReader.GetOrdinal("id_TipoCarga");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.iIdTipoCarga = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("var_DescripcionCarga");
                if (!DReader.IsDBNull(indice)) oBE_ConocimientoEmbarque.sDescripcionEmbarque = DReader.GetString(indice);
                return oBE_ConocimientoEmbarque;

            }
            catch (Exception e)
            {              
                return null;
            }


        }

        public static BE_LineaNaviera Publicar_LineaNaviera(IDataReader DReader)
        {
            //  Finalidad               :   Mapea los campos de la Base de datos con los atributos del Objeto
            //  Entradas                :  
            //  IDataReader             :   una fila de tipo Data Reader            
            //  Resultados              :   un objeto de tipo BE_LineaNaviera

            try
            {
                BE_LineaNaviera oBE_LineaNaviera = new BE_LineaNaviera();
                int indice = 0;
                indice = DReader.GetOrdinal("id_LineaNaviera");
                if (!DReader.IsDBNull(indice)) oBE_LineaNaviera.iIdLineaNaviera = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("var_Descripcion");
                if (!DReader.IsDBNull(indice)) oBE_LineaNaviera.sDescripcion = DReader.GetString(indice);
                return oBE_LineaNaviera;
            }
            catch (Exception e)
            {              
                return null;
            }
        }
        public static BE_Puerto Publicar_Puerto(IDataReader DReader)
        {
            //  Finalidad               :   Mapea los campos de la Base de datos con los atributos del Objeto
            //  Entradas                :  
            //  IDataReader             :   una fila de tipo Data Reader            
            //  Resultados              :   un objeto de tipo BE_Puerto

            try
            {
                BE_Puerto oBE_Puerto = new BE_Puerto();
                int indice = 0;
                indice = DReader.GetOrdinal("id_Puerto");
                if (!DReader.IsDBNull(indice)) oBE_Puerto.iIdPuerto = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("var_Descripcion");
                if (!DReader.IsDBNull(indice)) oBE_Puerto.sDescripcion = DReader.GetString(indice);
                return oBE_Puerto;
            }
            catch (Exception e)
            {              
                return null;
            }
        }
        public static BE_TipoCarga Publicar_TipoCarga(IDataReader DReader)
        {
            //  Finalidad               :   Mapea los campos de la Base de datos con los atributos del Objeto
            //  Entradas                :  
            //  IDataReader             :   una fila de tipo Data Reader            
            //  Resultados              :   un objeto de tipo BE_TipoCarga
            try
            {
                BE_TipoCarga oBE_TipoCarga = new BE_TipoCarga();
                int indice = 0;
                indice = DReader.GetOrdinal("id_TipoCarga");
                if (!DReader.IsDBNull(indice)) oBE_TipoCarga.iIdTipoCarga = DReader.GetInt32(indice);
                indice = DReader.GetOrdinal("var_Descripcion");
                if (!DReader.IsDBNull(indice)) oBE_TipoCarga.sDescripcion = DReader.GetString(indice);
                return oBE_TipoCarga;
            }
            catch (Exception e)
            {              
                return null;
            }
        }
    }
    #endregion

    }
}
