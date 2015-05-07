using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EXPO.BusinessLogic;
using EXPO.BusinessEntity;

public partial class Expo_Ejecucion_wf_ConocimientoEmbarque_Modificar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();
            BL_ConocimientoEmbarque oBL_ConocimientoEmbarque = new BL_ConocimientoEmbarque();
            ViewState["iIdCodigo"] = Request.QueryString["iIdCodigo"];

            oBE_ConocimientoEmbarque = oBL_ConocimientoEmbarque.Listar_ConocimientoEmbarque_PorId(Convert.ToInt32(ViewState["iIdCodigo"].ToString()));
            dpl_LineaNaviera.DataSource = oBL_ConocimientoEmbarque.Listar_LineaNaviera();
            dpl_LineaNaviera.DataTextField = "sDescripcion";
            dpl_LineaNaviera.DataValueField = "iIdLineaNaviera";
            dpl_LineaNaviera.DataBind();

            dpl_PuertoDestino.DataSource = oBL_ConocimientoEmbarque.Listar_Puerto();
            dpl_PuertoDestino.DataTextField = "sDescripcion";
            dpl_PuertoDestino.DataValueField = "iIdPuerto";
            dpl_PuertoDestino.DataBind();

            dpl_PuertoOrigen.DataSource = oBL_ConocimientoEmbarque.Listar_Puerto();
            dpl_PuertoOrigen.DataTextField = "sDescripcion";
            dpl_PuertoOrigen.DataValueField = "iIdPuerto";
            dpl_PuertoOrigen.DataBind();

            dpl_TipoCarga.DataSource = oBL_ConocimientoEmbarque.Listar_TipoCarga();
            dpl_TipoCarga.DataTextField = "sDescripcion";
            dpl_TipoCarga.DataValueField = "iIdTipoCarga";
            dpl_TipoCarga.DataBind();

            txt_Peso.Text = oBE_ConocimientoEmbarque.dPeso.ToString();
            txt_FechaZarpe.Text = oBE_ConocimientoEmbarque.dtFechaZarpe.ToString();
            txt_Cantidad.Text = oBE_ConocimientoEmbarque.iCantidad.ToString();
            dpl_LineaNaviera.SelectedValue = oBE_ConocimientoEmbarque.iIdLineaNaviera.ToString();
            dpl_PuertoDestino.SelectedValue = oBE_ConocimientoEmbarque.iIdPtoDestino.ToString();
            dpl_PuertoOrigen.SelectedValue = oBE_ConocimientoEmbarque.iIdPtoOrigen.ToString();
            dpl_TipoCarga.SelectedValue = oBE_ConocimientoEmbarque.iTipoCarga.ToString();
            txt_Consignatario.Text = oBE_ConocimientoEmbarque.sConsignatario;
            txt_NumeroBL.Text = oBE_ConocimientoEmbarque.sNumeroBL;


        }
    }
    protected void btn_Grabar_Click(object sender, EventArgs e)
    {
        BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();
        BL_ConocimientoEmbarque oBL_ConocimientoEmbarque = new BL_ConocimientoEmbarque();
        string sResultado = String.Empty;

        oBE_ConocimientoEmbarque.iIdConocimientoEmbarque = Convert.ToInt32(ViewState["iCodigo"].ToString()); 
        oBE_ConocimientoEmbarque.dPeso = Convert.ToDecimal(txt_Peso.Text);
        oBE_ConocimientoEmbarque.dtFechaZarpe = Convert.ToDateTime(txt_FechaZarpe.Text);
        oBE_ConocimientoEmbarque.iCantidad = Convert.ToInt32(txt_Cantidad.Text);
        oBE_ConocimientoEmbarque.iIdLineaNaviera = Convert.ToInt32(dpl_LineaNaviera.SelectedValue);
        oBE_ConocimientoEmbarque.iIdPtoDestino = Convert.ToInt32(dpl_PuertoDestino.SelectedValue);
        oBE_ConocimientoEmbarque.iIdPtoOrigen = Convert.ToInt32(dpl_PuertoOrigen.SelectedValue);
        oBE_ConocimientoEmbarque.iTipoCarga = Convert.ToInt32(dpl_TipoCarga.SelectedValue);
        oBE_ConocimientoEmbarque.sConsignatario = txt_Consignatario.Text;
        oBE_ConocimientoEmbarque.sNumeroBL = txt_NumeroBL.Text;

        sResultado = oBL_ConocimientoEmbarque.Modificar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);

    }
}