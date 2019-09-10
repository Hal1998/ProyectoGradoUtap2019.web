<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/TemplateCordinador.Master" AutoEventWireup="true" CodeBehind="MonitorCoordinador.aspx.cs" Inherits="ProyectoGradoUtap2019.web.Views.Monitor.MonitorCoordinador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <div class="row">
        <div class="col-md-12">
            <!-- Example Bar Chart Card-->
            <div class="card mb-3">
                <div class="card-header">
                    <i class="fa fa-bar-chart"></i>Consumo Mensual
                </div>
                <div class="card-body">
                    <canvas id="myBarChart" width="100" height="50"></canvas>
                </div>
                <div class="card-footer small text-muted">Actualizado!</div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <asp:Label runat="server" Style="color: black" Font-Bold="true">Ultima Revision</asp:Label>
                <asp:TextBox ID="txtUltimaRev" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <asp:Label runat="server" Style="color: black" Font-Bold="true">Proxima Revision</asp:Label>
                <asp:TextBox ID="txtProximaRev" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <div class="form-group">
                <asp:Label runat="server" Style="color: black" Font-Bold="true">Temperatura</asp:Label>
                <asp:TextBox ID="txtTemperatura" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-2">
            <div class="form-group">
                <asp:Label runat="server" Style="color: black" Font-Bold="true">Rango Minimo</asp:Label>
                <asp:TextBox ID="txtRangoMin" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <h1>_</h1>
        <div class="col-md-2">
            <div class="form-group">
                <asp:Label runat="server" Style="color: black" Font-Bold="true">Rango Maximo</asp:Label>
                <asp:TextBox ID="txtRangoMax" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-2">
            <div class="form-group">
                <asp:Label runat="server" Style="color: black" Font-Bold="true">Estado Motor</asp:Label>
                <asp:TextBox ID="txtEstadoMot" runat="server" CssClass="form-control" ReadOnly="true" BackColor="Black"></asp:TextBox>
            </div>
        </div>
</asp:Content>
