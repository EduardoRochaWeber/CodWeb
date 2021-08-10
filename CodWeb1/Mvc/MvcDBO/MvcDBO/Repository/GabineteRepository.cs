using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class GabineteRepository : BaseRepository<Gabinete>
    {
        //public void Create(Gabinete model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Gabinete.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<Gabinete> Read()
        //{
        //    List<Gabinete> list = new List<Gabinete>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.Gabinete.ToList();
        //    }
        //    return list;
        //}
        //public Gabinete Read(int id)
        //{
        //    Gabinete model = new Gabinete();
        //    using (var context = new CompContext())
        //    {
        //        model = context.Gabinete.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(Gabinete model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Gabinete>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<Gabinete>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}