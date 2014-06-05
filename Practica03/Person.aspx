<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="Practica03.Person1" %>

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
                <a class="navbar-brand" style="margin-left:35px;" href="#">Dar Persona de Alta</a>
              
            </div>
        </div>
    </header>
        <div class="container-fluid">
           
                
         
            <div class="col-md-6">
                
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Datos Persona
                            </div>
                             <div class="panel-body">
                                <div class="form-horizontal">
                                
                                <div class="form-group">
                                    <asp:Label ID="LblNombre" runat="server" Text="FirstName" CssClass="col-md-2 control-label">Apellido</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="LblApellido" runat="server" Text="LastName" CssClass="col-md-2 control-label">Nombre</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="LblFechaContrato" runat="server" Text="HireDate" CssClass="col-md-2 control-label">Fecha Contrato</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtHireDate" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="LblFechaInscripcion" runat="server" Text="EnrollmentDate" CssClass="col-md-2 control-label">Fecha Inscripción</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtEnroll" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                
                                    </div>
                                    <div class="form-group">
                                  <asp:Button ID="BGuardar" CssClass="btn btn-default col-md-2 col-md-offset-5" runat="server" Text="Guardar" OnClick="BGuardar_Click"></asp:Button>

                                    </div>
                                


                               
                                    </div>
                               
                            </div>
                </div>
            </div>
            <div class="col-md-6">
                
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Lista de Personas
                            </div>
                             <div class="panel-body">
                                 <asp:GridView ID="GridView1" CssClass="table table-hover" runat="server"></asp:GridView>
                            </div>
                </div>
            </div>

            </div>
        </form>
    </body>
    </html>
