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
    public partial class Cadastro : System.Web.UI.Page
    {
        private AnimesRepository repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.repository = new AnimesRepository();
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Animes model = new Animes();
            model.ID = Convert.ToInt32(txtId.Text);
            model.Nome = txtNome.Text;
            model.Genero = txtGenero.Text;
            model.QuantidadeTemporadas = Convert.ToInt32(txtQtTp.Text);
            model.QuantidadeEpisodios = Convert.ToInt32(txtQtEp.Text);
            repository.Salvar(model);
            this.LimparDados();

        }
        private void LimparDados()
        {
            this.txtId.Text = String.Empty;
            this.txtNome.Text = String.Empty;
            this.txtGenero.Text = String.Empty;
            this.txtQtTp.Text = String.Empty;
            this.txtQtEp.Text = String.Empty;
        }
    }
}