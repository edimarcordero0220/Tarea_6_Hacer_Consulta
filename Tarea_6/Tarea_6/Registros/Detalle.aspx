<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Tarea_6.Registros.Detalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 60px;
        }
        .auto-style5 {
            width: 152px;
        }
        .auto-style6 {
            width: 143px;
        }
        .auto-style7 {
            font-size: medium;
            margin-left: 263px;
        }
        .auto-style8 {
            font-size: small;
        }
        .auto-style9 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style2">
            <h2 class="auto-style3">Detalle</h2>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">Id</td>
                <td>
                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Fecha</td>
                <td>
                    <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Descripcion</td>
                <td>
                    <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">Categoria</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="CategoriaDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>Monto<asp:TextBox ID="MontoTextBox" runat="server"></asp:TextBox>
                    <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:DataList ID="DataList1" runat="server" CssClass="auto-style9" DataKeyField="CategoriaId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" Width="166px">
                        <ItemTemplate>
                            CategoriaId:
                            <asp:Label ID="CategoriaIdLabel" runat="server" Text='<%# Eval("CategoriaId") %>' />
                            <br />
                            Descripcion:
                            <asp:Label ID="DescripcionLabel" runat="server" Text='<%# Eval("Descripcion") %>' />
                            <br />
                            <asp:Button ID="AgregarButton" runat="server" OnClick="AgregarButton_Click1" Text="Agregar" />
<br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>" SelectCommand="SELECT [CategoriaId], [Descripcion] FROM [Categorias]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" CssClass="auto-style7" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
