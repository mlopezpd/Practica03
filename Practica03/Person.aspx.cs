using Practica03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica03
{
    public partial class Person1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                this.GridView1.DataSource = PersonManager.GetAll();
                this.GridView1.DataBind();
            }
           
        }

        protected void BGuardar_Click(object sender, EventArgs e)
        {
            

            Person p = new Person();
            p.FirstName = this.txtNombre.Text;
            p.LastName = this.txtApellido.Text;

            DateTime fec1 = new DateTime(1753,01,01); //fecha mínima que acepta el sistema
            DateTime fec2 = new DateTime(1753,01,01);
            if (this.txtHireDate.Text != "")
            {
                string[] fecha = this.txtHireDate.Text.Split('/');
                if (fecha.Length == 3)
                {
                    int anio = Int32.Parse(fecha[2]);
                    int mes = Int32.Parse(fecha[1]);
                    int dia = Int32.Parse(fecha[0]);
                    fec1 = new DateTime(anio, mes, dia);
                }
            }
            if (this.txtEnroll.Text != "")
            {
                string[] fecha = this.txtEnroll.Text.Split('/');
                if (fecha.Length == 3)
                {
                    int anio = Int32.Parse(fecha[2]);
                    int mes = Int32.Parse(fecha[1]);
                    int dia = Int32.Parse(fecha[0]);
                    fec2 = new DateTime(anio, mes, dia);
                }
            }
            p.HireDate = fec1;
            p.EnrollmentDate = fec2;
            PersonManager.Add(p);
            Response.Redirect("Person.aspx");
        }
    }
}