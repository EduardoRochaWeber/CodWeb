using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class PlacaMaeRepository : BaseRepository<PlacaMae>
    {
        //public void Create(PlacaMae model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.PlacaMae.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<PlacaMae> Read()
        //{
        //    List<PlacaMae> list = new List<PlacaMae>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.PlacaMae.ToList();
        //    }
        //    return list;
        //}
        //public PlacaMae Read(int id)
        //{
        //    PlacaMae model = new PlacaMae();
        //    using (var context = new CompContext())
        //    {
        //        model = context.PlacaMae.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(PlacaMae model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<PlacaMae>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<PlacaMae>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}