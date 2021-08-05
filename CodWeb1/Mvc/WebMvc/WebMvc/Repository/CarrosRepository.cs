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
        public void Deletar(int id)
        {
            var ID = listaCarros.Find(c => c.Id == id);
            if (ID != null)
            {
                listaCarros.Remove(ID);
            }
        }
        /*public void Editar(int id)
        {
            var ID = listaCarros.Find(c => c.Id == id);
            if (ID != null)
            {
                listaCarros.Find(ID);
            }
        }*/
    }
}