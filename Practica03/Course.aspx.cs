using Practica03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica03
{
    public partial class Course1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CourseManager curso = new CourseManager();
            if (!this.IsPostBack)
            {
                this.GridView1.DataSource = curso.GetAll();
                this.GridView1.DataBind();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            Course c = new Course();
            c.CourseID = Convert.ToInt32 (this.txtID.Text);
            c.Title = this.txtTitle.Text;
            c.Credits = Convert.ToInt32(this.txtCredits.Text);
            c.DepartmentID = Convert.ToInt32(this.DropDownList1.SelectedValue);

            CourseManager.Add(c);
            Response.Redirect("Course.aspx");
        }
    }
}