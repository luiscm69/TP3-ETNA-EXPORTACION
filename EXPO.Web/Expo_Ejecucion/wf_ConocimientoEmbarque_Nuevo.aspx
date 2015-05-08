<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="wf_ConocimientoEmbarque_Nuevo.aspx.cs" Inherits="Expo_Ejecucion_wf_ConocimientoEmbarque_Nuevo" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="4">
                    REGISTRAR NUEVO CONOCIMIENTO DE EMBARQUE</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Puerto Origen</td>
                <td>
                    <asp:DropDownList ID="dpl_PuertoOrigen" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    Linea Naviera</td>
                <td>
                    <asp:DropDownList ID="dpl_LineaNaviera" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Puerto Destino</td>
                <td>
                    <asp:DropDownList ID="dpl_PuertoDestino" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    Tipo de Carga</td>
                <td>
                    <asp:DropDownList ID="dpl_TipoCarga" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Consignatario</td>
                <td>
                    <asp:TextBox ID="txt_Consignatario" runat="server"></asp:TextBox>
                </td>
                <td>
                    Descripción de la carga</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Número de BL</td>
                <td>
                    <asp:TextBox ID="txt_NumeroBL" runat="server"></asp:TextBox>
                </td>
                <td colspan="2" rowspan="4">
                    <asp:TextBox ID="txt_DescripcionCarga" runat="server" Height="72px" TextMode="MultiLine" 
                        Width="273px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Peso</td>
                <td>
                    <asp:TextBox ID="txt_Peso" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Cantidad</td>
                <td>
                    <asp:TextBox ID="txt_Cantidad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Fecha de Zarpe</td>
                <td>
                    <asp:TextBox ID="txt_FechaZarpe" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td  align="center" colspan="4">
                    <asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" OnClick="btn_Limpiar_Click" />
                    &nbsp;<asp:Button ID="btn_Grabar" runat="server" Text="Grabar" 
                        onclick="btn_Grabar_Click" />
                    &nbsp;<asp:Button ID="btn_Salir" runat="server" Text="Salir" Width="59px" />
                </td>
            </tr>
            <tr>
                <td  align="center" colspan="4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>