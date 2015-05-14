using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Expo_Ejecucion_wf_SolicitudAtencion_Listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {


        }
    }

    protected void btn_Buscar_Click(object sender, EventArgs e)
    {
        /*BL_ConocimientoEmbarque oBL_ConocimientoEmbarque = new BL_ConocimientoEmbarque();
        BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = new BE_ConocimientoEmbarque();

        oBE_ConocimientoEmbarque.sEstado = dpl_Estado.SelectedValue;
        oBE_ConocimientoEmbarque.dtFechaZarpe_Ini = Convert.ToDateTime(txt_FechaZarpeIni.Text);
        oBE_ConocimientoEmbarque.dtFechaZarpe_Fin = Convert.ToDateTime(txt_FechaZarpeFin.Text);

        grv_Listado.DataSource = oBL_ConocimientoEmbarque.Listar_ConocimientoEmbarque(oBE_ConocimientoEmbarque);
        grv_Listado.DataBind();*/

    }

    protected void grv_Listado_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataKey dataKey;
            dataKey = this.grv_Listado.DataKeys[e.Row.RowIndex];

            if (dataKey.Values["iIdConocimientoEmbarque"] != null)
            {
                //BE_ConocimientoEmbarque oBE_ConocimientoEmbarque = (e.Row.DataItem as BE_ConocimientoEmbarque);

                e.Row.Style["cursor"] = "pointer";
                e.Row.Attributes["onmousemove"] = String.Format("javascript: fc_SeleccionaFilaSimple(this)");

                if (e.Row.Cells[8].Controls.Count > 0)
                {
                    ImageButton ibtn_Actualizar = (ImageButton)e.Row.Cells[8].Controls[0];
                    ImageButton ibtn_Eliminar = (ImageButton)e.Row.Cells[9].Controls[0];

                    //ibtn_Actualizar.OnClientClick = String.Format("javascript:return fc_AbrirPagina({0},'{1}');", oBE_ConocimientoEmbarque.iIdConocimientoEmbarque, "Actualizar");
                    //ibtn_Eliminar.OnClientClick = String.Format("javascript:return fc_ValidarEliminar({0});", oBE_ConocimientoEmbarque.iIdConocimientoEmbarque);

                }

            }
        }
    }

}