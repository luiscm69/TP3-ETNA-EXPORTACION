<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="wf_SolicitudAtencion_Listado.aspx.cs" Inherits="Expo_Ejecucion_wf_SolicitudAtencion_Listado" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContetn" runat="server" ContentPlaceHolderID="MainContent">

    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    Razon Social</td>
                <td>
                    <asp:TextBox ID="txt_RazonSocial" runat="server"></asp:TextBox>
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
                    Fecha Registro inicial</td>
                <td>
                    <asp:TextBox ID="txt_FechaIniReg" runat="server"></asp:TextBox>
                </td>
                <td>
                    Fecha Registro Final</td>
                <td>
                    <asp:TextBox ID="txt_FechaFinReg" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" 
                        onclick="btn_Buscar_Click" Width="61px" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <a href="wf_SolicitudAtencion_Nuevo.aspx">Nuevo</a></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>

    <table style="width:80%;">
        <tr>
            <td>
                <asp:GridView DataKeyNames="iIdSolicitudAtencion" ID="grv_Listado" 
                    AutoGenerateColumns="False" runat="server" 
                    onrowdatabound="grv_Listado_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField= "iIdSolicitudAtencion" HeaderText="Código"  />
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


</asp:Content>