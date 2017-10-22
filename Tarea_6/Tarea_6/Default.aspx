<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tarea_6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 102px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style6 {
            width: 102px;
            height: 49px;
        }
        .auto-style8 {
            text-align: left;
            font-size: xx-large;
        }
        .auto-style9 {
            width: 95px;
            height: 49px;
        }
        .auto-style10 {
            width: 95px;
        }
        .auto-style11 {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style8">
            <ol>
                <li>
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sistema De Venta Discografica</h1>
                </li>
            </ol>
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style9">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registros/Usuario.aspx">rUsuarios</asp:HyperLink>
                </td>
                <td class="auto-style6">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registros/Categoria.aspx">Categorias</asp:HyperLink>
                </td>
                <td class="auto-style11">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Login.aspx">LogIn</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
