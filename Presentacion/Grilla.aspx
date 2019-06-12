<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grilla.aspx.cs" Inherits="Presentacion.Grilla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gdvGrilla"  runat="server"></asp:GridView>
        </div>
        <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
        <asp:dropdownlist ID="ddlDocumento" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlDocumento_SelectedIndexChanged">
           <%-- <asp:listitem text="DNI" value="1"></asp:listitem>
            <asp:listitem text="Passaporte" value="2"></asp:listitem>
            <asp:listitem text="LC" value="3"></asp:listitem>--%>

        </asp:dropdownlist>

    </form>
</body>
</html>

