using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsVazio.Models;

namespace WebFormsVazio.Repository
{
    public class AnimesRepository
    {
        private static List<Animes> listaAnimes = new List<Animes>();
        public void Salvar(Animes model)
        {
            listaAnimes.Add(model);
        }
        public void Editar(Animes model)
        {
            Animes modelAnterior = listaAnimes.Find(a => a.ID == model.ID);
            if (modelAnterior != null)
            {
                modelAnterior = model;
            }
        }
        public void Deletar(int id)
        {
            Animes model = listaAnimes.Find(a => a.ID == id);
            if (model != null)
            {
                listaAnimes.Remove(model);
            }
        }
        public List<Animes> Listar()
        {
            return listaAnimes;
        }
    }
}