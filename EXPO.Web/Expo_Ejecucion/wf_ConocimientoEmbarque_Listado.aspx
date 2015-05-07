<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.master" CodeFile="wf_ConocimientoEmbarque_Listado.aspx.cs" Inherits="Expo_Ejecucion_wf_ConocimientoEmbarque_Listado" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <div>
    
        <table style="width:80%;">
            <tr>
                <td>
                    Estado</td>
                <td>
                    <asp:DropDownList ID="dpl_Estado" runat="server">
                        <asp:ListItem Value="1">Registrado</asp:ListItem>
                        <asp:ListItem Value="2">En Proceso</asp:ListItem>
                        <asp:ListItem Value="3">Atendido</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Fecha Zarpe inicla</td>
                <td>
                    <asp:TextBox ID="txt_FechaZarpeIni" runat="server"></asp:TextBox>
                </td>
                <td>
                    Fecha Zarpe Final</td>
                <td>
                    <asp:TextBox ID="txt_FechaZarpeFin" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" 
                        onclick="btn_Buscar_Click" Width="61px" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btn_Nuevo" OnClientClick="javascript:return fc_AbrirPagina(0,'Nuevo');" runat="server" Text="Nuevo" 
                        onclick="btn_Buscar_Click" Width="61px" />
                </td>
            </tr>
        </table>
    
    </div>
    <table style="width:80%;">
        <tr>
            <td>
                <asp:GridView DataKeyNames="iIdConocimientoEmbarque" ID="grv_Listado" 
                    AutoGenerateColumns="False" runat="server" 
                    onrowdatabound="grv_Listado_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField= "iIdConocimientoEmbarque" HeaderText="Código"  />
                        <asp:BoundField DataField= "sNumeroBL" HeaderText="Número BL"  />
                        <asp:BoundField DataField= "sConsignatario" HeaderText="Consignatario"  />
                        <asp:BoundField DataField= "sPuertoDestino" HeaderText="Puerto Destino"  />
                        <asp:BoundField DataField= "sTipoCarga" HeaderText="Tipo Carga"  />
                        <asp:BoundField DataField= "sLineaNaviera" HeaderText="Linea Naviera"  />
                        <asp:BoundField DataField= "dtFechaZarpe" HeaderText="Fecha Zarpe"  />
                        <asp:BoundField DataField= "sEstado" HeaderText="Estado"  />
                       <asp:ButtonField ButtonType="Image" CommandName="OpenProcesoEspecial" HeaderText="-"
                        ImageUrl="~/Script/Imagenes/IconButton/DO_Icon.png" Text="Modificar Conocimiento de Embarque">
                        <HeaderStyle />
                        <ItemStyle HorizontalAlign="Center" Width="2%" />
                       </asp:ButtonField>

                       <asp:ButtonField ButtonType="Image" CommandName="OpenProcesoEspecial" HeaderText="-"
                        ImageUrl="~/Script/Imagenes/IconButton/DO_Icon.png" Text="Eliminar Conocimiento de Embarque">
                        <HeaderStyle />
                        <ItemStyle HorizontalAlign="Center" Width="2%" />
                       </asp:ButtonField>

                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
<script type="text/jscript" language="javascript">
    function fc_AbrirPagina(iCodigo, sTipo) {
        if (sTipo != "Nuevo") {
            url = "wf_ConocimientoEmbarque_Modificar.aspx?iIdCodigo=" + iCodigo + "&Tipo=" + sTipo;
            window.open(url, 'Lista', 'toolbar=no,left=0,top=0,width=700px,height=350px, directories=no, status=no, scrollbars=yes, resizable=yes, menubar=no');
        } else {

        url = "wf_ConocimientoEmbarque_Nuevo.aspx";
            window.open(url, 'Lista', 'toolbar=no,left=0,top=0,width=700px,height=350px, directories=no, status=no, scrollbars=yes, resizable=yes, menubar=no');
        }
        return false;
    }

    function fc_ValidarEliminar(iCodigo) {
      
        if (confirm('Esta Seguro de eliminar el Conocimiento de Embarque Nro: ' + iCodigo)) {

            return true;
        } else {
            return false;
        }

    }

    var objFilaAnt = null;
    var backgroundColorFilaAnt = "";

    function fc_SeleccionaFilaSimple(objFila) {
        try {
            if (objFilaAnt != null) {
                objFilaAnt.style.backgroundColor = backgroundColorFilaAnt;
            }
            objFilaAnt = objFila;
            backgroundColorFilaAnt = objFila.style.backgroundColor;
            objFila.style.backgroundColor = "#c4e4ff";
        }
        catch (e) {
            error = e.message;
        }
    }

</script>
</asp:Content>
