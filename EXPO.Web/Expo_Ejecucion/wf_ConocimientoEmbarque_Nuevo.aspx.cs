using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EXPO.BusinessEntity;
using EXPO.BusinessLogic;

public partial class Expo_Ejecucion_wf_ConocimientoEmbarque_Nuevo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();
            BL_ConocimientoEmbarque oBL_ConocimientoEmbarque = new BL_ConocimientoEmbarque();
            List<BE_LineaNaviera> oLis_BE_LineaNaviera = new List<BE_LineaNaviera>();
            List<BE_TipoCarga> oLis_BE_TipoCarga = new List<BE_TipoCarga>();
            List<BE_Puerto> oLis_BE_Puerto = new List<BE_Puerto>();



            oLis_BE_LineaNaviera = oBL_ConocimientoEmbarque.Listar_LineaNaviera();
            dpl_LineaNaviera.Items.Add(new ListItem("[Seleccionar]", "-1"));
            for (int i = 0; i < oLis_BE_LineaNaviera.Count; ++i)
            {
                dpl_LineaNaviera.Items.Add(new ListItem(oLis_BE_LineaNaviera[i].sDescripcion.ToString(), oLis_BE_LineaNaviera[i].iIdLineaNaviera.ToString()));
            }
            dpl_LineaNaviera.SelectedIndex = -1;



            oLis_BE_Puerto = oBL_ConocimientoEmbarque.Listar_Puerto();
            dpl_PuertoDestino.Items.Add(new ListItem("[Seleccionar]", "-1"));
            for (int i = 0; i < oLis_BE_Puerto.Count; ++i)
            {
                dpl_PuertoDestino.Items.Add(new ListItem(oLis_BE_Puerto[i].sDescripcion.ToString(), oLis_BE_Puerto[i].iIdPuerto.ToString()));
            }
            dpl_PuertoDestino.SelectedIndex = -1;

            oLis_BE_Puerto = oBL_ConocimientoEmbarque.Listar_Puerto();
            dpl_PuertoOrigen.Items.Add(new ListItem("[Seleccionar]", "-1"));
            for (int i = 0; i < oLis_BE_Puerto.Count; ++i)
            {
                dpl_PuertoOrigen.Items.Add(new ListItem(oLis_BE_Puerto[i].sDescripcion.ToString(), oLis_BE_Puerto[i].iIdPuerto.ToString()));
            }
            dpl_PuertoOrigen.SelectedIndex = -1;


            oLis_BE_TipoCarga = oBL_ConocimientoEmbarque.Listar_TipoCarga();
            dpl_TipoCarga.Items.Add(new ListItem("[Seleccionar]", "-1"));
            for (int i = 0; i < oLis_BE_TipoCarga.Count; ++i)
            {
                dpl_TipoCarga.Items.Add(new ListItem(oLis_BE_TipoCarga[i].sDescripcion.ToString(), oLis_BE_TipoCarga[i].iIdTipoCarga.ToString()));
            }
            dpl_TipoCarga.SelectedIndex = -1;

           
        }
    }
    protected void btn_Grabar_Click(object sender, EventArgs e)
    {

        BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();
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

        Response.Write("<script language=javascript>alert('El conocimiento de embarque N# ha sido registrado correctamente');</script>");
        limpiar();

    }

    private void limpiar() {
        this.txt_Consignatario.Text = "";
        this.txt_NumeroBL.Text = "";
        this.txt_Peso.Text = "";
        this.txt_Cantidad.Text = "";
        this.txt_FechaZarpe.Text = "";
        this.txt_DescripcionCarga.Text = "";
        dpl_PuertoOrigen.SelectedIndex = -1;
        dpl_PuertoDestino.SelectedIndex = -1;
        dpl_TipoCarga.SelectedIndex = -1;
        dpl_LineaNaviera.SelectedIndex = -1;
        
    }
    protected void btn_Limpiar_Click(object sender, EventArgs e)
    {
        limpiar();
    }
}