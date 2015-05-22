
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="wf_Folio_Nuevo.aspx.cs" Inherits="Expo_Ejecucion_wf_Folio_Nuevo" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <div>
    
   
        <asp:UpdatePanel ID="updCombo" runat="server">
                        <ContentTemplate>
        <table style="width:100%;">
            <tr>
                <td colspan="4">
                    CREAR FOLIO DE DESPACHO
                    
                </td>
            </tr>
            <tr>
                <td>
                    <table  style="width:100%;">
                        <tr>
                            <td>Nro. Requerimiento</td>
                            <td>
                                <asp:TextBox ID="txtNroRequerimiento" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnConsultarNroRequerimiento" runat="server" Text="Buscar Requerimiento" OnClick="btnConsultarNroRequerimiento_Click" />
                            </td>
                            <td>F. Despacho</td>
                            <td>
                                <asp:TextBox ID="txtFechaDespacho" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>
            
            <tr>
                <td>
                    <table  style="width:100%;">
                        <tr>
                            <td colspan="2">Asociar documentos</td>
                        </tr>
                        <tr>
                            <td>Cliente</td>
                            <td>
                                <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
                                <asp:HiddenField ID="htxtIdRequerimiento" runat="server" />
                                <asp:HiddenField ID="htxtIdCliente" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="grvRequerimiento" runat="server">
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>

                </td>
                
            </tr>
             

            <tr>
                <td>
                    
                            <table  style="width:100%;">
                                <tr>
                                    <td colspan="5">Informacion del Requerimiento</td>
                                </tr>
                                <tr>
                                    <td>Tipo de Documento</td>
                                    <td>
                               
                                        <asp:DropDownList  ID="ddlTipoDocumento" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoDocumento_SelectedIndexChanged" >  </asp:DropDownList>
                              
                                    </td>
                                    <td>
                                       Número de Documento
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNumeroDocumento" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnAgregarDocumento" runat="server" Text="Agregar" OnClick="btnAgregarDocumento_Click" />
                                        &nbsp;
                                        <asp:Button ID="btnQuitarDocumento" runat="server" Text="Quitar" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        <asp:GridView ID="grvDocumentos" runat="server" AutoGenerateColumns="False">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkIdFolioDetalle" runat="server" />
                                                        <asp:HiddenField ID="htxtIdFolioDetalle" Value='<%# DataBinder.Eval(Container.DataItem,"sCodigoTipoDocumento") %>' runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="sCodigoTipoDocumento" HeaderText="Codigo" />
                                                <asp:BoundField DataField="sDescripcionTipoDocumento" HeaderText="Documento" />
                                            </Columns>
                                        </asp:GridView>
                                
                                    </td>
                                </tr>
                            </table>

                        

                </td>
                
            </tr>
            <tr>
                <td  align="center" >&nbsp;</td>
            </tr>
        </table>
            </ContentTemplate>
    </asp:UpdatePanel>

        <table>
             <tr>
                <td  align="center" >
                    <asp:Button ID="btnLimpiarFolio" runat="server" Text="Limpiar" />
                    &nbsp;
                    <asp:Button ID="btnGrabarFolio" runat="server" Text="Grabar" OnClick="btnGrabarFolio_Click"  />
                    &nbsp;

                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
