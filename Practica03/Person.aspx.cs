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
            p.HireDate = Convert.ToDateTime(this.txtHireDate.Text);
            p.EnrollmentDate = Convert.ToDateTime(this.txtEnroll.Text);
            PersonManager.Add(p);
            Response.Redirect("Person.aspx");
        }
    }
}