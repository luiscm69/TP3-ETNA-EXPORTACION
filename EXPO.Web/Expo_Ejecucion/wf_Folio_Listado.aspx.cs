using EXPO.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Expo_Ejecucion_wf_Folio_Listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Buscar_Click(object sender, EventArgs e)
    {
        DateTime fini = DateTime.Parse(txt_FechaZarpeFin.Text);
        DateTime iini = DateTime.Parse(txt_FechaZarpeIni.Text);


        BL_Folio oFolio = new BL_Folio();
        var res = oFolio.ListadoFolios(iini, fini);

        grvLIstado.DataSource = res;
        grvLIstado.DataBind();
    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("wf_Folio_Nuevo.aspx");
    }
}