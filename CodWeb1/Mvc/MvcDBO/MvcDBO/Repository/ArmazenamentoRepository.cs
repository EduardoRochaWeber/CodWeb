using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class ArmazenamentoRepository : BaseRepository<Armazenamento>
    {
        //public void Create(Armazenamento model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Armazenamento.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<Armazenamento> Read()
        //{
        //    List<Armazenamento> list = new List<Armazenamento>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.Armazenamento.ToList();
        //    }
        //    return list;
        //}
        //public Armazenamento Read(int id)
        //{
        //    Armazenamento model = new Armazenamento();
        //    using (var context = new CompContext())
        //    {
        //        model = context.Armazenamento.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(Armazenamento model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Armazenamento>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Armazenamento>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}