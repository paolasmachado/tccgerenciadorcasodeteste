﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

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
                                    <asp:Label ID="Label4" runat="server" Text="Sprint xxx"></asp:Label>
                                </strong>
                            </div>
                            <div>
                                Data início:<asp:Label ID="Label5" runat="server" Text="10/02/2016"></asp:Label>
                            </div>
                            <div>
                                Data final:<asp:Label ID="Label6" runat="server" Text="10/02/2016"></asp:Label>
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
                                    <asp:Label ID="Label7" runat="server" Text="Sprint xxx"></asp:Label>
                                </strong>
                            </div>
                        </a>
                    </li>
                    <li class="divider"></li>
                    <li>
                        <a href="#">
                            <div>
                                <strong>
                                    <asp:Label ID="Label8" runat="server" Text="Sprint xxx"></asp:Label>
                                </strong>
                            </div>
                        </a>
                    </li>
                    <li class="divider"></li>
                    <li>
                        <a href="#">
                            <div>
                                <strong>
                                    <asp:Label ID="Label9" runat="server" Text="Sprint xxx"></asp:Label>
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
                <ul class="dropdown-menu dropdown-alerts"></ul>
            </li>
            <!-- /.dropdown -->
            <!-- USUÁRIOS -->
            <li class="dropdown">
                <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-expanded="false">
                    <i class="fa fa-user fa-fw"></i><i class="fa fa-caret-down"></i>
                </a>
                <ul class="dropdown-menu dropdown-user">
                    <li>
                        <a href="#"><i class="fa fa-user fa-fw"></i>Perfil do usuário</a>
                    </li>
                    <li class="divider"></li>
                    <li>
                        <a href="login.html"><i class="fa fa-sign-out fa-fw"></i>Logout</a>
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
                        <a href="#"><i class="fa fa-bar-chart-o fa-fw"></i>Relatórios<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <!-- ADICIONAR LINK DO RELATÓRIO -->
                                <a href="flot.html">Defeitos</a>
                            </li>
                            <li>
                                <!-- ADICIONAR LINK DO RELATÓRIO -->
                                <a href="morris.html">Melhorias</a>
                            </li>
                        </ul>
                    </li>
                    <li class="">
                        <a href="#"><i class="fa fa-edit fa-fw"></i>Forms</a>
                        <ul class="nav nav-second-level">
                            <li>
                                <a href="Backlog.aspx">Backlog</a>
                            </li>
                            <li>
                                <a href="ListagemHistoriaDeUsuario.aspx">Estória de Usuário</a>
                            </li>
                            <li>
                                <a href="Persona.aspx">Persona</a>
                            </li>
                            <li>
                                <a href="Atividades.aspx">Atividades</a>
                            </li>
                            <li>
                                <a href="Testes.aspx">Plano de Testes</a>
                            </li>
                            <li>
                                <a href="Testes.aspx">Testes</a>
                            </li>
                            <li>
                                <a href="Melhoria.aspx">Melhoria</a>
                            </li>
                            <li>
                                <a href="Defeito.aspx">Bugs</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <!-- /.sidebar-collapse -->
        </div>
        <!-- /.navbar-static-side -->
    </nav>

    <!-- /.navbar-static-side -->


    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Dashboard</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <div class="row">
            <div class="col-lg-3 col-md-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-book fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="huge">
                                    <asp:Label ID="QuantidadeEstoriaDeUsuario" runat="server" Text=""></asp:Label>
                                </div>
                                <div>Estória de Usuário</div>
                            </div>
                        </div>
                    </div>
                    <a href="#">
                        <div class="panel-footer">
                            <span class="pull-left">Ver detalhes</span>
                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                            <div class="clearfix"></div>
                        </div>
                    </a>
                </div>
            </div>
            <div class="col-lg-3 col-md-6">
                <div class="panel panel-green">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-tasks fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="huge">
                                    <asp:Label ID="QuantidadeAtividades" runat="server" Text=""></asp:Label>
                                </div>
                                <div>Atividades</div>
                            </div>
                        </div>
                    </div>
                    <a href="#">
                        <div class="panel-footer">
                            <span class="pull-left">Ver detalhes</span>
                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                            <div class="clearfix"></div>
                        </div>
                    </a>
                </div>
            </div>
            <div class="col-lg-3 col-md-6">
                <div class="panel panel-yellow">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-exclamation-circle fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="huge">
                                    <asp:Label ID="QuantidadeTestes" runat="server" Text=""></asp:Label>
                                </div>
                                <div>Testes</div>
                            </div>
                        </div>
                    </div>
                    <a href="#">
                        <div class="panel-footer">
                            <span class="pull-left">Ver detalhes</span>
                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                            <div class="clearfix"></div>
                        </div>
                    </a>
                </div>
            </div>
            <div class="col-lg-3 col-md-6">
                <div class="panel panel-red">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-bug fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="huge">
                                    <asp:Label ID="QuatidadeBugs" runat="server" Text=""></asp:Label>
                                </div>
                                <div>Bugs</div>
                            </div>
                        </div>
                    </div>
                    <a href="#">
                        <div class="panel-footer">
                            <span class="pull-left">Ver detalhes</span>
                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                            <div class="clearfix"></div>
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div>
    </div>
   
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Morris Charts JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/raphael/raphael-min.js"></script>
    <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/morrisjs/morris.min.js"></script>
    <!--<script src="./startbootstrap-sb-admin-2-1.0.8/js/morris-data.js"></script>-->

    <!-- Custom Theme JavaScript -->
    <script src="./startbootstrap-sb-admin-2-1.0.8/dist/js/sb-admin-2.js"></script>

    <!-- <script src="./startbootstrap-sb-admin-2-1.0.8/bower_components/bootstrap/js/dropdown.js"></script>-->
</body>
</html>
