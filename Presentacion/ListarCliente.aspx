<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarCliente.aspx.cs" Inherits="Presentacion.ListarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Listado de Clientes</h1>
            <asp:GridView ID="GridViewTablaCliente" AutoGenerateColumns="False" runat="server" DataKeyNames="IdCliente" class="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField DataField="IdCliente" HeaderText="ID" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                    <asp:BoundField DataField="edad" HeaderText="Edad" />
                    <asp:BoundField DataField="documento" HeaderText="Documento" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="correoElectronico" HeaderText="Email" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                    <asp:TemplateField ShowHeader="false">
                        <ItemTemplate>
                            <%--<asp:Button ID="btnEditar" OnClick="btnEditar_Click"  CommandArgument='<%# Eval("IdCliente") %>' runat="server" Text="Editar" CssClass="btn btn-warning" />--%>
                            <asp:LinkButton ID="lnkEdit" OnCommand="lnkEdit_Command" runat="server" Text="Editar" CommandArgument='<%# Eval("IdCliente") %>' CssClass="btn btn-Warning" CommandName="lnkEditar" Font-Underline="false" />
                            <asp:LinkButton ID="lnkDelete" OnCommand="lnkDelete_Command" runat="server" Text="Borrar" CommandArgument='<%# Eval("IdCliente") %>' CssClass="btn btn-Warning" CommandName="lnkBorrar" Font-Underline="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
