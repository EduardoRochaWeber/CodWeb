using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class FonteRepository : BaseRepository<Fonte>
    {
        //public void Create(Fonte model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Fonte.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<Fonte> Read()
        //{
        //    List<Fonte> list = new List<Fonte>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.Fonte.ToList();
        //    }
        //    return list;
        //}
        //public Fonte Read(int id)
        //{
        //    Fonte model = new Fonte();
        //    using (var context = new CompContext())
        //    {
        //        model = context.Fonte.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(Fonte model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Fonte>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Fonte>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}