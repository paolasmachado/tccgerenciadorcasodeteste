<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsuarioDoSistema.aspx.cs" Inherits="Paginas_UsuarioDoSistema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelBoasVindas" runat="server" Text="Usuário não identificado"></asp:Label>
        </div>

        <div>
            <asp:Label ID="LabelUsuario" runat="server" Text="Usuário:"></asp:Label>
            <asp:TextBox ID="CampoUsuario" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelNome" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="CampoNome" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelEmail" runat="server" Text="E-mail:"></asp:Label>
            <asp:TextBox ID="CampoEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelPerfil" runat="server" Text="Perfil:"></asp:Label>
            &nbsp;<asp:DropDownList ID="CampoPerfil" runat="server">
                <asp:ListItem Selected="True">Selecione</asp:ListItem>
                <asp:ListItem Value="01">Product Owner</asp:ListItem>
                <asp:ListItem Value="02">ScrumMaster</asp:ListItem>
                <asp:ListItem Value="03">Desenvolvedor</asp:ListItem>
                <asp:ListItem Value="04">Testador</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="LabelSenha" runat="server" Text="Senha:"></asp:Label>
            <asp:TextBox ID="CampoSenha" runat="server" type="password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BotaoEnviar" runat="server" Text="Enviar" OnClick="BotaoEnviar_Click" />
        </div>

    </form>
</body>
</html>
