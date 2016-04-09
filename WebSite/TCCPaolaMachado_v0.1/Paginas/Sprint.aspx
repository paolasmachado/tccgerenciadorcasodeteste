<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sprint.aspx.cs" Inherits="Paginas_Sprint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="LabelBoasVindas" runat="server" Text="Usuário não identificado"></asp:Label>
        <div>
            <asp:Label ID="LabelTituloPagina" runat="server" Text="Sprint"></asp:Label>
        </div>

        <div>
            <asp:Label ID="LabelID" runat="server" Text="ID : "></asp:Label>
            <asp:TextBox ID="CampoID" runat="server"></asp:TextBox>

            <asp:Label ID="LabelNomeSprint" runat="server" Text="Nome Sprint :"></asp:Label>
            <asp:TextBox ID="CampoProjeto" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="LabelInicio" runat="server" Text="Data início : "></asp:Label>
            <asp:TextBox ID="CampoDataInicio" runat="server"></asp:TextBox>

            <asp:Label ID="LabelDataFinal" runat="server" Text="Data final : "></asp:Label>
            <asp:TextBox ID="CampoDataFinal" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonEnviar" runat="server" Text="Enviar" />
        </div>
    </form>
</body>
</html>
