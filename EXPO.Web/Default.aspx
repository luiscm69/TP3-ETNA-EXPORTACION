<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Baterias ETNA
    </h2>
    <table">
        <tr>
            <th><a href="Expo_Ejecucion/wf_ConocimientoEmbarque_Nuevo.aspx">Nuevo</a></th>
        </tr>
        <tr>
            <th><a href="Expo_Ejecucion/wf_ConocimientoEmbarque_Modificar.aspx">Modificar</a></th>
        </tr>
        <tr>
            <th><a href="Expo_Ejecucion/wf_ConocimientoEmbarque_Listado.aspx">Listado</a></th>
        </tr>
    </table>

</asp:Content>
