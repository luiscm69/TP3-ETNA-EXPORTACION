<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="wf_SolicitudAtencion_Nuevo.aspx.cs" Inherits="Expo_Ejecucion_wf_SolicitudAtencion_Nuevo" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="4">
                    REGISTRAR NUEVA SOLICITUD DE ATENCIÓN</td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    Responsable
                </td>
                <td>
                    <asp:TextBox ID="txt_Responsable" runat="server"></asp:TextBox>    
                </td>
                <td>
                    Observaciones:</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Estado</td>
                <td>
                    <asp:DropDownList ID="ddl_Estado" runat="server">
                    </asp:DropDownList>
                </td>
                <td colspan="2" rowspan="2">
                    <asp:TextBox ID="txt_Observ" runat="server" Height="72px" TextMode="MultiLine" 
                        Width="273px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>Datos del Requerimiento Asociado</td>
            </tr>
            <tr>
                <td>
                    Código de Requerimiento</td>
                <td>
                    <asp:TextBox ID="txt_Codigo" runat="server"></asp:TextBox>
                </td>
                <td>
                    Razon Social</td>
                <td>
                    <asp:TextBox ID="txt_RazonSocial" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Ruc</td>
                <td>
                    <asp:TextBox ID="txt_Ruc" runat="server"></asp:TextBox>
                </td>
                <td>
                    Dirección
                </td>
                <td>
                    <asp:TextBox ID="txt_Direccion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Destino</td>
                <td>
                    <asp:TextBox ID="txt_Destino" runat="server"></asp:TextBox>
                </td>
                <td>
                    Iata</td>
                <td>
                    <asp:TextBox ID="txt_Iata" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Fecha de Creación</td>
                <td>
                    <asp:TextBox ID="txt_FecCreacion" runat="server"></asp:TextBox></td>
                </td>                    
                <td>
                    Fecha Requerida</td>
                <td>
                    <asp:TextBox ID="txt_FecRequerida" runat="server"></asp:TextBox></td>
                </td>     
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td  align="center" colspan="4">
                    <asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" OnClick="btn_Limpiar_Click" />
                    &nbsp;<asp:Button ID="btn_Grabar" runat="server" Text="Grabar" 
                        onclick="btn_Grabar_Click" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td  align="center" colspan="4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>

</asp:Content>