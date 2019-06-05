<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearCancha.aspx.cs" Inherits="Presentacion.CrearCancha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card w-75">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <h3>Crear Cancha
                        </h3>

                        <div class="form-group">
                            <asp:Label ID="lblNumeroCancha" runat="server" Text="Numero de Cancha"></asp:Label>
                            <asp:TextBox ID="txtNumeroCancha" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-check">                          
                            <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>                        
                        <div>
                            <asp:CheckBox ID="CbxSi"  runat="server" Text="Ocupado" />                            
                        </div>
                        </div>                    
                        <div>
                            <asp:Button ID="btnGuardarCancha" runat="server" OnClick="btnGuardarCancha_Click" Class="btn btn-success" Text="Guardar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
