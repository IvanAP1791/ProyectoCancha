<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarCancha.aspx.cs" Inherits="Presentacion.ListarCancha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Listado de Canchas</h1>
            <asp:GridView ID="GridViewTablaCliente" AutoGenerateColumns="False" runat="server" DataKeyNames="IdCancha" class="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField DataField="IdCancha" HeaderText="ID" />
                    <asp:BoundField DataField="numeroCancha" HeaderText="Numero de Cancha" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:TemplateField ShowHeader="false">
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
