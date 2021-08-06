using AnimeListMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeListMvc.Repository
{
    public class BaseRepository<T> where T: BaseModel
    {
        private static List<T> list = new List<T>();
        public void Create(T model)
        {
            list.Add(model);
        }
        public List<T> Read()
        {
            return list;
        }
        public T Read(int id)
        {
            return list.Find(a => a.Id == id);
        }

        public void Update(T model)
        {
            int index = list.FindIndex(c => c.Id == model.Id);
            if (index != -1)
            {
                list[index] = model;
            }
        }
        public void Delete(int id)
        {
            T model = Read(id);
            if (model != null)
            {
                list.Remove(model);
            }
        }
    }
}