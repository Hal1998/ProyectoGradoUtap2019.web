<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/TemplateCordinador.Master" AutoEventWireup="true" CodeBehind="GestionarUsuario.aspx.cs" Inherits="ProyectoGradoUtap2019.web.Views.Gestionar_Usuarios.GestionarUsuario" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <div class="mx-auto mt-5">
        <%-- PRIMERA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h1>
                        <b>Registrar Usuario</b>
                        <asp:Label runat="server" ID="lblOpcion" Visible="false"></asp:Label>
                    </h1>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblNombre" Text="Nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblApellido" Text="Apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblTipoUsuario" Text="Tipo de Usuario"></asp:Label>
                    <asp:DropDownList ID="ddlTipoUsuario" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value=" "> </asp:ListItem>
                        <asp:ListItem Value="Monitor"> Monitor</asp:ListItem>
                        <asp:ListItem Value="Coordinador"> Coordinador</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <%-- SEGUNDA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblUsuario" Text="Usuario"></asp:Label>
                    <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblContraseña" Text="Contraseña"></asp:Label>
                    <asp:TextBox runat="server" ID="txtContraseña" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%-- CUARTA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
        <%-- QUINTA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h3>
                        <b>Usuarios</b>
                    </h3>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:GridView runat="server" ID="gvwUsuarios" AutoGenerateColumns="False" EmptyDataText="No se encontraron Registros"
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"
                        OnRowCommand="gvwUsuarios_RowCommand">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:TemplateField Visible="false">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblCodigo" Text='<% Bind("inId") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Nombre" DataField="stNombre" />
                            <asp:BoundField HeaderText="Apellido" DataField="stApellido" />
                            <asp:BoundField HeaderText="Usuario" DataField="stUsuario" />
                            <asp:BoundField HeaderText="Contraseña" DataField="stContraseña" />
                            <asp:BoundField HeaderText="Tipo_Usuario" DataField="stTipoUs" />
                            <asp:BoundField HeaderText="Correo" DataField="stCorreo" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
