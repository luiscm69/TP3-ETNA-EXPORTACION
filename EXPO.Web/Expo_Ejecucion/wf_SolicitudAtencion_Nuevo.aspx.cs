using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EXPO.BusinessEntity;
using EXPO.BusinessLogic;

public partial class Expo_Ejecucion_wf_SolicitudAtencion_Nuevo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Grabar_Click(object sender, EventArgs e)
    {

        if ((txt_Responsable.Text).Equals(""))
        {
            Response.Write("<script language=javascript>alert('Debe ingresar el responsable');</script>");
        }
        else
        {

            BE_SolicitudAtencion oBE_ConocimientoEmbarque = new BE_SolicitudAtencion();
            BL_ConocimientoEmbarque oBL_ConocimientoEmbarque = new BL_ConocimientoEmbarque();
            string sResultado = String.Empty;

            oBE_ConocimientoEmbarque.dPeso = Convert.ToDecimal(txt_Peso.Text);
            oBE_ConocimientoEmbarque.dtFechaZarpe = Convert.ToDateTime(txt_FechaZarpe.Text);
            oBE_ConocimientoEmbarque.iCantidad = Convert.ToInt32(txt_Cantidad.Text);
            oBE_ConocimientoEmbarque.iIdLineaNaviera = Convert.ToInt32(dpl_LineaNaviera.SelectedValue);
            oBE_ConocimientoEmbarque.iIdPtoDestino = Convert.ToInt32(dpl_PuertoDestino.SelectedValue);
            oBE_ConocimientoEmbarque.iIdPtoOrigen = Convert.ToInt32(dpl_PuertoOrigen.SelectedValue);
            oBE_ConocimientoEmbarque.iTipoCarga = Convert.ToInt32(dpl_TipoCarga.SelectedValue);
            oBE_ConocimientoEmbarque.sConsignatario = txt_Consignatario.Text;
            oBE_ConocimientoEmbarque.sDescripcionCarga = txt_DescripcionCarga.Text;
            oBE_ConocimientoEmbarque.sNumeroBL = txt_NumeroBL.Text;

            sResultado = oBL_ConocimientoEmbarque.Insertar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);

            Response.Write("<script language=javascript>alert('La Solicitud de Atención ha sido registrado correctamente');</script>");
            limpiar();

        }

    }

    private void limpiar()
    {
        txt_Codigo.Text = "";
        txt_Destino.Text = "";
        txt_Direccion.Text = "";
        txt_FecCreacion.Text = "";
        txt_FecRequerida.Text = "";
        txt_Iata.Text = "";
        txt_Observ.Text = "";
        txt_RazonSocial.Text = "";
        txt_Responsable.Text = "";
        txt_Ruc.Text = "";
        ddl_Estado.SelectedIndex = -1;
    }

    protected void btn_Limpiar_Click(object sender, EventArgs e)
    {
        limpiar();
    }


}