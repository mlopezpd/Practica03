<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="Practica03.Course1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cursos</title>
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
                <a class="navbar-brand" style="margin-left:35px;" href="#">Dar Cursos de Alta </a>&nbsp;</div>
        </div>
    </header>
        <div class="container-fluid">
           
                
         
            <div class="col-md-6">
                
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Datos Cursos
                            </div>
                             <div class="panel-body">
                                <div class="form-horizontal">
                                <div class="form-group">
                                    <asp:Label ID="lblCourseID" runat="server" Text="CourseID" CssClass="col-md-2 control-label">ID del Curso</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtID" runat="server" CssClass="form-control" ></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblTitle" runat="server" Text="Title" CssClass="col-md-2 control-label">Titulo del Curso</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" ></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblCredits" runat="server" Text="Credits" CssClass="col-md-2 control-label">Creditos del Curso</asp:Label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtCredits" runat="server" CssClass="form-control" ></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblDepartamentID" runat="server" Text="DepartamentID" CssClass="col-md-2 control-label">ID de Departamento</asp:Label>
                                    <div class="col-md-9">
                                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="-1">Seleccione...</asp:ListItem>
                                            <asp:ListItem Value="1">Engineering</asp:ListItem>
                                            <asp:ListItem Value="2">English</asp:ListItem>
                                            <asp:ListItem Value="4">Economics</asp:ListItem>
                                            <asp:ListItem Value="7">Mathematics</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-default col-md-2 col-md-offset-5" Text="Guardar" OnClick="btnAdd_Click" />
                                </div>
                                
                            </div>
                             </div>
                        </div>
                    
            </div>

            <div class="col-md-6">
                
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Lista de cursos
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
