<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="Practica03.Course1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Empleados</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
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
        <div class="container-fluid">
           
                
         
            <div class="col-md-6">
                
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Datos de Empleados
                            </div>
                             <div class="panel-body">
                                <div class="form-horizontal">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="ID Empleado" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Nombre" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Apellido" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label6" runat="server" Text="Titulo" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label7" runat="server" Text="TituloCortesia" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtTituloCortesia" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label8" runat="server" Text="Notas" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtNotas" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label9" runat="server" Text="Territorios" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:ListBox ID="lbEmpleadoTerritorios" runat="server" CssClass="form-control" ReadOnly="true"></asp:ListBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Numero de Ventas" CssClass="col-md-2 control-label"></asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtNumeroVentas" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                             </div>
                        </div>
                    
            </div>
        </div>
        </form>
    </body>
    </html>
