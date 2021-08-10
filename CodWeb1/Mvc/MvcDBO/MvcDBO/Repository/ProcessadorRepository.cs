using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class ProcessadorRepository : BaseRepository<Processador>
    {
        //public void Create(Processador model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Processador.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<Processador> Read()
        //{
        //    List<Processador> list = new List<Processador>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.Processador.ToList();
        //    }
        //    return list;
        //}
        //public Processador Read(int id)
        //{
        //    Processador model = new Processador();
        //    using (var context = new CompContext())
        //    {
        //        model = context.Processador.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(Processador model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Processador>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Processador>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}