<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarTurno.aspx.cs" Inherits="Presentacion.EditarTurno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="card w-75">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <h3>Modificacion de Turno
                        </h3>

                        <div class ="form-group">
                            <asp:Label ID="lblNombreReserva" runat="server" Text="Nombre de Reserva"></asp:Label>
                            <asp:TextBox ID="txtNombreReserva" runat="server" Class="form-control" ></asp:TextBox>
                        </div>

                        <div class ="form-group">
                            <asp:Label ID="lblFecha" runat="server" Text="Fecha"></asp:Label>
                            <asp:TextBox ID="txtFecha" runat="server" Class="form-control" ></asp:TextBox>
                        </div>

                        <div class ="form-group">
                            <asp:Label ID="lblNumCancha" runat="server" Text="N° de Cancha"></asp:Label>
                            <asp:TextBox ID="txtNumCancha" runat="server" Class="form-control" ></asp:TextBox>
                        </div>

                         <div class="form-group">
                            <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>   
                            <asp:DropDownList ID="ddlEstado" runat="server" Class="form-control">
                                <asp:ListItem Text ="Seleccionar" Value="Seleccionar"></asp:ListItem>
                                <asp:ListItem Text ="Libre" Value="Libre"></asp:ListItem>
                                <asp:ListItem Text ="Ocupado" Value="Ocupado"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="lblFranjaHoraria" runat="server" Text="Franja Horaria"></asp:Label>   
                            <asp:DropDownList ID="ddlFranjaHoraria" runat="server" Class="form-control">
                                <asp:ListItem Text ="Seleccionar" Value="Seleccionar"></asp:ListItem>
                                <asp:ListItem Text ="Mañana" Value="Mañana"></asp:ListItem>
                                <asp:ListItem Text ="Tarde" Value="Tarde"></asp:ListItem>
                                <asp:ListItem Text ="Noche" Value="Noche"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        

                        <div>
                            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Class="btn btn-success" Text="Guardar Modificacion" />
                        </div>

                        


                   </div>
            </div>
         </div>
        </div>
    </div>


</asp:Content>
