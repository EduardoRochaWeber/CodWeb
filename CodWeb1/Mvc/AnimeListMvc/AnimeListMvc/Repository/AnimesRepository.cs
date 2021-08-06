using AnimeListMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeListMvc.Repository
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
            Animes modelAnterior = listaAnimes.Find(a => a.Id == model.Id);
            if (modelAnterior != null)
            {
                modelAnterior = model;
            }
        }
        public void Deletar(int id)
        {
            Animes model = listaAnimes.Find(a => a.Id == id);
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