<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica03.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="navbar navbar-inverse">
                <div class="navbar-header">
                    <a class="navbar-brand" style="margin-left:35px;" href="#">Consulta de Empleados</a>
                </div>
            </div>
        </header>
        <section class="col-md-4 col-md-offset-4">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    Entidades
                </div>
                <div class="panel-body">
                    <a href="Course.aspx" class="btn btn-primary col-md-10 col-md-offset-1">Cursos</a>
                    <br /><br />
                    <a href="Person.aspx" class="btn btn-primary col-md-10 col-md-offset-1">Personas</a>
                    <br /><br /><br />
                </div>
            </div>
        </section>
        <div class="modal-footer col-md-10 col-md-offset-1">
            <p class="text-center">&copy 2014.</p>
            <p class="text-center">Alejandro Verdegay Arcos / Daniel Zapata Viciana / Iván J. Membrilla / Miguel A. López.</p>
        </div>
    </form>
</body>
</html>
