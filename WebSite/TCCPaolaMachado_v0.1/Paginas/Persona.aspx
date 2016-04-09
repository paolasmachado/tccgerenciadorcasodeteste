<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Persona.aspx.cs" Inherits="Paginas_Persona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="LabelBoasVindas" runat="server" Text="Usuário não identificado"></asp:Label>
        <div>
            <asp:Label ID="LabelTituloPagina" runat="server" Text="Personas do projeto"></asp:Label>
        </div>

        <div>
            <asp:Label ID="LabelID" runat="server" Text="ID :"></asp:Label>
            <asp:TextBox ID="CampoID" runat="server"></asp:TextBox>

            <asp:Label ID="LabelPapel" runat="server" Text="Papel :"></asp:Label>
            <asp:TextBox ID="CampoPapel" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelDescricao" runat="server" Text="Descrição :"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" MaxLength="50000"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonEnviar" runat="server" Text="Enviar" />
        </div>

    </form>
</body>
</html>
