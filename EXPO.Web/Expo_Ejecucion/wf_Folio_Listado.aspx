<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.master" CodeFile="wf_Folio_Listado.aspx.cs" Inherits="Expo_Ejecucion_wf_Folio_Listado" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <table style="width:100%;"> 
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
                    Fecha Inicial</td>
                <td>
                    <asp:TextBox ID="txt_FechaZarpeIni" runat="server"></asp:TextBox>
                </td>
                <td>
                    Fecha Final</td>
                <td>
                    <asp:TextBox ID="txt_FechaZarpeFin" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" 
                        onclick="btn_Buscar_Click" Width="61px" />
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo"  Width="61px" OnClick="btnNuevo_Click" />
                </td>
            </tr>
            <tr style="text-align:center">
                <td colspan="5" style="text-align:center">
                <asp:GridView ID="grvLIstado" runat="server">
                </asp:GridView>
                </td>
                
            </tr>
        </table>
    

  

</asp:Content>
