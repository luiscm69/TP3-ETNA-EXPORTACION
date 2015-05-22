using EXPO.BusinessEntity;
using EXPO.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Expo_Ejecucion_wf_Folio_Nuevo : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if(!Page.IsPostBack)
        {
            CargarCombos();
            Session["ListaDatos"] = null;
        }
        
    }

    private void CargarCombos()
    {
        BL_Folio oBlFolio = new BL_Folio();
        var datos = oBlFolio.Listar_TipoDocumento();

        ddlTipoDocumento.DataTextField = "var_Descripcion";
        ddlTipoDocumento.DataValueField = "var_codigo";
        ddlTipoDocumento.DataSource = datos;
        ddlTipoDocumento.DataBind();
    }

    protected void ddlTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtNumeroDocumento.Text = ddlTipoDocumento.SelectedValue;
    }
    protected void btnAgregarDocumento_Click(object sender, EventArgs e)
    {

        List<BE_FolioDespachoDetalle> lstFolios = null;
        if (Session["ListaDatos"] == null)
        {
            lstFolios = new List<BE_FolioDespachoDetalle>();
            Session["ListaDatos"] = lstFolios;
        }
        else
        {
            lstFolios = (List<BE_FolioDespachoDetalle>)Session["ListaDatos"];
        }

        var dato = new BE_FolioDespachoDetalle();
        dato.dFechaRegistro = DateTime.Now;
        dato.iIdFolioDespacho = 0;
        dato.sCodigoTipoDocumento = txtNumeroDocumento.Text;
        dato.sDescripcionTipoDocumento = ddlTipoDocumento.SelectedItem.Text;
             
        lstFolios.Add(dato);
        
        grvDocumentos.DataSource = lstFolios;
        grvDocumentos.DataBind();
    }
    protected void btnGrabarFolio_Click(object sender, EventArgs e)
    {
        BE_FolioCabecera oFolioCab = new BE_FolioCabecera();
        oFolioCab.IdCliente = Int32.Parse(htxtIdCliente.Value);
        oFolioCab.IdRequerimiento = Int32.Parse(htxtIdRequerimiento.Value);
        oFolioCab.Estado = "R";
        oFolioCab.FechaDespacho = DateTime.Parse(txtFechaDespacho.Text);

        oFolioCab.ListFolioDetalle = (List<BE_FolioDespachoDetalle>)Session["ListaDatos"];
        BL_Folio oFolio = new BL_Folio();
        var res = oFolio.Insertar_Folio(oFolioCab);


    }
    protected void btnConsultarNroRequerimiento_Click(object sender, EventArgs e)
    {
        var CodReq = txtNroRequerimiento.Text;
        BL_Folio oFolio = new BL_Folio();
        var datocab = oFolio.Obtener_RequerimientoCab(CodReq);

        txtCliente.Text = datocab.Field<string>("var_razonsocial");

        htxtIdCliente.Value = Convert.ToString(datocab.Field<Int32>("id_cliente"));
        htxtIdRequerimiento.Value = Convert.ToString(datocab.Field<Int32>("id_requerimiento"));


        //htxtIdCliente.Value = datocab.Field<string>("id_cliente");
        //htxtIdRequerimiento.Value = datocab.Field<string>("id_requerimiento");

        var datodet = oFolio.Listar_Requerimientos(CodReq);
        grvRequerimiento.DataSource = datodet;
        grvRequerimiento.DataBind();
        
    }
}