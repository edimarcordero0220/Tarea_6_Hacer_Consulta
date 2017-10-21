<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Tarea_6.Registros.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id&nbsp;&nbsp;
        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
        <br />
        Nombre<asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
        <br />
        Clave&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ClaveTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
