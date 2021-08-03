using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsVazio.Models;
using WebFormsVazio.Repository;

namespace WebFormsVazio
{
    public partial class Lista : System.Web.UI.Page
    {
        private AnimesRepository repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.repository = new AnimesRepository();
            this.dgvAnimes.DataSource = repository.Listar();
            this.dgvAnimes.DataBind();
        }
    }
}