<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>Sistema Testágil</title>

    <!-- Bootstrap Core CSS -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />

    <!-- MetisMenu CSS -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/dist/css/sb-admin-2.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Sistema Testágil - Login</h3>
                    </div>
                    <div class="panel-body">
                        <form id="form1" runat="server" role="form">
                            <fieldset>
                                <div class="form-group">
                                    <asp:TextBox ID="CampoUsuario" runat="server" class="form-control" placeholder="Usuário" name="email" type="email"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="CampoSenha" runat="server" class="form-control" placeholder="Senha" name="password" type="password" value=""></asp:TextBox>
                                </div>

                                <div class="alert alert-danger" style="display:none">
                                    Usuário ou senha incorretos.
                                </div>

                                <!-- Change this to a button or input when using this as a form -->
                                <asp:Button ID="BotaoEnviar" runat="server" Text="Login" OnClick="BotaoEnviar_Click" class="btn btn-lg btn-success btn-block" />
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- jQuery -->
    <script src="../bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="../bower_components/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="../dist/js/sb-admin-2.js"></script>

</body>
</html>
