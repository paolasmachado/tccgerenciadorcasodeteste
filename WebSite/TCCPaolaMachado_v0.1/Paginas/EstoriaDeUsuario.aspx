﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EstoriaDeUsuario.aspx.cs" Inherits="Paginas_EstoriaDeUsuario" %>

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

    <!-- Timeline CSS -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/dist/css/timeline.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/dist/css/sb-admin-2.css" rel="stylesheet" />

    <!-- Morris Charts CSS -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/bower_components/morrisjs/morris.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="./startbootstrap-sb-admin-2-1.0.8/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    <link rel="icon" href="./Imagens/bug-16.png" type="image/x-icon" />
    <link rel="shortcut icon" href="./Imagens/bug-16.png" type="image/x-icon" />

</head>
<body>
    <div id="wrapper">

        <!-- Navigation -->
        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.aspx">Testágil</a>
            </div>
            <!-- /.navbar-header -->
            <ul class="nav navbar-top-links navbar-right">
                <!-- INFORMAÇÕES DA SPRINT -->
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-expanded="true">
                        <i class="fa fa-calendar fa-fw"></i><i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-messages">
                        <li>
                            <a href="#">
                                <div>
                                    <strong>
                                        <asp:Label ID="LabelSprints" runat="server" Text="Sprint xxx"></asp:Label>
                                    </strong>
                                </div>
                                <div>
                                    Data início:<asp:Label ID="LabelDataInicioSprint" runat="server" Text="10/02/2016"></asp:Label>
                                </div>
                                <div>
                                    Data final:<asp:Label ID="LabelDataFinalSprint" runat="server" Text="10/02/2016"></asp:Label>
                                </div>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-messages -->
                </li>
                <!-- /.dropdown -->

                <!-- TROCAR SPRINT -->
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-expanded="true">
                        <i class="fa fa-exchange fa-fw"></i><i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-messages">
                        <li>
                            <a href="#">
                                <div>
                                    <strong>
                                        <asp:Label ID="Label1" runat="server" Text="Sprint xxx"></asp:Label>
                                    </strong>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <strong>
                                        <asp:Label ID="Label2" runat="server" Text="Sprint xxx"></asp:Label>
                                    </strong>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <strong>
                                        <asp:Label ID="Label3" runat="server" Text="Sprint xxx"></asp:Label>
                                    </strong>
                                </div>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-messages -->
                </li>
                <!-- /.dropdown -->

                <!-- CONFIGURAÇÕES -->
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-expanded="false">
                        <i class="fa fa-gears fa-fw"></i><i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-alerts">
                        <li>
                            <a href="Projeto.aspx">
                                <div>
                                    <strong>
                                        <label>Configurar projeto</label>
                                    </strong>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="Sprint.aspx">
                                <div>
                                    <strong>
                                        <label>Configurar sprint</label></strong>
                                </div>
                            </a>
                        </li>
                    </ul>
                </li>
                <!-- /.dropdown -->
                <!-- USUÁRIOS -->
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-expanded="false">
                        <i class="fa fa-user fa-fw"></i><i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li>
                            <a href="#"><i class="fa fa-user fa-fw"></i>
                                <asp:Label runat="server" ID="LabelBoasVindas"></asp:Label></a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="UsuarioDoSistema.aspx"><i class="fa fa-users fa-fw"></i>Usuários</a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="Login.aspx"><i class="fa fa-sign-out fa-fw"></i>Logout</a>
                        </li>
                    </ul>
                    <!-- /.dropdown-user -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-top-links -->

            <div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                    <ul class="nav" id="side-menu">
                        <li>
                            <a href="Index.aspx"><i class="fa fa-dashboard fa-fw"></i>Dashboard</a>
                        </li>
                       <li>
                            <a href="#"><i class="fa fa-edit fa-fw"></i>Criar</a>
                            <ul class="nav nav-second-level">
                                <li>
                                    <a href="Projeto.aspx">Projeto</a>
                                </li>
                                <li>
                                    <a href="Personagem.aspx">Personagem</a>
                                </li>
                                <li>
                                    <a href="EstoriaDeUsuario.aspx">Estória de Usuário</a>
                                </li>
                                <li>
                                    <a href="CriterioDeAceitacao.aspx">Critério de aceitação</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href="ListagemConfigurarProjeto.aspx"><i class="fa fa-wrench fa-fw"></i>Configurar</a>
                        </li>
                    </ul>
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->
        </nav>

        <div id="page-wrapper" style="min-height: 143px;">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="page-header">Estória de usuário</h1>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!-- /.row -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <asp:Label ID="LabelTipo" runat="server" Text=""></asp:Label>
                            estória de usuário
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-6">
                                    <form id="form1" runat="server" role="form">

                                        <div class="form-group">
                                            <label>Título</label>
                                            <asp:TextBox ID="CampoTituloHistoria" runat="server" class="form-control"></asp:TextBox>
                                        </div>

                                        <div class="form-group">
                                            <label>Prioridade</label>
                                            <asp:DropDownList ID="CampoPrioridade" runat="server" class="form-control">
                                                <asp:ListItem Value="01">01 - Prioridade Baixa</asp:ListItem>
                                                <asp:ListItem Value="02">02 - Prioridade Média</asp:ListItem>
                                                <asp:ListItem Value="03">03 - Prioridade Alta</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>

                                        <div class="form-group">
                                            <label>Pontos</label>
                                            <asp:TextBox ID="CampoPontos" runat="server" class="form-control"></asp:TextBox>
                                        </div>

                                        <div class="form-group">
                                            <label>Como</label>
                                            <asp:TextBox ID="CampoComo" runat="server" class="form-control"></asp:TextBox>
                                        </div>

                                        <div class="form-group">
                                            <label>Desejo</label>
                                            <asp:TextBox ID="CampoDesejo" runat="server" class="form-control"></asp:TextBox>
                                        </div>

                                        <div class="form-group">
                                            <label>Assim</label>
                                            <asp:TextBox ID="CampoAssim" runat="server" class="form-control"></asp:TextBox>
                                        </div>

                                        <asp:Button ID="ButtonEnviar" runat="server" Text="Enviar" type="submit" class="btn btn-success" OnClick="ButtonEnviar_Click" />

                                        <asp:Button ID="ButtonCriterio" runat="server" Text="Adicionar Critério de aceitação" class="btn btn-success" OnClick="ButtonCriterio_Click" />

                                    </form>
                                </div>
                                <!-- /.col-lg-6 (nested) -->
                            </div>
                            <!-- /.col-lg-6 (nested) -->
                        </div>
                        <!-- /.row (nested) -->
                    </div>
                    <!-- /.panel-body -->
                </div>
                <!-- /.panel -->
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/dist/js/sb-admin-2.js"></script>

</body>
</html>
