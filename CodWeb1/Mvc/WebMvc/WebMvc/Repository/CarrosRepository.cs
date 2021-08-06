using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvc.Models;

namespace WebMvc.Models
{
    public class CarrosRepository
    {
        private static List<Carros> listaCarros = new List<Carros>();
        public void Salvar(Carros model)
        {
            listaCarros.Add(model);
        }
        public List<Carros> Listar()
        {
            return listaCarros;
        }

        public List<Carros> Ler()
        {
            return listaCarros;
        }
        public Carros Ler(int id)
        {
            return listaCarros.Find(c => c.Id == id);
        }

        public void Deletar(int id)
        {
            Carros ID = Ler(id);
            if (ID != null)
            {
                listaCarros.Remove(ID);
            }
        }
        public void Editar(Carros model)
        {
            int index = listaCarros.FindIndex(c => c.Id == model.Id);
            listaCarros[index] = model;
        }
    }
}